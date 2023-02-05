using MauiAppen.Models;
namespace MauiAppen;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		/*count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);*/

		//Navigation.PushAsync(new ContentPageDemo());

		/*
		string name = EntryName.Text;
		string ald = EntryAge.Text;

		if(Int32.TryParse(ald, out int alder)) { 
		
			Person person1 = new Person { Name = name, Year = alder};
			PersonLabel.Text = $"{person1.Name} är {person1.Year} år gammal.";
		} else
		{
			PersonLabel.Text = "Det gick fel i castningen från string till int";
		}
		*/
    }

	// Clears the calculation
    void OnClear(object sender, EventArgs e)
    {
        /*string num = "123";

        NumberClass numberclass1 = new NumberClass { Num = num };
        NumberLabel.Text = $"Du klickade på siffran {numberclass1.Num}.";*/
    }

	// Exponentiation of number^x
    void OnExponent(object sender, EventArgs e)
    {
       
    }

    // Number selecteted
    void OnNumSelect(object sender, EventArgs e)
    {

    }
}

