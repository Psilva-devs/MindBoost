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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void BOTAO_PROSSEGUIR_MENU_Click(object sender, EventArgs e)
        {
            


            if (RB_INICIAR_ATENDIMENTO.Checked)
            {
                GERAR_CODIGO tela = new GERAR_CODIGO();

                tela.Show();

                this.Hide();
            }
            else if (RB_GERAR_RELATORIO.Checked)
            {
                RELATORIO tela = new RELATORIO();
                tela.Show();
                this.Hide();
            }
            else if (RB_FAZER_LOGIN.Checked)
            {
                LOGIN tela = new LOGIN();
                tela.Show();
                this.Hide();
            }

        }

        private void BOTAO_ENCERRAR_MENU_Click(object sender, EventArgs e)
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
        private bool TodasPerguntasRespondidas()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is Panel painel)
                {
                    bool respondeu = false;

                    foreach (Control c in painel.Controls)
                    {
                        if (c is RadioButton rb && rb.Checked)
                        {
                            respondeu = true;
                            break;
                        }
                    }

                    if (!respondeu)
                        return false;
                }
            }

            return true;
        }

        private void RB_GERAR_RELATORIO_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void RB_INICIAR_ATENDIMENTO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_FAZER_LOGIN_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
