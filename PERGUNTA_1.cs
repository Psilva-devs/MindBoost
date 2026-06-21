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
    public partial class PERGUNTA_1 : Form
    {
        public PERGUNTA_1()
        {
            InitializeComponent();
        }

        private void PERGUNTA_1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BOTAO_PROSSEGUIR_PERGUNTA_1_Click(object sender, EventArgs e)
        {
            if (!(RB_1_1.Checked || RB_1_2.Checked || RB_1_3.Checked ||
      RB_1_4.Checked || RB_1_5.Checked || RB_1_6.Checked))
            {
                MessageBox.Show("Responda a pergunta 1.");
                return;
            }
            if (RB_1_1.Checked)
            {
                DadosAtendimento.Respostas.Add("Nunca");
                DadosAtendimento.Pontuacao += 0;
            }
            else if (RB_1_2.Checked)
            {
                DadosAtendimento.Respostas.Add("Raramente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_1_3.Checked)
            {
                DadosAtendimento.Respostas.Add("As vezes");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_1_4.Checked)
            {
                DadosAtendimento.Respostas.Add("Frequentemente");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_1_5.Checked)
            {
                DadosAtendimento.Respostas.Add("Quase sempre");
                DadosAtendimento.Pontuacao += 1;
            }
            else if (RB_1_6.Checked)
            {
                DadosAtendimento.Respostas.Add("Prefiro não responder");
                DadosAtendimento.Pontuacao += 1;
            }
            PERGUNTAS_2_3_4 tela = new PERGUNTAS_2_3_4();
            tela.Show();
            this.Dispose();
        }

        private void BOTAO_ENCERAR_PERGUNTA_1_Click(object sender, EventArgs e)
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

        private void RB_1_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_1_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_1_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_1_4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_1_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_1_6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
