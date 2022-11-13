using System.Collections.ObjectModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		ObservableCollection<Game> games = new();

        for (int i = 1; i <= 10; i++)
        {
            games.Add(new Game() { Name = $"game{i:00}", Date = new DateTime(2022, 1, i) });
        }

        this.listView.ItemsSource = games;


    }
    private void OnMoreInvoked(object sender, EventArgs e)
    {
    }
    private void OnEditInvoked(object sender, EventArgs e)
    {
    }
    private void OnDeleteInvoked(object sender, EventArgs e)
    {
    }
}

public class Game
{
	public string Name { get; set; }

	public DateTime Date { get; set; }	

}