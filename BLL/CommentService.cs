using BLL.Interfaces;
using DAL.Interfaces;
using Models;

namespace BLL;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;
    public CommentService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public List<Comment> GetCommentsByPostId(int id)
    {
        return _commentRepository.GetCommentsByPostId(id);
    }
}