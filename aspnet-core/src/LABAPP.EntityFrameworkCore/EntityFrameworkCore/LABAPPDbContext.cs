using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LABAPP.Authorization.Roles;
using LABAPP.Authorization.Users;
using LABAPP.MultiTenancy;
using LABAPP.JobOffers;

namespace LABAPP.EntityFrameworkCore
{
    public class LABAPPDbContext : AbpZeroDbContext<Tenant, Role, User, LABAPPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LABAPPDbContext(DbContextOptions<LABAPPDbContext> options)
            : base(options)
        {
        }

        public DbSet<JobOffer> JobOffers { get; set; }

    }
}
