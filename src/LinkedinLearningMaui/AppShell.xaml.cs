namespace LinkedinLearningMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("post/detail", typeof(DetailPage));
    }
}
