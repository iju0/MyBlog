using DAL.Apis;
using DAL.Interfaces;
using Models;

namespace DAL;

public class UserRepository : IUserRepository
{
    public List<User> GetUsers()
    {
        var api = new JsonPlaceHolderAPI();
        return api.GetUsers();
    }
}