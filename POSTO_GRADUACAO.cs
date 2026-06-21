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
    public partial class POSTO_GRADUACAO : Form
    {
        public POSTO_GRADUACAO()
        {
            InitializeComponent();
        }

        private void POSTO_GRADUACAO_Load(object sender, EventArgs e)
        {

        }

       

        private void BOTAO_ENCERRAR_POSTO_GRADUACAO_Click(object sender, EventArgs e)
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

        private void BOTAO_PROSSEGUIR_POSTO_GRADUACAO_Click_1(object sender, EventArgs e)
        {
            if (RB_RECRUTA.Checked)
            {
                DadosAtendimento.Posto = "Recruta";
            }
            else if (RB_SOLDADO.Checked)
            {
                DadosAtendimento.Posto = "Soldado";
            }
            else if (RB_TERCEIRO_SARGENTO.Checked)
            {
                DadosAtendimento.Posto = "3º Sargento";
            }
            else if (RB_SEGUNDO_SARGENTO.Checked)
            {
                DadosAtendimento.Posto = "2º Sargento";
            }
            else if (RB_PRIMEIRO_SARGENTO.Checked)
            {
                DadosAtendimento.Posto = "1º Sargento";
            }
            else if (RB_SUBTENENTE.Checked)
            {
                DadosAtendimento.Posto = "Subtenente";
            }
            else if (RB_SEGUNDO_TENENTE.Checked)
            {
                DadosAtendimento.Posto = "Segundo Tenente";
            }
            else if (RB_PRIMEIRO_TENENTE.Checked)
            {
                DadosAtendimento.Posto = "Primeiro Tenente";
            }
            else if (RB_CAPITAO.Checked)
            {
                DadosAtendimento.Posto = "Capitao";
            }
            else if (RB_MAJOR.Checked)
            {
                DadosAtendimento.Posto = "Major";
            }
            else if (RB_SERVIDOR_CIVIL.Checked)
            {
                DadosAtendimento.Posto = "Servidor Civil";
            }
            else if (RB_OUTRO.Checked)
            {
                DadosAtendimento.Posto = "Outros";
            }

            PERGUNTA_1 tela = new PERGUNTA_1();
            tela.Show();
            this.Dispose();
        }

        private void RB_RECRUTA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_SOLDADO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_TERCEIRO_SARGENTO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_SEGUNDO_SARGENTO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_PRIMEIRO_SARGENTO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_SUBTENENTE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_SEGUNDO_TENENTE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_PRIMEIRO_TENENTE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_CAPITAO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_MAJOR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_SERVIDOR_CIVIL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_OUTRO_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
