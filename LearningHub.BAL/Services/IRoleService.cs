using LearningHub.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.BAL.Services
{
    public interface IRoleService
    {
        Task<string> AssignRoleAsync(AssignRoleModel model);
    }
}
