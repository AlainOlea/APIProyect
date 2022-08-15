using Microsoft.AspNetCore.Mvc;
using APIProyect.Models;
using APIProyect.Repository;//Debido a que UsuarioHandler está en la carpeta Repository
//Hay que hacer un Handler por cada tabla

namespace APIProyect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name ="GetUsuarios")] //Esto es un endpoint
        public List<Usuario> GetUsuarios()
        {
            return UsuarioHandler.GetUsuarios();
        }

        [HttpGet("{nombreUsuario}/{contraseña}")]
        public string Login(string nombreUsuario,string contraseña)
        { 
            Usuario usuario= UsuarioHandler.GetUsuarioByContraseña(nombreUsuario, contraseña);
            
            if (usuario.Nombre == null)
            {
                return "User Not Found";
            }
            else
            {
                return "User Found";
            }
        }
    }
}
