using BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Common;

[Authorize(Roles = "User")]
public class UserControllerBase : Controller
{

}