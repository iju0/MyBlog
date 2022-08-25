using BLL.Interfaces;
using DAL.Interfaces;
using Models;

namespace BLL;

public class AlbumService : IAlbumService
{
    private readonly IAlbumRepository _albumRepository;
    public AlbumService(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }
    public List<Album>? GetAlbums()
    {
        return _albumRepository.GetAlbums();
    }
}