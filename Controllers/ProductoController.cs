using Microsoft.AspNetCore.Mvc;
using APIProyect.Models;
using APIProyect.Repository;

namespace APIProyect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController
    {
        [HttpGet(Name = "GetProductos")] //Esto es un endpoint
        public List<Producto> GetProductos()
        {
            return ProductoHandler.GetProductos();
        }
    }
}
