using Exercicios_Inlock_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Interfaces
{
    interface IjogoRepository
    {
        /// <summary>
        /// Metodo para listar jogos existentes
        /// </summary>
        /// <returns> Uma lista de jogos</returns>
        List<jogoDomain> ListarJogo();

        /// <summary>
        /// Metodo para cadastrar Jogos
        /// </summary>
        /// <param name="novoJogo"> Propriedade novoJogo Passado no corpo da requisição </param>
        void CadastrarJogo(jogoDomain novoJogo);

    }
}
