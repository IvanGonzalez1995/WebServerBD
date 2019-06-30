using Microsoft.EntityFrameworkCore;

namespace WebServerBD.models
{
    public class WebServerDataBaseContext: DbContext
    {
        
        public WebServerDataBaseContext(DbContextOptions<WebServerDataBaseContext>options)
        :base(options)
        {
        }

        public DbSet<Carros>Carros{get; set;}

    }

    public class WebServerDataBaseContextFactory
    {
        public static WebServerDataBaseContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebServerDataBaseContext>();
            optionsBuilder.UseMySQL(connectionString);
            var WebServerDataBaseContext = new WebServerDataBaseContext(optionsBuilder.Options);
            return WebServerDataBaseContext;
        }
    }
}