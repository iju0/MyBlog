using DAL.Apis;
using DAL.Interfaces;
using Models;

namespace DAL;

public class PhotoRepository : IPhotoRepository
{
    private readonly JsonPlaceHolderAPI _api;
    
    public PhotoRepository()
    {
        _api = new JsonPlaceHolderAPI();
    }
    
    public List<Photo> GetPhotosByAlbumId(int id)
    {
        var photos =
            from albumPhotos in _api.GetPhotos()
            where albumPhotos.AlbumId == id
            select albumPhotos;

        return photos.ToList();
    }
}