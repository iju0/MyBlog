using Models;

namespace BLL.Interfaces;

public interface ICommentService
{
    List<Comment> GetCommentsByPostId(int id);
}