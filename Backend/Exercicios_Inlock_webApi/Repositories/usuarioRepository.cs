using Exercicios_Inlock_webApi.Domains;
using Exercicios_Inlock_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Repositories
{
    public class usuarioRepository : IUsuarioRepository
    {
        private string ConexaoString = "Data Source=DESKTOP-6D5LSLF; Initial Catalog=inlock_games_tarde; User Id=sa; pwd=senai@132;";

        /// <summary>
        /// Metodo para fazer login
        /// </summary>
        /// <param name="email">Propriedade de email passada no corpo da requisição</param>
        /// <param name="senha">Propriedade de senha passada no corpo da requisição</param>
        /// <returns>Um usuario logado</returns>
        public usuarioDomain Login(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(ConexaoString))
            {
                string queryLogin = "select idUsuario,email, senha, idTipoUsuario from usuarios where email = @email and senha = @senha";


                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    con.Open();


                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        usuarioDomain LoginUsuario = new usuarioDomain
                        {
                            idUsuario = Convert.ToInt32(rdr["idUsuario"]),
                            idTipoUsuario = Convert.ToInt32(rdr["idTipoUsuario"]),
                            senha = rdr["senha"].ToString(),
                            email = rdr["email"].ToString()


                        };

                        return LoginUsuario;
                    }

                    return null;





                }
            }
        }
    }
}
