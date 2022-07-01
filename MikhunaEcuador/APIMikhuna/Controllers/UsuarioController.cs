using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMikhuna.Models;
namespace APIMikhuna.Controllers
{   

    //Permite realizar validaciones
    [ApiController]

    //Cuando se llame a esta ruta, se ejecutarán los métodos de la API
    [Route("api/usuarios")]
    public class UsuarioController: ControllerBase
    {
        //Método de retorno de información
        [HttpGet]
        public ActionResult<List<Usuario>> Get() {
            return new List<Usuario>() { 
                //Usuarios quemados
                new Usuario(){ UsuarioID = 1, Clave = "udla", Correo = "alan.cueva@yahoo.es", NickName = "Josueth", Nivel = 0 }

            };
        }

    }
}
