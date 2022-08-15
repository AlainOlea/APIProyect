using Microsoft.AspNetCore.Mvc;
using APIProyect.Models;
using APIProyect.Repository;

namespace APIProyect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController
    {
        [HttpGet(Name = "GetVentas")] //Esto es un endpoint
        public List<Venta> GetVentas()
        {
            return VentaHandler.GetVentas();
        }
    }
}
