namespace Trabalho_Final
{
    partial class Form_Inicial
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
            this.title = new System.Windows.Forms.Label();
            this.clientUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.painel_cliente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientPassword = new System.Windows.Forms.TextBox();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.cadBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cadPanel = new System.Windows.Forms.Panel();
            this.painel_cliente.SuspendLayout();
            this.cadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Silver;
            this.title.Location = new System.Drawing.Point(63, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(292, 23);
            this.title.TabIndex = 20;
            this.title.Text = "Bem vindo ao assistente do MyPets";
            // 
            // clientUser
            // 
            this.clientUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientUser.ForeColor = System.Drawing.Color.White;
            this.clientUser.Location = new System.Drawing.Point(68, 0);
            this.clientUser.Name = "clientUser";
            this.clientUser.Size = new System.Drawing.Size(117, 27);
            this.clientUser.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(-4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Usuário";
            // 
            // painel_cliente
            // 
            this.painel_cliente.Controls.Add(this.label1);
            this.painel_cliente.Controls.Add(this.clientPassword);
            this.painel_cliente.Controls.Add(this.label2);
            this.painel_cliente.Controls.Add(this.clientUser);
            this.painel_cliente.Location = new System.Drawing.Point(49, 49);
            this.painel_cliente.Name = "painel_cliente";
            this.painel_cliente.Size = new System.Drawing.Size(185, 66);
            this.painel_cliente.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(-4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Senha";
            // 
            // clientPassword
            // 
            this.clientPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPassword.ForeColor = System.Drawing.Color.White;
            this.clientPassword.Location = new System.Drawing.Point(68, 36);
            this.clientPassword.Name = "clientPassword";
            this.clientPassword.Size = new System.Drawing.Size(117, 27);
            this.clientPassword.TabIndex = 24;
            this.clientPassword.UseSystemPasswordChar = true;
            this.clientPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientPassword_KeyDown);
            // 
            // entrarBtn
            // 
            this.entrarBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.entrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarBtn.Location = new System.Drawing.Point(253, 67);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(133, 31);
            this.entrarBtn.TabIndex = 27;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = false;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // cadBtn
            // 
            this.cadBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadBtn.Location = new System.Drawing.Point(133, 3);
            this.cadBtn.Name = "cadBtn";
            this.cadBtn.Size = new System.Drawing.Size(103, 30);
            this.cadBtn.TabIndex = 28;
            this.cadBtn.Text = "Cadastrar";
            this.cadBtn.UseVisualStyleBackColor = false;
            this.cadBtn.Click += new System.EventHandler(this.cadBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Não possui conta?";
            // 
            // cadPanel
            // 
            this.cadPanel.Controls.Add(this.cadBtn);
            this.cadPanel.Controls.Add(this.label3);
            this.cadPanel.Location = new System.Drawing.Point(104, 137);
            this.cadPanel.Name = "cadPanel";
            this.cadPanel.Size = new System.Drawing.Size(236, 36);
            this.cadPanel.TabIndex = 30;
            // 
            // Form_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(426, 195);
            this.Controls.Add(this.cadPanel);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.painel_cliente);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Inicial";
            this.Text = "MyPets";
            this.painel_cliente.ResumeLayout(false);
            this.painel_cliente.PerformLayout();
            this.cadPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox clientUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel painel_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientPassword;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.Button cadBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel cadPanel;
    }
}

