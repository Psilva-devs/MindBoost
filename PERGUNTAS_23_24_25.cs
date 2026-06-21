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
    public partial class PERGUNTAS_23_24_25 : Form
    {
        public PERGUNTAS_23_24_25()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_23_24_25_Click(object sender, EventArgs e)
        {
            if (!(RB_23_1.Checked || RB_23_2.Checked || RB_23_3.Checked ||
      RB_23_4.Checked || RB_23_5.Checked || RB_23_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 23.");
                return;
            }

            if (!(RB_24_1.Checked || RB_24_2.Checked || RB_24_3.Checked ||
                  RB_24_4.Checked || RB_24_5.Checked || RB_24_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 24.");
                return;
            }

            if (!(RB_25_1.Checked || RB_25_2.Checked || RB_25_3.Checked ||
                  RB_25_4.Checked || RB_25_5.Checked || RB_25_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 25.");
                return;
            }
            if (RB_23_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_23_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_23_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_23_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_23_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_23_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_24_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_24_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_24_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_24_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_24_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_24_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_25_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_25_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_25_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_25_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_25_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_25_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }

            PERGUNTA_DISSERTATIVA_01 tela = new PERGUNTA_DISSERTATIVA_01();
            tela.Show();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RB_23_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_23_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_23_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_23_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_23_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_23_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RB_24_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_24_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_24_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_24_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_24_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_24_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RB_25_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_25_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_25_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_25_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_25_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_25_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BOTAO_ENCERAR_PERGUNTA_23_24_25_Click(object sender, EventArgs e)
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
