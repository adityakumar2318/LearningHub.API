using LearningHub.BAL.Models;
using LearningHub.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.BAL.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<string> AssignRoleAsync(AssignRoleModel model)
        {
            if (!await _roleRepository.UserExists(model.UserId))
                return "User not found";

            if (!await _roleRepository.RoleExists(model.RoleId))
                return "Role not found";

            var success = await _roleRepository.AssignRoleAsync(model.UserId, model.RoleId);
            return success ? "Role assigned successfully" : "Role already assigned";
        }
    }
}
