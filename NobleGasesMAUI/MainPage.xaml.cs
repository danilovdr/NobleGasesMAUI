using NobleGasesMAUI.Elements;
using NobleGasesMAUI.Elements.Helium;
using NobleGasesMAUI.Elements.Neon;

namespace NobleGasesMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnClickHelium(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HeliumPage());
	}

	private async void OnClickNeon(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new NeonPage());
	}
}

