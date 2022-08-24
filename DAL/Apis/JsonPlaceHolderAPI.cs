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
    
    public List<User> GetUsers()
    {
        _request = new RestRequest("/users");
        var response = _client.Execute(_request);
        return JsonConvert.DeserializeObject<List<User>>(response.Content);
    }

    public List<Post> GetPosts()
    {
        _request = new RestRequest("/posts");
        var response = _client.Execute(_request);
        return JsonConvert.DeserializeObject<List<Post>>(response.Content);
    }

    public List<Album> GetAlbums()
    {
        _request = new RestRequest("/albums");
        var response = _client.Execute(_request);
        return JsonConvert.DeserializeObject<List<Album>>(response.Content);
    }
}