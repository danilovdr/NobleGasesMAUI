using NobleGasesMAUI.Elements;
using NobleGasesMAUI.Elements.Helium;

namespace NobleGasesMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnClickElement(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HeliumPage());
	}
}

