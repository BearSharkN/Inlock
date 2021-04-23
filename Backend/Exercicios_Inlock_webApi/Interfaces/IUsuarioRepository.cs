using Exercicios_Inlock_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Metodo para fazer login
        /// </summary>
        /// <param name="email">Propriedade de email passada no corpo da requisição</param>
        /// <param name="senha">Propriedade de senha passada no corpo da requisição</param>
        /// <returns>Um usuario logado</returns>
        usuarioDomain Login(string email, string senha);
    }
}
