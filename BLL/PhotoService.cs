using BLL.Interfaces;
using DAL.Interfaces;
using Models;

namespace BLL;

public class PhotoService : IPhotoService
{
    private readonly IPhotoRepository _photoRepository;
    public PhotoService(IPhotoRepository photoRepository)
    {
        _photoRepository = photoRepository;
    }
    
    public List<Photo> GetPhotosByAlbumId(int id)
    {
        return _photoRepository.GetPhotosByAlbumId(id);
    }
}