using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MINDBOOST_3
{
    public class ConexaoBanco
    {
        // String de conexão centralizada para evitar repetição de código
        private static string stringConexao =
            "server=localhost;" +
            "port=3306;" +
            "database=mindboost;" +
            "uid=root;" +
            "pwd=ifsp;";

        public static void TestarConexao()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringConexao))
                {
                    conn.Open();
                    MessageBox.Show("Conexão realizada com sucesso!", "Banco de Dados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de conexão");
            }
        }

        public static void SalvarAtendimento()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringConexao))
                {
                    conn.Open();

                    // 1º PASSO: Salva o Atendimento Geral
                    string sqlAtendimento = @"INSERT INTO ATENDIMENTO 
                                    (COD_HEXA, DATA_HORA, POSTO_GRADUACAO) 
                                    VALUES 
                                    (@codigo, NOW(), @posto)";

                    using (MySqlCommand cmdAtend = new MySqlCommand(sqlAtendimento, conn))
                    {
                        cmdAtend.Parameters.AddWithValue("@codigo", DadosAtendimento.CodigoHexadecimal);
                        cmdAtend.Parameters.AddWithValue("@posto", DadosAtendimento.Posto);
                        cmdAtend.ExecuteNonQuery();
                    }

                    // 2º PASSO: Salva as 27 respostas usando a coluna CORRETA (RESP)
                    string sqlResposta = @"INSERT INTO RESPOSTA 
                                  (RESP, ID_PGT, COD_HEXA) 
                                  VALUES 
                                  (@resp, @id_pgt, @cod_hexa)";

                    for (int i = 0; i < DadosAtendimento.Respostas.Count; i++)
                    {
                        using (MySqlCommand cmdResp = new MySqlCommand(sqlResposta, conn))
                        {
                            int idPergunta = i + 1;

                            cmdResp.Parameters.AddWithValue("@resp", DadosAtendimento.Respostas[i]);
                            cmdResp.Parameters.AddWithValue("@id_pgt", idPergunta);
                            cmdResp.Parameters.AddWithValue("@cod_hexa", DadosAtendimento.CodigoHexadecimal);

                            cmdResp.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show(
                        "Atendimento e todas as 27 respostas salvos com sucesso!",
                        "Sucesso no Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar atendimento");
            }
        }

        /*
        public static void PopularPerguntas()
        {
            try
            {
                using (MySqlConnection conn =
                    new MySqlConnection(stringConexao))
                {
                    conn.Open();

                    List<string> comandos = new List<string>()
            {
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (1, 'Como você avalia seu bem-estar emocional atualmente?', 'FECHADA', 1);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (2, 'Você sente que consegue lidar bem com as emoções do dia a dia?', 'FECHADA', 2);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (3, 'Quando descansa, sente que consegue relaxar de verdade?', 'FECHADA', 2);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (4, 'Você tem conseguido aproveitar pequenos momentos agradáveis do seu dia?', 'FECHADA', 2);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (5, 'Você tem se sentido bem emocionalmente no seu dia a dia?', 'FECHADA', 3);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (6, 'A rotina do quartel tem impactado seu nível de cansaço?', 'FECHADA', 3);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (7, 'Você sente que possui pessoas com quem pode conversar quando precisa?', 'FECHADA', 3);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (8, 'Você sente preocupação excessiva com frequência?', 'FECHADA', 4);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (9, 'Você sente motivação para realizar suas atividades diárias?', 'FECHADA', 4);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (10, 'O ambiente militar tem afetado sua saúde emocional de alguma forma?', 'FECHADA', 4);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (11, 'Como anda seu equilíbrio entre responsabilidades e momentos de cuidado pessoal?', 'FECHADA', 5);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (12, 'Você se sente acolhido(a) pelas pessoas ao seu redor?', 'FECHADA', 5);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (13, 'Seus pensamentos têm dificultado sua concentração?', 'FECHADA', 5);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (14, 'Você sente que conseguiu se adaptar bem à rotina atual?', 'FECHADA', 6);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (15, 'Você percebe apoio dentro do ambiente militar?', 'FECHADA', 6);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (16, 'Você sente pressão constante para manter um bom desempenho?', 'FECHADA', 6);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (17, 'Você sente que consegue pedir ajuda quando necessário?', 'FECHADA', 7);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (18, 'Você sente dificuldade para descansar mentalmente?', 'FECHADA', 7);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (19, 'Você sente que sua qualidade de vida tem sido positiva recentemente?', 'FECHADA', 7);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (20, 'Você costuma sentir tensão antes das atividades do dia?', 'FECHADA', 8);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (21, 'Você acredita que sua rotina atual permite descanso suficiente?', 'FECHADA', 8);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (22, 'Nos últimos tempos, você tem se sentido isolado(a)?', 'FECHADA', 8);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (23, 'Você sente que a autocobrança tem afetado seu bem-estar?', 'FECHADA', 9);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (24, 'Você sente que tem espaço para cuidar de si emocionalmente?', 'FECHADA', 9);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (25, 'Você sente que consegue organizar bem suas tarefas e compromissos?', 'FECHADA', 9);",


                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (26, 'Na sua opinião o ambiente militar poderia apoiar no bem estar dos militares?', 'ABERTA', 10);",
                        "INSERT IGNORE INTO PERGUNTA VALUES (ID_PGT, TEXTO, TIPO, TELA) VALUES (27, 'Como você percebe apoio dentro do ambiente militar?', 'ABERTA', 11);"

                
            };

                    foreach (string sql in comandos)
                    {
                        MySqlCommand cmd =
                            new MySqlCommand(sql, conn);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */


    }
}