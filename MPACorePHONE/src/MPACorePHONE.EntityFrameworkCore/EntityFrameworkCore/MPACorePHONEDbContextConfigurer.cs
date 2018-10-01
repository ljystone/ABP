using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MPACorePHONE.EntityFrameworkCore
{
    public static class MPACorePHONEDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MPACorePHONEDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MPACorePHONEDbContext> builder, DbConnection connection)
        {
           // builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
