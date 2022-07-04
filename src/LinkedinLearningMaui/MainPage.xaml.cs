using LinkedinLearningMaui.Models;
using LinkedinLearningMaui.Services;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace LinkedinLearningMaui;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Post> Posts { get; set; } = new();

    public MainPage()
	{
		InitializeComponent();

        this.BindingContext = this;
    }

	protected override async void OnAppearing()
	{
		var postService = new PostService();
		var posts = await postService.GetAsync();

        foreach (var item in posts)
            Posts.Add(item);
    }

    private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var post = e.SelectedItem as Post;

        await Shell.Current.GoToAsync($"post/detail?id={post.Id}");
    }
}

