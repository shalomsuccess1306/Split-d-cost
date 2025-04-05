using CommonOps;
using SplitCost.Models;

namespace SplitCost.Services
{
    public interface IAuthServices
    {
      Task<StandardResponse<string>> loginUser(LoginModel loginModel);
        Task<StandardResponse<UserDTO>> RegisterUser(UserDTO user);

    }
}
