using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDomainDrivenDesign.Application.Contracts;
using TemplateDomainDrivenDesign.Identity.Entities;

namespace TemplateDomainDrivenDesign.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>, IApplicationDbContext
    {
        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<Domain.Entities.User> Users { get; set; }
        public DbSet<Domain.Entities.Team> Teams { get; set; }
        public DbSet<Domain.Entities.Document> Documents { get; set; }
        public DbSet<Domain.Entities.Holiday> Holidays { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
