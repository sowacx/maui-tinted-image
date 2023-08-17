namespace TintedImageCheck;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Test_Image), typeof(Test_Image));
    }
}

