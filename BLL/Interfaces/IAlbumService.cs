using Models;

namespace BLL.Interfaces;

public interface IAlbumService
{
    List<Album>? GetAlbums();
}