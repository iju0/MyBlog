using DAL.Apis;
using DAL.Interfaces;
using Models;

namespace DAL;

public class PostRepository : IPostRepository
{
    public List<Post> GetPosts()
    {
        var api = new JsonPlaceHolderAPI();
        return api.GetPosts();
    }
}