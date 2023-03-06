using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDomainDrivenDesign.Application.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<Domain.Entities.Task> Tasks { get; set; }
        DbSet<Domain.Entities.User> Users { get; set; }
        DbSet<Domain.Entities.Team> Teams { get; set; }
        DbSet<Domain.Entities.Document> Documents { get; set; }
        DbSet<Domain.Entities.Holiday> Holidays { get; set; }
    }
}
