using LearningHub.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.DAL.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly LearningHubDbContext _context;

        public RoleRepository(LearningHubDbContext context)
        {
            _context = context;
        }

        public async Task<bool> UserExists(int userId)
        {
            return await _context.Users.AnyAsync(u => u.UserId == userId);
        }

        public async Task<bool> RoleExists(int roleId)
        {
            return await _context.Roles.AnyAsync(r => r.RoleId == roleId);
        }

        public async Task<bool> AssignRoleAsync(int userId, int roleId)
        {
            var alreadyAssigned = await _context.UserRoles.AnyAsync(ur => ur.UserId == userId && ur.RoleId == roleId);
            if (alreadyAssigned)
                return false;

            _context.UserRoles.Add(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
