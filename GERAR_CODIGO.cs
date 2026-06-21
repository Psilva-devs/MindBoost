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
    public partial class GERAR_CODIGO : Form
    {
        public GERAR_CODIGO()
        {
            InitializeComponent();
        }

        private void GERAR_CODIGO_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            string caracteres = "ABCDEF0123456789";

            string codigo = "";

            for (int i = 0; i < 8; i++)
            {
                codigo += caracteres[random.Next(caracteres.Length)];
            }

            DadosAtendimento.CodigoHexadecimal = codigo;

            LBL_CODIGO_HEXADECIMAL.Text = codigo;
        }

        private void BOTAO_PROSSEGUIR_GERAR_CODIGO_Click(object sender, EventArgs e)
        {
            POSTO_GRADUACAO tela = new POSTO_GRADUACAO();
            tela.Show();
            this.Dispose();
        }

        private void BOTAO_ENCERAR_GERAR_CODIGO_Click(object sender, EventArgs e)
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
    }
}
