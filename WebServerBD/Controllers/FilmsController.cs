using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebServerBD.models;
using WebServerBD.Models;

namespace WebServerBD.Controllers
{
    
    [Route("api/[controller]")]
    public class FilmsController: Controller
    {
        public SakilaDbContext dbContext;
        public FilmsController()
        {
            string connectionString =
            "server=localhost;port=3306;database=sakila;userid=DataAccess;pwd=Da.2019.IEGP;sslmode=none";
            dbContext = SakilaDbContextFactory.Create(connectionString);
        }

        //Get all films
        [HttpGet]
        public Film[]Get()
        {
            return dbContext.Film.ToArray();
        }

        // Get film by ID
        [HttpGet("{id}")]
        public Film Get(int id)
        {
            var target = dbContext.Film.SingleOrDefault(f=>f.Film_ID==id);
            return target;
        }

    }








}