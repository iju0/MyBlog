using System.Collections;
using Models;

namespace MyBlog.Models;

public class MyPostDetailViewModel
{
    public Post Post { get; set; }
    public List<Comment> Comments { get; set; }
}