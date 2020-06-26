using System.Collections.Generic;
using AngularFitnessPro.Models;

namespace AngularFitnessPro.Interface
{
    public interface IRole
    {
        void InsertRole(Role role);
        bool CheckRoleExits(string roleName);
        Role GetRolebyId(int roleId);
        bool DeleteRole(int roleId);
        bool UpdateRole(Role role);
        List<Role> GetAllRole();
    }
}