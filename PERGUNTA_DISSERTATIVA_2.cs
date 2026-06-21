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
    public partial class PERGUNTA_DISSERTATIVA_2 : Form
    {
        public PERGUNTA_DISSERTATIVA_2()
        {
            InitializeComponent();
        }

        private void PERGUNTA_DISSERTATIVA_2_Load(object sender, EventArgs e)
        {

        }

        private void BOTAO_PROSSEGUIR_PERGUNTAS_DISSSERTATIVAS_02_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TEXT_PERGUNTA_DISSERTATIVA_02.Text))
            {
                // Adiciona a última resposta na lista
                string resposta = TEXT_PERGUNTA_DISSERTATIVA_02.Text;
                DadosAtendimento.Respostas.Add(resposta);

                // Dispara o salvamento completo que configuramos acima (Atendimento + 27 Respostas)
                ConexaoBanco.SalvarAtendimento();

                // Limpa a classe estática para o próximo soldado não usar dados antigos
                DadosAtendimento.LimparDados();

                // Retorna o software de forma limpa para a tela inicial
                Form1 inicio = new Form1();
                inicio.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Por favor, digite uma resposta antes de prosseguir.");
            }


        }

        private void BOTAO_ENCERAR_PERGUNTA_DISSERTATIVAS_02_Click(object sender, EventArgs e)
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

        private void TEXT_PERGUNTA_DISSERTATIVA_02_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
