using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.DAL.Repositories
{
    public interface IRoleRepository
    {
        Task<bool> UserExists(int userId);
        Task<bool> RoleExists(int roleId);
        Task<bool> AssignRoleAsync(int userId, int roleId);
    }
}
