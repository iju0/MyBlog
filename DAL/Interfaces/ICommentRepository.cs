using Models;

namespace DAL.Interfaces;

public interface ICommentRepository
{
    List<Comment> GetCommentsByPostId(int id);
}