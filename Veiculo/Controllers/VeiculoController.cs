using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculoAPI.Model;

namespace VeiculoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();

        [HttpPost]
        public void AdicionaVeiculo([FromBody]  Veiculo veiculo)
        {
            veiculos.Add(veiculo);
            Console.WriteLine(veiculo.Marca);
        }

        [HttpGet]
        public IEnumerable<Veiculo> RecuperaVeiculo()
        {

            return veiculos;

        }
    }
}
