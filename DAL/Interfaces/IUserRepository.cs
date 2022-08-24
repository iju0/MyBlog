using Models;

namespace DAL.Interfaces;

public interface IUserRepository
{
    List<User> GetUsers();
}