using LinkedinLearningMaui.Models;
using LinkedinLearningMaui.Services;
using System.Collections.ObjectModel;

namespace LinkedinLearningMaui;

public partial class DetailPage : ContentPage
{
	public ObservableCollection<Comment> Comments { get; set; } = new ObservableCollection<Comment>();

	public DetailPage()
	{
		InitializeComponent();

		this.BindingContext = this;
	}

	protected override async void OnAppearing()
	{
		var postService = new PostService();
		var comments = await postService.GetCommentsAsync(1);

		foreach (var item in comments)
			this.Comments.Add(item);
	}
}