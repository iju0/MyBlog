using BLL.Interfaces;
using DAL.Interfaces;
using Models;

namespace BLL;

public class LoginService : ILoginService
{
    private readonly IUserRepository _userRepository;
    public LoginService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public bool Validate()
    {
        return false;
    }

    public User login(string id, string password)
    {
        var users = _userRepository.GetUsers();
        var result =
            from user in users
            where user.Email == id
            select user;

        return result.FirstOrDefault();
    }
}