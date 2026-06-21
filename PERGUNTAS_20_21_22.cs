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
    public partial class PERGUNTAS_20_21_22 : Form
    {
        public PERGUNTAS_20_21_22()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_20_21_22_Click(object sender, EventArgs e)
        {
            if (!(RB_20_1.Checked || RB_20_2.Checked || RB_20_3.Checked ||
      RB_20_4.Checked || RB_20_5.Checked || RB_20_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 20.");
                return;
            }

            if (!(RB_21_1.Checked || RB_21_2.Checked || RB_21_3.Checked ||
                  RB_21_4.Checked || RB_21_5.Checked || RB_21_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 21.");
                return;
            }

            if (!(RB_22_1.Checked || RB_22_2.Checked || RB_22_3.Checked ||
                  RB_22_4.Checked || RB_22_5.Checked || RB_22_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 22.");
                return;
            }
            if (RB_20_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_20_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_20_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_20_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_20_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_20_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_21_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_21_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_21_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_21_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_21_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_21_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_22_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_22_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_22_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_22_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_22_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_22_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }

            PERGUNTAS_23_24_25 tela = new PERGUNTAS_23_24_25();
            tela.Show();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BOTAO_ENCERAR_PERGUNTA_20_21_22_Click(object sender, EventArgs e)
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

        private void RB_20_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_20_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_20_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_20_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_20_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_20_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RB_21_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_21_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_21_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_21_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_21_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_21_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_22_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RB_22_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_22_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_22_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_22_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_22_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PERGUNTAS_20_21_22_Load(object sender, EventArgs e)
        {

        }
    }
}
