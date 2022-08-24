using Models;

namespace BLL.Interfaces;

public interface ILoginService
{
    bool Validate();
    User login(string id, string password);
}