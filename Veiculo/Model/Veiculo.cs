using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculoAPI.Model
{
    public class Veiculo
    {
        [Required (ErrorMessage ="Campo  Obrigatorio")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Campo  Obrigatorio")]
        public string Cor { get; set; }
        [Required(ErrorMessage = "Campo  Obrigatorio")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Campo  Obrigatorio")]
        public string Tipo { get; set; }

       
    }
}
