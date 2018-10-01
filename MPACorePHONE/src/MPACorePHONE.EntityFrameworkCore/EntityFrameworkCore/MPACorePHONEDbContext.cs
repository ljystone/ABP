using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MPACorePHONE.Authorization.Roles;
using MPACorePHONE.Authorization.Users;
using MPACorePHONE.MultiTenancy;

namespace MPACorePHONE.EntityFrameworkCore
{
    public class MPACorePHONEDbContext : AbpZeroDbContext<Tenant, Role, User, MPACorePHONEDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MPACorePHONEDbContext(DbContextOptions<MPACorePHONEDbContext> options)
            : base(options)
        {
        }
    }
}
