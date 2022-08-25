using BLL.Interfaces;
using DAL.Interfaces;
using Models;

namespace BLL;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;
    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }
    
    public List<Post>? GetPosts()
    {
        return _postRepository.GetPosts();
    }
}