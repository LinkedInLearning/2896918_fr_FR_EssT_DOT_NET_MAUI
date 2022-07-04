using LinkedinLearningMaui.Services;

namespace LinkedinLearningMaui;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		var postService = new PostService();
		var comments = postService.GetComments(1);
	}
}