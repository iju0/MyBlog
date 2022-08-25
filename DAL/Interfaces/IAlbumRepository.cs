using Models;

namespace DAL.Interfaces;

public interface IAlbumRepository
{
    List<Album>? GetAlbums();
}