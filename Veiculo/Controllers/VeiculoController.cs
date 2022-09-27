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
        private static int id = 1;

        [HttpPost]
        public void AdicionaVeiculo([FromBody]  Veiculo veiculo)
        {
            veiculo.Id = id++;
            veiculos.Add(veiculo);
            Console.WriteLine(veiculo.Marca);
        }

        [HttpGet]
        public IEnumerable<Veiculo> RecuperaVeiculo()
        {

            return veiculos;

        }
        [HttpGet("{id}")]
        public Veiculo RecuperaVeiculoId(int id)
        {
           
                return veiculos.FirstOrDefault(veiculo => veiculo.Id==id);
      
        }
    }
}
