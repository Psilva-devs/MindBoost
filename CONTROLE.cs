using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MINDBOOST_3
{
    public partial class CONTROLE : Form
    {
        private string stringConexao =
        "server=localhost;" +
        "port=3306;" +
        "database=MINDBOOST;" +
        "uid=root;" +
        "pwd=ifsp;";


    public CONTROLE()
        {
            InitializeComponent();

            BOTAO_EXIBIR.Click += BOTAO_EXIBIR_Click;
        }

        private void CONTROLE_Load_1(object sender, EventArgs e)
        {

        }

        private void BOTAO_EXIBIR_Click(object sender, EventArgs e)
        {
            if (RB_ATENDIMENTOS.Checked)
            {
                CarregarAtendimentos();
            }
            else if (RB_ADMINS.Checked)
            {
                CarregarAdministradores();
            }
            else if (RB_PSICOS.Checked)
            {
                CarregarPsicologos();
            }
            else
            {
                MessageBox.Show("Selecione uma opção.");
            }
        }

        private void CarregarAtendimentos()
        {
            try
            {
                string sql =
                @"SELECT
                COD_HEXA AS 'Código',
                DATA_HORA AS 'Data',
                POSTO_GRADUACAO AS 'Posto'
              FROM ATENDIMENTO
              ORDER BY DATA_HORA DESC";

                CarregarGrid(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarAdministradores()
        {
            string sql =
            @"SELECT
            A.CPF,
            P.NOME,
            A.USUARIO,
            A.FUNCAO,
            A.NIVEL_ACESSO
          FROM ADMINISTRADOR A
          INNER JOIN PESSOA P
          ON A.CPF = P.CPF";

            CarregarGrid(sql);
        }

        private void CarregarPsicologos()
        {
            string sql =
            @"SELECT
            PS.CPF,
            P.NOME,
            PS.CRP,
            PS.LOCAL_ATENDIMENTO
          FROM PSICOLOGO PS
          INNER JOIN PESSOA P
          ON PS.CPF = P.CPF";

            CarregarGrid(sql);
        }

        private void CarregarGrid(string sql)
        {
            try
            {
                using (MySqlConnection conn =
                    new MySqlConnection(stringConexao))
                {
                    conn.Open();

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(sql, conn);

                    DataTable dt =
                        new DataTable();

                    adapter.Fill(dt);

                    DATAGRID_ADMINISTRADOR_RELATORIOS.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DATAGRID_ADMINISTRADOR_RELATÓRIOS_CellContentClick_1(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void BOTAO_MENU_Click(object sender, EventArgs e)
        {
            MENU Tela = new MENU();
            Tela.Show();
            this.Hide();
        }
    }


}
