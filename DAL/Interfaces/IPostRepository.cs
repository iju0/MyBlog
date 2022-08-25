using Models;

namespace DAL.Interfaces;

public interface IPostRepository
{
    List<Post>? GetPosts();
}