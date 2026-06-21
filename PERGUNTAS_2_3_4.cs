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
    public partial class PERGUNTAS_2_3_4 : Form
    {
        public PERGUNTAS_2_3_4()
        {
            InitializeComponent();
        }

        private void PERGUNTAS_2_3_4_Load(object sender, EventArgs e)
        {

        }

        private void RB_2_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RB_2_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_2_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_2_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_2_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_2_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_3_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_3_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_3_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_3_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_3_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_3_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_4_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_4_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_4_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_4_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_4_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_4_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_2_3_4_Click(object sender, EventArgs e)
        {
            if (!(RB_2_1.Checked || RB_2_2.Checked || RB_2_3.Checked ||
              RB_2_4.Checked || RB_2_5.Checked || RB_2_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 2.");
                return;
            }

            if (!(RB_3_1.Checked || RB_3_2.Checked || RB_3_3.Checked ||
                  RB_3_4.Checked || RB_3_5.Checked || RB_3_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 3.");
                return;
            }

            if (!(RB_4_1.Checked || RB_4_2.Checked || RB_4_3.Checked ||
                  RB_4_4.Checked || RB_4_5.Checked || RB_4_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 4.");
                return;
            }

            if (RB_2_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao = -5;
            }
            else if (RB_2_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao = -3;
            }
            else if (RB_2_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao = +1;
            }
            else if (RB_2_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao = +3;
            }
            else if (RB_2_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao = +3;
            }
            else if (RB_2_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao = 0;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_3_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao = -5;
            }
            else if (RB_3_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao = -3;
            }
            else if (RB_3_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao = +1;
            }
            else if (RB_3_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao = +3;
            }
            else if (RB_3_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao = +5;
            }
            else if (RB_3_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao = 0;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_4_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao = -5;
            }
            else if (RB_4_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao = -3;
            }
            else if (RB_4_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao = +1;
            }
            else if (RB_4_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao = +3;
            }
            else if (RB_4_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao = +5;
            }
            else if (RB_4_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao = 0;
            }

            PERGUNTAS_5_6_7 tela = new PERGUNTAS_5_6_7();
            tela.Show();
            this.Dispose();
        }

        private void BOTAO_ENCERAR_PERGUNTAS_2_3_4_Click(object sender, EventArgs e)
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
    }
}

