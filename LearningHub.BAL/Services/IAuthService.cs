using LearningHub.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.BAL.Services
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(UserRegisterModel model);
        Task<string> LoginAsync(UserLoginModel model);
    }
}
