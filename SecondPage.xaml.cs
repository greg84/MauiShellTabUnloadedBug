namespace ShellTabsUnloadedBug;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();

        Unloaded += (sender, args) => System.Diagnostics.Debug.WriteLine("SecondPage Unloaded");
    }
}
