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
    public partial class PERGUNTAS_14_15_16 : Form
    {
        public PERGUNTAS_14_15_16()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_14_15_16_Click(object sender, EventArgs e)
        {
            if (!(RB_14_1.Checked || RB_14_2.Checked || RB_14_3.Checked ||
      RB_14_4.Checked || RB_14_5.Checked || RB_14_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 14.");
                return;
            }

            if (!(RB_15_1.Checked || RB_15_2.Checked || RB_15_3.Checked ||
                  RB_15_4.Checked || RB_15_5.Checked || RB_15_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 15.");
                return;
            }

            if (!(RB_16_1.Checked || RB_16_2.Checked || RB_16_3.Checked ||
                  RB_16_4.Checked || RB_16_5.Checked || RB_16_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 16.");
                return;
            }

            if (RB_14_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_14_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_14_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_14_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_14_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_14_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_15_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_15_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_15_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_15_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_15_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_15_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_16_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_16_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_16_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_16_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_16_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_16_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }


            PERGUNTAS_17_18_19 tela = new PERGUNTAS_17_18_19();
            tela.Show();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BOTAO_ENCERAR_PERGUNTA_14_15_16_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ESPCEX_IMAGE_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RB_14_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_14_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_14_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_14_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_14_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_14_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RB_15_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_15_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_15_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_15_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_15_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_15_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RB_16_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_16_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_16_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_16_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_16_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_16_6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
