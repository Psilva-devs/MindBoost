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
    public partial class PERGUNTA_DISSERTATIVA_01 : Form
    {
        public PERGUNTA_DISSERTATIVA_01()
        {
            InitializeComponent();
        }

        private void PERGUNTA_DISSERTATIVA_01_Load(object sender, EventArgs e)
        {

        }

        private void BOTAO_PROSSEGUIR_PERGUNTA_DISSERTATIVA_01_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(TEXT_PERGUNTA_DISSERTATIVA_01.Text))
            {
                {
                    string resposta = TEXT_PERGUNTA_DISSERTATIVA_01.Text;

                    DadosAtendimento.Respostas.Add(resposta);
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite uma resposta antes de prosseguir.");
            }

            PERGUNTA_DISSERTATIVA_2 tela = new PERGUNTA_DISSERTATIVA_2();
            tela.Show();
            this.Dispose();
        }

        private void BOTAO_ENCERAR_PERGUNTA_DISSERTATIVA_01_Click(object sender, EventArgs e)
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

        private void TEXT_PERGUNTA_DISSERTATIVA_01_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
