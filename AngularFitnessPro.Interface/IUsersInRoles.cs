using System.Collections.Generic;
using AngularFitnessPro.Models;
using AngularFitnessPro.ViewModels;

namespace AngularFitnessPro.Interface
{
    public interface IUsersInRoles
    {
        bool AssignRole(UsersInRoles usersInRoles);
        bool CheckRoleExists(UsersInRoles usersInRoles);
        bool RemoveRole(UsersInRoles usersInRoles);
        List<AssignRolesViewModel> GetAssignRoles();
    }
}