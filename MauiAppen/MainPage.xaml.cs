using MauiAppen.Models;
namespace MauiAppen;

public partial class MainPage : ContentPage
{
	int currentState = 1;
    string operatorMath; // The operator in use
    double firstNum = 0; // First number in calculation
    double secondNum = 0; // Second number in any calculation

	public MainPage()
	{
		InitializeComponent();

        // Preset clear func
        OnClear(this, null);
	}

	// Clears the calculation when "C" button is pressed
    void OnClear(object sender, EventArgs e)
    {
        firstNum = 0;
        secondNum = 0;
        currentState = 1;

        // Clear green space
        this.result.Text = "0";
        this.opchoice.Text = "";
    }

    // Exponentiation of number^x
    void OnExponent(object sender, EventArgs e)
    {
        if (firstNum == 0)
        {
            return;
        }
        this.opchoice.Text = $"{firstNum}²=";
        firstNum = firstNum * firstNum;
        this.result.Text = firstNum.ToString();
    }

    void Squareroot(object sender, EventArgs e)
    {
        if (firstNum == 0)
        {
            return;
        }
        this.opchoice.Text = $"√{firstNum}=";
        firstNum = Math.Sqrt(firstNum);
        this.result.Text = firstNum.ToString();
    }

    // Number selecteted
    void OnNumSelect(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string btnPressed = button.Text;

        // Check if a number other than 0 has been picked or if state is less than 0
        if (this.result.Text == "0" || currentState < 0)
        {
            this.result.Text = string.Empty;
			if(currentState < 0)
				currentState *= -1;
        }

        this.result.Text += btnPressed;

		double number;
        if(double.TryParse(this.result.Text, out number))
        {
            this.result.Text = number.ToString();
            if (currentState == 1)
            {
                firstNum = number;
            } else
            {
                secondNum = number;
            }
        }
    }

    void OnOpSelect(object sender, EventArgs e)
    {
        currentState = -2;
        Button button = (Button)sender;
        string btnPressed = button.Text;
        this.opchoice.Text = $"{firstNum}{button.Text}";
        this.result.Text = "0";
        operatorMath = btnPressed;

    }

    void Calculate(object sender, EventArgs e) {
        if(currentState == 2)
        {
            var result = NumberClass.DoCalculation(firstNum, secondNum, operatorMath);

            this.result.Text = result.ToString();
            this.opchoice.Text = $"{firstNum}{operatorMath}{secondNum}=";
            firstNum = result;
            currentState = -1;
        }
    }
}

