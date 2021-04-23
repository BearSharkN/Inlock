using Exercicios_Inlock_webApi.Domains;
using Exercicios_Inlock_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Inlock_webApi.Repositories
{
    public class jogoRepository : IjogoRepository
    {
       private string ConexaoString = "Data Source=DESKTOP-6D5LSLF; Initial Catalog=inlock_games_tarde; User Id=sa; pwd=senai@132;";

        /// <summary>
        /// Cadastra novos jogos
        /// </summary>
        /// <param name="novoJogo">propriedades passada no corpo do requisição</param>
        public void CadastrarJogo(jogoDomain novoJogo)
        {
            using (SqlConnection con = new SqlConnection(ConexaoString))
            {
                string QueryCadastrarJogo = "INSERT INTO jogos(nomeJogo, descricaoJogo, dataLancamento, valor, idEstudio) values (@nomeJogo, @descricaoJogo, @dataLancamento, @valor, @idEstudio)";

                using (SqlCommand cmd = new SqlCommand(QueryCadastrarJogo, con))
                {
                    cmd.Parameters.AddWithValue("@nomeJogo", novoJogo.nomeJogo);
                    cmd.Parameters.AddWithValue("@descricaoJogo", novoJogo.descricaoJogo);
                    cmd.Parameters.AddWithValue("@dataLancamento", novoJogo.dataLancamento);
                    cmd.Parameters.AddWithValue("@valor", novoJogo.valor);
                    cmd.Parameters.AddWithValue("@idEstudio", novoJogo.idEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();

                }
            }
        }

        /// <summary>
        /// Lista os jogos
        /// </summary>
        /// <returns> Retorna uma lista de jogos </returns>
        public List<jogoDomain> ListarJogo()
        {
            List<jogoDomain> TodosJogos = new List<jogoDomain>();

            using (SqlConnection con = new SqlConnection(ConexaoString))
            {
                string QuerySelecionarJogos = "select  idJogo, nomeJogo, descricaoJogo, dataLancamento, valor, idEstudio from jogos";

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(QuerySelecionarJogos, con))
                {
                    con.Open();

                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        jogoDomain jogoAdicionar = new jogoDomain()
                        {
                            idJogo = Convert.ToInt32(rdr["idJogo"]),
                            nomeJogo = rdr["nomeJogo"].ToString(),
                            descricaoJogo = rdr["descricaoJogo"].ToString(),
                            dataLancamento = Convert.ToDateTime(rdr["dataLancamento"]),
                            valor = Convert.ToDouble(rdr["valor"]),
                            idEstudio = Convert.ToInt32(rdr["idEstudio"]),

                        };

                        TodosJogos.Add(jogoAdicionar);



                    }

                    return TodosJogos;


                }

            }
        }
    }
}
