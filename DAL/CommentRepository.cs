using DAL.Apis;
using DAL.Interfaces;
using Models;

namespace DAL;

public class CommentRepository : ICommentRepository
{
    private JsonPlaceHolderAPI _api;
    
    public CommentRepository()
    {
        _api = new JsonPlaceHolderAPI();
    }
    
    public List<Comment> GetCommentsByPostId(int id)
    {
        var result =
            from comments in _api.GetComments()
            where comments.PostId == id
            select comments;

        return result.ToList();
    }
}