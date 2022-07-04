using LinkedinLearningMaui.Models;
using LinkedinLearningMaui.Services;
using System.Collections.ObjectModel;

namespace LinkedinLearningMaui;

[QueryProperty(nameof(PostId), "id")]
public partial class DetailPage : ContentPage
{
	public ObservableCollection<Comment> Comments { get; set; } = new ObservableCollection<Comment>();

	public int PostId { get; set; }

	public DetailPage()
	{
		InitializeComponent();

		this.BindingContext = this;
	}

	protected override async void OnAppearing()
	{
		var postService = new PostService();
		var comments = await postService.GetCommentsAsync(PostId);

		foreach (var item in comments)
			this.Comments.Add(item);
	}
}