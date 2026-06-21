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
    public partial class PERGUNTAS_17_18_19 : Form
    {
        public PERGUNTAS_17_18_19()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_17_18_19_Click(object sender, EventArgs e)
        {
            if (!(RB_17_1.Checked || RB_17_2.Checked || RB_17_3.Checked ||
      RB_17_4.Checked || RB_17_5.Checked || RB_17_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 17.");
                return;
            }

            if (!(RB_18_1.Checked || RB_18_2.Checked || RB_18_3.Checked ||
                  RB_18_4.Checked || RB_18_5.Checked || RB_18_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 18.");
                return;
            }

            if (!(RB_19_1.Checked || RB_19_2.Checked || RB_19_3.Checked ||
                  RB_19_4.Checked || RB_19_5.Checked || RB_19_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 19.");
                return;
            }

            if (RB_17_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_17_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_17_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_17_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_17_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_17_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_18_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_18_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_18_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_18_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_18_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_18_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_19_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_19_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_19_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_19_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_19_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_19_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }

            PERGUNTAS_20_21_22 tela = new PERGUNTAS_20_21_22();
            tela.Show();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BOTAO_ENCERAR_PERGUNTA_17_18_19_Click(object sender, EventArgs e)
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

        private void RB_17_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_17_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_17_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_17_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_17_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_17_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RB_18_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_18_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_18_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_18_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_18_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_18_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RB_19_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_19_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_19_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_19_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_19_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_19_6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
