using LinkedinLearningMaui.Models;
using LinkedinLearningMaui.Services;
using System.Net.Http.Json;

namespace LinkedinLearningMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		var postService = new PostService();
		var posts = await postService.GetAsync();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

