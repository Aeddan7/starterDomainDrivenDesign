using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDomainDrivenDesign.Domain.Entities;

namespace TemplateDomainDrivenDesign.Application.Contracts
{
    public interface IUserService
    {
        bool CheckIfUserExistInDb(User user);
        void CreateUserInDb(User user);
        List<User> GetAll();
        User GetById(int id);
    }
}
