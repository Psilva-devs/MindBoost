using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MINDBOOST_3
{
    public partial class PERGUNTAS_5_6_7 : Form
    {
        public PERGUNTAS_5_6_7()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_5_6_7_Click(object sender, EventArgs e)
        {
            if (!(RB_5_1.Checked || RB_5_2.Checked || RB_5_3.Checked ||
      RB_5_4.Checked || RB_5_5.Checked || RB_5_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 5.");
                return;
            }

            if (!(RB_6_1.Checked || RB_6_2.Checked || RB_6_3.Checked ||
                  RB_6_4.Checked || RB_6_5.Checked || RB_6_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 6.");
                return;
            }

            if (!(RB_7_1.Checked || RB_7_2.Checked || RB_7_3.Checked ||
                  RB_7_4.Checked || RB_7_5.Checked || RB_7_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 7.");
                return;
            }


            if (RB_5_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_5_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_5_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_5_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_5_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_5_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_6_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao = -5;
            }
            else if (RB_6_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao = -3;
            }
            else if (RB_6_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao = +1;
            }
            else if (RB_6_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao = +3;
            }
            else if (RB_6_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao = +5;
            }
            else if (RB_6_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao = 0;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_7_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_7_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_7_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_7_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_7_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_7_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }



            PERGUNTAS_8_9_10 tela = new PERGUNTAS_8_9_10();
            tela.Show();
            this.Dispose();
        }

        private void RB_7_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_5_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_5_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_5_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_5_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_5_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_5_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_6_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_6_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_6_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_6_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_6_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_6_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_7_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_7_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_7_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_7_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_7_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BOTAO_ENCERAR_PERGUNTA_5_6_7_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PERGUNTAS_5_6_7_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
