using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINDBOOST_3
{
    public partial class RELATORIO : Form
    {
        public RELATORIO()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_RELATORIO_Click(object sender, EventArgs e)
        {
            string codigo = TEXT_INSERIR_ESPECTRO.Text.Trim();

            if (codigo == "")
            {
                MessageBox.Show("Digite um código.");
                return;
            }

            Dictionary<int, string> respostas =
                new Dictionary<int, string>();

            string conexao =
                "server=localhost;" +
                "port=3306;" +
                "database=mindboost;" +
                "uid=root;" +
                "pwd=ifsp;";

            try
            {
                using (MySqlConnection conn =
                    new MySqlConnection(conexao))
                {
                    conn.Open();

                    string sql =
                        @"SELECT ID_PGT, RESP
                  FROM RESPOSTA
                  WHERE COD_HEXA = @codigo";

                    using (MySqlCommand cmd =
                        new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        using (MySqlDataReader dr =
                            cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int pergunta =
                                    Convert.ToInt32(dr["ID_PGT"]);

                                string resposta =
                                    dr["RESP"].ToString();

                                respostas[pergunta] = resposta;
                            }
                        }
                    }
                }

                if (respostas.Count == 0)
                {
                    MessageBox.Show("Código não encontrado.");
                    return;
                }

                int bemEstar = 0;
                int rotina = 0;
                int apoio = 0;
                int pensamentos = 0;
                int motivacao = 0;

                foreach (var item in respostas)
                {
                    int pergunta = item.Key;
                    string resposta = item.Value;

                    bool invertida =
                        pergunta == 6 ||
                        pergunta == 8 ||
                        pergunta == 10 ||
                        pergunta == 13 ||
                        pergunta == 16 ||
                        pergunta == 18 ||
                        pergunta == 20 ||
                        pergunta == 22 ||
                        pergunta == 23;

                    int valor =
                        ConverterResposta(resposta, invertida);

                    if (pergunta == 1 ||
                        pergunta == 2 ||
                        pergunta == 3 ||
                        pergunta == 5 ||
                        pergunta == 24)
                    {
                        bemEstar += valor;
                    }

                    else if (pergunta == 6 ||
                             pergunta == 10 ||
                             pergunta == 11 ||
                             pergunta == 16 ||
                             pergunta == 21 ||
                             pergunta == 25)
                    {
                        rotina += valor;
                    }

                    else if (pergunta == 7 ||
                             pergunta == 12 ||
                             pergunta == 15 ||
                             pergunta == 17 ||
                             pergunta == 22)
                    {
                        apoio += valor;
                    }

                    else if (pergunta == 8 ||
                             pergunta == 13 ||
                             pergunta == 18 ||
                             pergunta == 20 ||
                             pergunta == 23)
                    {
                        pensamentos += valor;
                    }

                    else if (pergunta == 4 ||
                             pergunta == 9 ||
                             pergunta == 14 ||
                             pergunta == 19)
                    {
                        motivacao += valor;
                    }
                }

                DataTable dt = new DataTable();

                dt.Columns.Add("Espectro");
                dt.Columns.Add("Resultado");

                dt.Rows.Add("Bem-estar emocional",
                    Interpretar(bemEstar));

                dt.Rows.Add("Impacto da rotina",
                    Interpretar(rotina));

                dt.Rows.Add("Apoio social",
                    Interpretar(apoio));

                dt.Rows.Add("Pensamentos e preocupações",
                    Interpretar(pensamentos));

                dt.Rows.Add("Motivação e adaptação",
                    Interpretar(motivacao));

                DATAGRID_RELATORIO.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int ConverterResposta(string resposta, bool invertida)
        {
            int valor = 0;

            switch (resposta)
            {
                case "Nunca":
                    valor = -5;
                    break;

                case "Raramente":
                    valor = -3;
                    break;

                case "As vezes":
                    valor = 1;
                    break;

                case "Frequentemente":
                    valor = 3;
                    break;

                case "Quase sempre":
                    valor = 5;
                    break;

                default:
                    valor = 0;
                    break;
            }

            if (invertida)
                valor *= -1;

            return valor;
        }
        private string Interpretar(int valor)
        {
            if (valor >= 10)
                return "Positivo";

            if (valor >= 0)
                return "Em observação";

            return "Merece atenção";
        }

        private void BOTAO_ENCERRAR_RELATORIO_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
          MessageBox.Show(
          "Deseja encerrar o atendimento atual?",
          "Encerrar Atendimento",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
          );

            if (resultado == DialogResult.Yes)
            {

                DadosAtendimento.LimparDados();


                Form1 tela = new Form1();

                tela.Show();

                this.Close();
            }
        }
    }
}
