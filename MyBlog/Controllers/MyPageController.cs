using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Common;
using MyBlog.Models;

namespace MyBlog.Controllers;

public class MyPageController : UserControllerBase
{
    private readonly IPostService _postService;
    private readonly IAlbumService _albumService;
    private readonly ICommentService _commentService;
    private readonly IPhotoService _photoService;
    
    public MyPageController(IPostService postService, IAlbumService albumService, ICommentService commentService, IPhotoService photoService)
    {
        _postService = postService;
        _albumService = albumService;
        _commentService = commentService;
        _photoService = photoService;
    }
    
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MyPost()
    {
        return View(_postService.GetPosts());
    }

    [HttpGet("/MyPage/MyPost/{id}")]
    public IActionResult MyPostDetail(int id)
    {
        var viewModel = new MyPostDetailViewModel();

        var post = _postService.GetPosts().Find(post => post.Id == id);

        if (post != null)
        {
            var comments = _commentService.GetCommentsByPostId(id);
            viewModel.Post = post;
            viewModel.Comments = comments;
        }

        return View(viewModel);
    }

    public IActionResult MyAlbum()
    {
        return View(_albumService.GetAlbums());
    }

    [HttpGet("/MyPage/MyAlbum/{id}")]
    public IActionResult MyPhotos(int id)
    {
        var viewModel = new MyAlbumDetailViewModel();

        var album = _albumService.GetAlbums().Find(album => album.Id == id);

        if (album != null)
        {
            viewModel.Album = album;
            viewModel.Photos = _photoService.GetPhotosByAlbumId(id);
        }
        return View(viewModel);
    }
}