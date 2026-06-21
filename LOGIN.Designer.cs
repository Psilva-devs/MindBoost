namespace MINDBOOST_3
{
    partial class LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.TEXT_USUARIO = new System.Windows.Forms.TextBox();
            this.TEXT_SENHA = new System.Windows.Forms.TextBox();
            this.BOTAO_ENCERRAR_LOGIN = new System.Windows.Forms.Button();
            this.BOTAO_PROSSEGUIR_LOGIN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ESPCEX_IMAGE = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESPCEX_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // TEXT_USUARIO
            // 
            this.TEXT_USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TEXT_USUARIO.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_USUARIO.Location = new System.Drawing.Point(173, 34);
            this.TEXT_USUARIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TEXT_USUARIO.Name = "TEXT_USUARIO";
            this.TEXT_USUARIO.Size = new System.Drawing.Size(201, 36);
            this.TEXT_USUARIO.TabIndex = 0;
            this.TEXT_USUARIO.TextChanged += new System.EventHandler(this.TEXT_USUARIO_TextChanged);
            // 
            // TEXT_SENHA
            // 
            this.TEXT_SENHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TEXT_SENHA.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_SENHA.Location = new System.Drawing.Point(173, 105);
            this.TEXT_SENHA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TEXT_SENHA.Name = "TEXT_SENHA";
            this.TEXT_SENHA.PasswordChar = '*';
            this.TEXT_SENHA.Size = new System.Drawing.Size(201, 36);
            this.TEXT_SENHA.TabIndex = 1;
            this.TEXT_SENHA.TextChanged += new System.EventHandler(this.TEXT_SENHA_TextChanged);
            // 
            // BOTAO_ENCERRAR_LOGIN
            // 
            this.BOTAO_ENCERRAR_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BOTAO_ENCERRAR_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTAO_ENCERRAR_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BOTAO_ENCERRAR_LOGIN.Location = new System.Drawing.Point(199, 450);
            this.BOTAO_ENCERRAR_LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BOTAO_ENCERRAR_LOGIN.Name = "BOTAO_ENCERRAR_LOGIN";
            this.BOTAO_ENCERRAR_LOGIN.Size = new System.Drawing.Size(160, 76);
            this.BOTAO_ENCERRAR_LOGIN.TabIndex = 18;
            this.BOTAO_ENCERRAR_LOGIN.Text = "ENCERRAR";
            this.BOTAO_ENCERRAR_LOGIN.UseVisualStyleBackColor = false;
            this.BOTAO_ENCERRAR_LOGIN.Click += new System.EventHandler(this.BOTAO_ENCERRAR_LOGIN_Click);
            // 
            // BOTAO_PROSSEGUIR_LOGIN
            // 
            this.BOTAO_PROSSEGUIR_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BOTAO_PROSSEGUIR_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTAO_PROSSEGUIR_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BOTAO_PROSSEGUIR_LOGIN.Location = new System.Drawing.Point(394, 450);
            this.BOTAO_PROSSEGUIR_LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BOTAO_PROSSEGUIR_LOGIN.Name = "BOTAO_PROSSEGUIR_LOGIN";
            this.BOTAO_PROSSEGUIR_LOGIN.Size = new System.Drawing.Size(160, 76);
            this.BOTAO_PROSSEGUIR_LOGIN.TabIndex = 17;
            this.BOTAO_PROSSEGUIR_LOGIN.Text = "PROSSEGUIR";
            this.BOTAO_PROSSEGUIR_LOGIN.UseVisualStyleBackColor = false;
            this.BOTAO_PROSSEGUIR_LOGIN.Click += new System.EventHandler(this.BOTAO_PROSSEGUIR_LOGIN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TEXT_USUARIO);
            this.panel1.Controls.Add(this.TEXT_SENHA);
            this.panel1.Location = new System.Drawing.Point(162, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 172);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // ESPCEX_IMAGE
            // 
            this.ESPCEX_IMAGE.BackColor = System.Drawing.Color.Transparent;
            this.ESPCEX_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ESPCEX_IMAGE.ErrorImage = null;
            this.ESPCEX_IMAGE.Image = ((System.Drawing.Image)(resources.GetObject("ESPCEX_IMAGE.Image")));
            this.ESPCEX_IMAGE.InitialImage = null;
            this.ESPCEX_IMAGE.Location = new System.Drawing.Point(0, -4);
            this.ESPCEX_IMAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ESPCEX_IMAGE.Name = "ESPCEX_IMAGE";
            this.ESPCEX_IMAGE.Size = new System.Drawing.Size(96, 114);
            this.ESPCEX_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESPCEX_IMAGE.TabIndex = 15;
            this.ESPCEX_IMAGE.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.BOTAO_ENCERRAR_LOGIN);
            this.Controls.Add(this.BOTAO_PROSSEGUIR_LOGIN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ESPCEX_IMAGE);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESPCEX_IMAGE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TEXT_USUARIO;
        private System.Windows.Forms.TextBox TEXT_SENHA;
        private System.Windows.Forms.Button BOTAO_ENCERRAR_LOGIN;
        private System.Windows.Forms.Button BOTAO_PROSSEGUIR_LOGIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ESPCEX_IMAGE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}