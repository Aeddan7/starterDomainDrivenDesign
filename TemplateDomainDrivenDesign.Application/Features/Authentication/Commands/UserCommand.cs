using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDomainDrivenDesign.Identity.Entities;

namespace TemplateDomainDrivenDesign.Application.Features.Authentication.Commands
{
    public class UserCommand
    {
        [HttpPost]
        public ActionResult<User> CreateUserInDb(User user)
        {
            return user;
        }
    }
}
