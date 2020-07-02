using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace HelpLocally.Web.Services
{
  public interface IUserService
  {
    int GetUserId();
  }
  public class UserService: IUserService
  {
    private readonly IHttpContextAccessor _httpContextAccessor;
    
    public UserService(IHttpContextAccessor httpContextAccessor)
    {
      _httpContextAccessor = httpContextAccessor;
    }

    public int GetUserId()
    {
      var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
      return int.Parse(userId ?? throw new InvalidOperationException());
    }
  }
}