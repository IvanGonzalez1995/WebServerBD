using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebServerBD.models;
using WebServerBD.Models;

namespace WebServerBD.Controllers
{
   [Route("api/[controller]")]
    public class CarrosController: Controller
    {
        public WebServerDataBaseContext dbContext;
        public CarrosController()
        {
            string connectionString =
            "server=localhost;port=3306;database=webserverbd;userid=DataAccess;pwd=Da.2019.IEGP;sslmode=none";
            dbContext = WebServerDataBaseContextFactory.Create(connectionString);
        }

        //Get all carros
        [HttpGet]
        public Carros[]Get()
        {
            return dbContext.Carros.ToArray();
        }

        // Get carro by ID
        [HttpGet("{id}")]
        public Carros Get(int id)
        {
            var target = dbContext.Carros.SingleOrDefault(f=>f.Carro_ID==id);
            return target;
        }

        // DELETE carro by id
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            var carro = dbContext.Carros.SingleOrDefault(a => a.Carro_ID == id);
            if (carro != null) 
            {
                dbContext.Carros.Remove(carro);
                dbContext.SaveChanges();
            }
        }

        // POST carro
        [HttpPost]
        public void Post([FromBody]Carros carro)
        {
            dbContext.Carros.Add(carro);
            dbContext.SaveChanges();
        }

        // PUT actualizar carro
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Carros carro) 
        {
            var target = dbContext.Carros.SingleOrDefault(a => a.Carro_ID == id);
            if (target != null && ModelState.IsValid) 
            {
                dbContext.Entry(target).CurrentValues.SetValues(carro);
                dbContext.SaveChanges();
            }
            
        }

    }

}