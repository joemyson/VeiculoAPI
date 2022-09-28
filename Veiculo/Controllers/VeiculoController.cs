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
        public IActionResult AdicionaVeiculo([FromBody]  Veiculo veiculo)
        {
            veiculo.Id = id++;
            veiculos.Add(veiculo);
            return CreatedAtAction(nameof(RecuperaVeiculoId), new { id = veiculo.Id }, veiculo);
        }

        [HttpGet]
        public IActionResult RecuperaVeiculo()
        {

            return Ok(veiculos);

        }
        [HttpGet("{id}")]
        public IActionResult RecuperaVeiculoId(int id)
        {
           
                Veiculo veiculo= veiculos.FirstOrDefault(veiculo => veiculo.Id==id);
            if(veiculo != null)
            {
                return Ok(veiculo);
            }

            return NotFound();
      
        }
    }
}
