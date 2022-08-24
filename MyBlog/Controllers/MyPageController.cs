using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Common;

namespace MyBlog.Controllers;

public class MyPageController : UserControllerBase
{
    private readonly IPostService _postService;
    private readonly IAlbumService _albumService;
    
    public MyPageController(IPostService postService, IAlbumService albumService)
    {
        _postService = postService;
        _albumService = albumService;
    }
    
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MyPost()
    {
        return View(_postService.GetPosts());
    }

    public IActionResult MyAlbum()
    {
        return View(_albumService.GetAlbums());
    }
}