using Models;

namespace BLL.Interfaces;

public interface ILoginService
{
    User? login(string id, string password);
}