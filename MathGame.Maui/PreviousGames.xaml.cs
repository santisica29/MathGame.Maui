namespace MathGame.Maui;

public partial class PreviousGames : ContentPage
{
	public PreviousGames()
	{
		InitializeComponent();
		App.GameRepository.GetAllGames();
		gamesList.ItemsSource = App.GameRepository.GetAllGames();
	}

	private void OnDelete(object sender, EventArgs e)
	{
		Button btn = (Button)sender;
		int gameId = (int)btn.CommandParameter;

		App.GameRepository.Delete(gameId);

		gamesList.ItemsSource = App.GameRepository.GetAllGames();
	}

    private void OnBackToMenu(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}