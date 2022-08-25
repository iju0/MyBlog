using Models;

namespace BLL.Interfaces;

public interface IPhotoService
{
    List<Photo> GetPhotosByAlbumId(int id);
}