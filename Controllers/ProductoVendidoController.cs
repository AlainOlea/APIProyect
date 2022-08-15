using Microsoft.AspNetCore.Mvc;
using APIProyect.Models;
using APIProyect.Repository;

namespace MiPrimeraAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoVendidoController
    {
        [HttpGet(Name = "GetProductosVendidos")] //Esto es un endpoint
        public List<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoHandler.GetProductosVendidos();
        }
    }
}
