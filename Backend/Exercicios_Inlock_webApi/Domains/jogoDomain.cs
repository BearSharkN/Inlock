using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Domains
{
    /// <summary>
    /// Propriedades da tabela jogo
    /// </summary>
    public class jogoDomain
    {
        public int idJogo { get; set; }

        [Required(ErrorMessage = "nomeJogo não preenchido")]
        public string nomeJogo { get; set; }

        [Required(ErrorMessage = "descricaoJogo não preenchido")]
        public string descricaoJogo { get; set; }

        [Required(ErrorMessage = "dataLancamento não preenchido")]
        public DateTime dataLancamento { get; set; }

        [Required(ErrorMessage = "valor não preenchido")]
        public double valor { get; set; }

        [Required(ErrorMessage = "idEstudio não preenchido")]
        public int idEstudio { get; set; }


    }
}
