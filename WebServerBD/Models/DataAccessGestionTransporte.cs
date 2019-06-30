using Microsoft.EntityFrameworkCore;
using WebServerBD.models;

namespace WebServerBD.models
{
    public class WebServerDataBContext: DbContext
    {
        
        public WebServerDataBContext(DbContextOptions<WebServerDataBContext>options)
        :base(options)
        {
        }

        public DbSet<GestionTransporte>GestionTransporte{get; set;}

    }

    public class WebServerDataBContextFactory
    {
        public static WebServerDataBContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebServerDataBContext>();
            optionsBuilder.UseMySQL(connectionString);
            var WebServerDataBContext = new WebServerDataBContext(optionsBuilder.Options);
            return WebServerDataBContext;
        }
    }
}