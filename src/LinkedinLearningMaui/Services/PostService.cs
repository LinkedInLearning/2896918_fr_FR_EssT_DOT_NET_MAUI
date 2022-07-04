using LinkedinLearningMaui.Models;
using System.Net.Http.Json;

namespace LinkedinLearningMaui.Services;

public class PostService
{
    public async Task<List<Post>> GetAsync()
    {
        var http = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
        };

        return await http.GetFromJsonAsync<List<Post>>("posts");
    }

    public async Task<List<Comment>> GetCommentsAsync(int postId)
    {
        var http = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
        };

        return await http.GetFromJsonAsync<List<Comment>>($"posts/{postId}/comments");
    }
}
