using Models;
using Newtonsoft.Json;
using RestSharp;

namespace DAL.Apis;

public class JsonPlaceHolderAPI
{
    private RestClient _client;
    private RestRequest _request;
    
    public JsonPlaceHolderAPI()
    {
        _client = new RestClient("https://jsonplaceholder.typicode.com/");
    }

    private T? DeserializeObject<T>(string? value)
    {
        return JsonConvert.DeserializeObject<T>(value);
    }

    private T? Execute<T>(RestRequest restRequest)
    {
        return DeserializeObject<T>(_client.Execute(restRequest).Content);
    }

    public List<User>? GetUsers()
    {
        _request = new RestRequest("/users");
        return Execute<List<User>>(_request);
    }

    public List<Post>? GetPosts()
    {
        _request = new RestRequest("/posts");
        return Execute<List<Post>>(_request);
    }

    public List<Album>? GetAlbums()
    {
        _request = new RestRequest("/albums");
        return Execute<List<Album>>(_request);
    }

    public List<Comment>? GetComments()
    {
        _request = new RestRequest("/comments");
        return Execute<List<Comment>>(_request);
    }

    public List<Photo>? GetPhotos()
    {
        _request = new RestRequest("/photos");
        return Execute<List<Photo>>(_request);
    }
}