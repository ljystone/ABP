using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MPACorePHONE.Configuration;
using MPACorePHONE.Web;

namespace MPACorePHONE.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MPACorePHONEDbContextFactory : IDesignTimeDbContextFactory<MPACorePHONEDbContext>
    {
        public MPACorePHONEDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MPACorePHONEDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MPACorePHONEDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MPACorePHONEConsts.ConnectionStringName));

            return new MPACorePHONEDbContext(builder.Options);
        }
    }
}
