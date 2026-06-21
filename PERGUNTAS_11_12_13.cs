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
    public partial class PERGUNTAS_11_12_13 : Form
    {
        public PERGUNTAS_11_12_13()
        {
            InitializeComponent();
        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_11_12_13_Click(object sender, EventArgs e)
        {
            if (!(RB_11_1.Checked || RB_11_2.Checked || RB_11_3.Checked ||
      RB_11_4.Checked || RB_11_5.Checked || RB_11_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 11.");
                return;
            }

            if (!(RB_12_1.Checked || RB_12_2.Checked || RB_12_3.Checked ||
                  RB_12_4.Checked || RB_12_5.Checked || RB_12_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 12.");
                return;
            }

            if (!(RB_13_1.Checked || RB_13_2.Checked || RB_13_3.Checked ||
                  RB_13_4.Checked || RB_13_5.Checked || RB_13_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 13.");
                return;
            }
            if (RB_11_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_11_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_11_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_11_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_11_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_11_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_12_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_12_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_12_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_12_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_12_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_12_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            ///////////////////////////////////////////////////////////////////////////
            if (RB_13_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_13_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_13_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_13_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_13_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_13_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }

            PERGUNTAS_14_15_16 tela = new PERGUNTAS_14_15_16();
            tela.Show();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RB_11_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_11_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_11_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_11_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_11_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_11_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RB_12_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_12_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_12_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_12_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_12_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_12_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RB_13_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_13_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_13_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_13_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_13_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_13_6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BOTAO_ENCERAR_PERGUNTA_11_12_13_Click(object sender, EventArgs e)
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

        private void PERGUNTAS_11_12_13_Load(object sender, EventArgs e)
        {

        }
    }
}