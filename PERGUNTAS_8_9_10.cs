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
    public partial class PERGUNTAS_8_9_10 : Form
    {
        public PERGUNTAS_8_9_10()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_8_9_10_Click(object sender, EventArgs e)
        {
            if (!(RB_8_1.Checked || RB_8_2.Checked || RB_8_3.Checked ||
      RB_8_4.Checked || RB_8_5.Checked || RB_8_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 8.");
                return;
            }

            if (!(RB_9_1.Checked || RB_9_2.Checked || RB_9_3.Checked ||
                  RB_9_4.Checked || RB_9_5.Checked || RB_9_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 9.");
                return;
            }

            if (!(RB_10_1.Checked || RB_10_2.Checked || RB_10_3.Checked ||
                  RB_10_4.Checked || RB_10_5.Checked || RB_10_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 10.");
                return;
            }

            if (RB_8_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_8_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_8_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_8_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_8_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_8_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_9_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_9_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_9_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_9_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_9_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_9_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_10_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_10_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_10_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_10_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_10_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_10_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }



            PERGUNTAS_11_12_13 tela = new PERGUNTAS_11_12_13();
            tela.Show();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RB_8_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_8_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_8_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_8_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_8_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_8_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RB_9_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_9_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_9_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_9_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_9_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_9_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RB_10_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_10_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_10_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_10_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_10_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_10_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BOTAO_ENCERAR_PERGUNTA_8_9_10_Click(object sender, EventArgs e)
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
