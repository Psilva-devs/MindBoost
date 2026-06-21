namespace MINDBOOST_3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS = new System.Windows.Forms.Button();
            this.ESPCEX_IMAGE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ESPCEX_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // BOTAO_PROSSEGUIR_BOAS_VINDAS
            // 
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.Location = new System.Drawing.Point(576, 405);
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.Margin = new System.Windows.Forms.Padding(2);
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.Name = "BOTAO_PROSSEGUIR_BOAS_VINDAS";
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.Size = new System.Drawing.Size(145, 66);
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.TabIndex = 14;
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.Text = "PROSSEGUIR";
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.UseVisualStyleBackColor = false;
            this.BOTAO_PROSSEGUIR_BOAS_VINDAS.Click += new System.EventHandler(this.BOTAO_PROSSEGUIR_BOAS_VINDAS_Click);
            // 
            // ESPCEX_IMAGE
            // 
            this.ESPCEX_IMAGE.BackColor = System.Drawing.Color.Transparent;
            this.ESPCEX_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ESPCEX_IMAGE.ErrorImage = null;
            this.ESPCEX_IMAGE.Image = ((System.Drawing.Image)(resources.GetObject("ESPCEX_IMAGE.Image")));
            this.ESPCEX_IMAGE.InitialImage = null;
            this.ESPCEX_IMAGE.Location = new System.Drawing.Point(-2, -1);
            this.ESPCEX_IMAGE.Margin = new System.Windows.Forms.Padding(2);
            this.ESPCEX_IMAGE.Name = "ESPCEX_IMAGE";
            this.ESPCEX_IMAGE.Size = new System.Drawing.Size(72, 93);
            this.ESPCEX_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESPCEX_IMAGE.TabIndex = 13;
            this.ESPCEX_IMAGE.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.BOTAO_PROSSEGUIR_BOAS_VINDAS);
            this.Controls.Add(this.ESPCEX_IMAGE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ESPCEX_IMAGE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BOTAO_PROSSEGUIR_BOAS_VINDAS;
        private System.Windows.Forms.PictureBox ESPCEX_IMAGE;
    }
}

