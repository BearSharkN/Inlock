using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Domains
{
    public class usuarioDomain
    {
        /// <summary>
        /// Propriedades da tabela Usuario
        /// </summary>
        public int idUsuario { get; set; }

        [Required(ErrorMessage = "email não preenchido")]
        public string email { get; set; }

        [Required(ErrorMessage = "senha não preenchido")]
        public string senha { get; set; }

        public int idTipoUsuario { get; set; }
    }
}
