namespace MINDBOOST_3
{
    partial class CONTROLE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DATAGRID_ADMINISTRADOR_RELATORIOS = new System.Windows.Forms.DataGridView();
            this.RB_ATENDIMENTOS = new System.Windows.Forms.RadioButton();
            this.RB_ADMINS = new System.Windows.Forms.RadioButton();
            this.RB_PSICOS = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BOTAO_EXIBIR = new System.Windows.Forms.Button();
            this.BOTAO_MENU = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRID_ADMINISTRADOR_RELATORIOS)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.DATAGRID_ADMINISTRADOR_RELATORIOS);
            this.panel1.Location = new System.Drawing.Point(23, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 455);
            this.panel1.TabIndex = 16;
            // 
            // DATAGRID_ADMINISTRADOR_RELATORIOS
            // 
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.Location = new System.Drawing.Point(38, 32);
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.Margin = new System.Windows.Forms.Padding(4);
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.Name = "DATAGRID_ADMINISTRADOR_RELATORIOS";
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.RowHeadersWidth = 51;
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.Size = new System.Drawing.Size(662, 380);
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.TabIndex = 0;
            this.DATAGRID_ADMINISTRADOR_RELATORIOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGRID_ADMINISTRADOR_RELATÓRIOS_CellContentClick_1);
            // 
            // RB_ATENDIMENTOS
            // 
            this.RB_ATENDIMENTOS.AutoSize = true;
            this.RB_ATENDIMENTOS.Location = new System.Drawing.Point(8, 7);
            this.RB_ATENDIMENTOS.Name = "RB_ATENDIMENTOS";
            this.RB_ATENDIMENTOS.Size = new System.Drawing.Size(110, 20);
            this.RB_ATENDIMENTOS.TabIndex = 17;
            this.RB_ATENDIMENTOS.TabStop = true;
            this.RB_ATENDIMENTOS.Text = "Atendimentos";
            this.RB_ATENDIMENTOS.UseVisualStyleBackColor = true;
            // 
            // RB_ADMINS
            // 
            this.RB_ADMINS.AutoSize = true;
            this.RB_ADMINS.Location = new System.Drawing.Point(8, 43);
            this.RB_ADMINS.Name = "RB_ADMINS";
            this.RB_ADMINS.Size = new System.Drawing.Size(126, 20);
            this.RB_ADMINS.TabIndex = 18;
            this.RB_ADMINS.TabStop = true;
            this.RB_ADMINS.Text = "Administradores";
            this.RB_ADMINS.UseVisualStyleBackColor = true;
            // 
            // RB_PSICOS
            // 
            this.RB_PSICOS.AutoSize = true;
            this.RB_PSICOS.Location = new System.Drawing.Point(8, 77);
            this.RB_PSICOS.Name = "RB_PSICOS";
            this.RB_PSICOS.Size = new System.Drawing.Size(96, 20);
            this.RB_PSICOS.TabIndex = 19;
            this.RB_PSICOS.TabStop = true;
            this.RB_PSICOS.Text = "Psicólogos";
            this.RB_PSICOS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.RB_PSICOS);
            this.panel2.Controls.Add(this.RB_ADMINS);
            this.panel2.Controls.Add(this.RB_ATENDIMENTOS);
            this.panel2.Location = new System.Drawing.Point(23, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 105);
            this.panel2.TabIndex = 20;
            // 
            // BOTAO_EXIBIR
            // 
            this.BOTAO_EXIBIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BOTAO_EXIBIR.Location = new System.Drawing.Point(267, 486);
            this.BOTAO_EXIBIR.Name = "BOTAO_EXIBIR";
            this.BOTAO_EXIBIR.Size = new System.Drawing.Size(157, 61);
            this.BOTAO_EXIBIR.TabIndex = 21;
            this.BOTAO_EXIBIR.Text = "EXIBIR";
            this.BOTAO_EXIBIR.UseVisualStyleBackColor = false;
            // 
            // BOTAO_MENU
            // 
            this.BOTAO_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BOTAO_MENU.Location = new System.Drawing.Point(469, 486);
            this.BOTAO_MENU.Name = "BOTAO_MENU";
            this.BOTAO_MENU.Size = new System.Drawing.Size(157, 61);
            this.BOTAO_MENU.TabIndex = 22;
            this.BOTAO_MENU.Text = "MENU ";
            this.BOTAO_MENU.UseVisualStyleBackColor = false;
            this.BOTAO_MENU.Click += new System.EventHandler(this.BOTAO_MENU_Click);
            // 
            // CONTROLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.BOTAO_MENU);
            this.Controls.Add(this.BOTAO_EXIBIR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CONTROLE";
            this.Text = "CONTROLE";
            this.Load += new System.EventHandler(this.CONTROLE_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRID_ADMINISTRADOR_RELATORIOS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DATAGRID_ADMINISTRADOR_RELATORIOS;
        private System.Windows.Forms.RadioButton RB_ATENDIMENTOS;
        private System.Windows.Forms.RadioButton RB_ADMINS;
        private System.Windows.Forms.RadioButton RB_PSICOS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BOTAO_EXIBIR;
        private System.Windows.Forms.Button BOTAO_MENU;
    }
}