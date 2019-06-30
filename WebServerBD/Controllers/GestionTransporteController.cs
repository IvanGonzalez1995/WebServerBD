using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebServerBD.models;
using WebServerBD.Models;

namespace WebServerBD.Controllers
{
    [Route("api/[controller]")]
    public class GestionTransporteController: Controller
    {
        public WebServerDataBContext dbContext;
        public GestionTransporteController()
        {
            /* CONEXION AL SERVIDOR REMOTO */
            string connectionString =
            "server=mysql5013.site4now.net;port=3306;database=db_a4a8a1_websrbd;userid=a4a8a1_websrbd;pwd=navI.1995;sslmode=none";
            dbContext = WebServerDataBContextFactory.Create(connectionString);
           
           /*  CONEXION AL SERVIDOR LOCAL */
           /* 
            string connectionString =
            "server=localhost;port=3306;database=webserverbd;userid=DataAccess;pwd=Da.2019.IEGP;sslmode=none";
            dbContext = WebServerDataBContextFactory.Create(connectionString);
            */
        }

        //Get all gestiones
        [HttpGet]
        public GestionTransporte[]Get()
        {
            return dbContext.GestionTransporte.ToArray();
        }

        // Get gestion by ID
        [HttpGet("{id}")]
        public GestionTransporte Get(int id)
        {
            var target = dbContext.GestionTransporte.SingleOrDefault(f=>f.Id_Gestion==id);
            return target;
        }

        // DELETE gestion by id
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            var gestion = dbContext.GestionTransporte.SingleOrDefault(a => a.Id_Gestion == id);
            if (gestion != null) 
            {
                dbContext.GestionTransporte.Remove(gestion);
                dbContext.SaveChanges();
            }
        }

        // POST gestion
        [HttpPost]
        public void Post([FromBody]GestionTransporte gestion)
        {
            dbContext.GestionTransporte.Add(gestion);
            dbContext.SaveChanges();
        }

        // PUT actualizar gestion
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]GestionTransporte gestion) 
        {
            var target = dbContext.GestionTransporte.SingleOrDefault(a => a.Id_Gestion == id);
            if (target != null && ModelState.IsValid) 
            {
                dbContext.Entry(target).CurrentValues.SetValues(gestion);
                dbContext.SaveChanges();
            }
            
        }




    }

}