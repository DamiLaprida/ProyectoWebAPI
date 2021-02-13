using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIPerfilPersonalController : ControllerBase
    {
        [HttpGet]
        public string Get(int id)
        {
            //Codigo para leer de la base de datos
            return id switch
            {
                1 => "Ivan",
                2 => "Curso",
                _ => throw new NotSupportedException("El id no es válido")
            };
        }

        [HttpPost]
        public string Post(PerfilPersonalDTO perfilPersonal) 
        {
            //Guardar perfil en la base de datos
            return perfilPersonal.Nombre;
        }
    }

    public class PerfilPersonalDTO
    {
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       
    }
}
