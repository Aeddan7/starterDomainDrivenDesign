using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDomainDrivenDesign.Application.Contracts;
using TemplateDomainDrivenDesign.Identity.Entities;

namespace TemplateDomainDrivenDesign.Application.Services
{
    public class UserService : IUserService
    {
        public bool CheckIfUserExistInDb(Domain.Entities.User user)
        {
            throw new NotImplementedException();
        }

        public void CreateUserInDb(Domain.Entities.User user)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.User> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Holiday> GetAllHolidaysByUser(Domain.Entities.User user)
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
