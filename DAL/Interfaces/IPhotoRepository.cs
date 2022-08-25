using Models;

namespace DAL.Interfaces;

public interface IPhotoRepository
{
    public List<Photo> GetPhotosByAlbumId(int id);
}