namespace TintedImageCheck;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Task.Delay(1000);
        await Shell.Current.GoToAsync(nameof(Test_Image));
    }
}


