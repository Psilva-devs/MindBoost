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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void TEXT_USUARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void TEXT_SENHA_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOTAO_ENCERRAR_LOGIN_Click(object sender, EventArgs e)
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

        private void BOTAO_PROSSEGUIR_LOGIN_Click(object sender, EventArgs e)
        {
            string usuarioCorreto = "admin";
            string senhaCorreta = "ifsp";
            string usuarioDigitado = TEXT_USUARIO.Text;
            string senhaDigitada = TEXT_SENHA.Text;
            if (string.IsNullOrWhiteSpace(usuarioDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
            {
                MessageBox.Show("Acesso permitido! Bem-vindo.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //colocar o comando para seguir para pagina do relatorio dos admins logo a baixo:
                CONTROLE tela = new CONTROLE ();

                tela.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
                TEXT_USUARIO.Clear();
                TEXT_SENHA.Focus();
            }

        }
    }
}
