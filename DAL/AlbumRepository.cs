using DAL.Apis;
using DAL.Interfaces;
using Models;

namespace DAL;

public class AlbumRepository : IAlbumRepository
{
    public List<Album>? GetAlbums()
    {
        var api = new JsonPlaceHolderAPI();
        return api.GetAlbums();
    }
}