namespace Trabalho_Final
{
    partial class Form_Main
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
            this.menuBox = new System.Windows.Forms.ComboBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.altpBtn = new System.Windows.Forms.Button();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.campo_usuario = new System.Windows.Forms.TextBox();
            this.campo_endereco = new System.Windows.Forms.TextBox();
            this.campo_cpf = new System.Windows.Forms.TextBox();
            this.campo_nome = new System.Windows.Forms.TextBox();
            this.altBtn = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.petsList = new System.Windows.Forms.ListView();
            this.labelPets = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prodPanel = new System.Windows.Forms.Panel();
            this.itemsList = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.prodPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBox
            // 
            this.menuBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBox.ForeColor = System.Drawing.Color.White;
            this.menuBox.FormattingEnabled = true;
            this.menuBox.Items.AddRange(new object[] {
            "Visualizar informações pessoais",
            "Visualizar lista de ítens"});
            this.menuBox.Location = new System.Drawing.Point(12, 67);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(226, 23);
            this.menuBox.TabIndex = 0;
            this.menuBox.SelectedIndexChanged += new System.EventHandler(this.menuBox_SelectedIndexChanged);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.altpBtn);
            this.infoPanel.Controls.Add(this.cnclBtn);
            this.infoPanel.Controls.Add(this.campo_usuario);
            this.infoPanel.Controls.Add(this.campo_endereco);
            this.infoPanel.Controls.Add(this.campo_cpf);
            this.infoPanel.Controls.Add(this.campo_nome);
            this.infoPanel.Controls.Add(this.altBtn);
            this.infoPanel.Controls.Add(this.labelUser);
            this.infoPanel.Controls.Add(this.petsList);
            this.infoPanel.Controls.Add(this.labelPets);
            this.infoPanel.Controls.Add(this.labelEndereco);
            this.infoPanel.Controls.Add(this.labelCPF);
            this.infoPanel.Controls.Add(this.labelNome);
            this.infoPanel.Location = new System.Drawing.Point(12, 94);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(362, 314);
            this.infoPanel.TabIndex = 1;
            this.infoPanel.Visible = false;
            // 
            // altpBtn
            // 
            this.altpBtn.AutoSize = true;
            this.altpBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.altpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altpBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altpBtn.ForeColor = System.Drawing.Color.White;
            this.altpBtn.Location = new System.Drawing.Point(0, 288);
            this.altpBtn.Name = "altpBtn";
            this.altpBtn.Size = new System.Drawing.Size(93, 26);
            this.altpBtn.TabIndex = 35;
            this.altpBtn.Text = "Alterar senha";
            this.altpBtn.UseVisualStyleBackColor = false;
            this.altpBtn.Click += new System.EventHandler(this.altpBtn_Click);
            // 
            // cnclBtn
            // 
            this.cnclBtn.AutoSize = true;
            this.cnclBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cnclBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnclBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnclBtn.ForeColor = System.Drawing.Color.White;
            this.cnclBtn.Location = new System.Drawing.Point(124, 220);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(66, 26);
            this.cnclBtn.TabIndex = 34;
            this.cnclBtn.Text = "Cancelar";
            this.cnclBtn.UseVisualStyleBackColor = false;
            this.cnclBtn.Visible = false;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // campo_usuario
            // 
            this.campo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campo_usuario.Enabled = false;
            this.campo_usuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_usuario.ForeColor = System.Drawing.Color.White;
            this.campo_usuario.Location = new System.Drawing.Point(0, 187);
            this.campo_usuario.Name = "campo_usuario";
            this.campo_usuario.Size = new System.Drawing.Size(190, 27);
            this.campo_usuario.TabIndex = 33;
            // 
            // campo_endereco
            // 
            this.campo_endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campo_endereco.Enabled = false;
            this.campo_endereco.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_endereco.ForeColor = System.Drawing.Color.White;
            this.campo_endereco.Location = new System.Drawing.Point(80, 40);
            this.campo_endereco.Multiline = true;
            this.campo_endereco.Name = "campo_endereco";
            this.campo_endereco.Size = new System.Drawing.Size(282, 50);
            this.campo_endereco.TabIndex = 32;
            // 
            // campo_cpf
            // 
            this.campo_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campo_cpf.Enabled = false;
            this.campo_cpf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_cpf.ForeColor = System.Drawing.Color.White;
            this.campo_cpf.Location = new System.Drawing.Point(80, 107);
            this.campo_cpf.Name = "campo_cpf";
            this.campo_cpf.Size = new System.Drawing.Size(110, 27);
            this.campo_cpf.TabIndex = 31;
            // 
            // campo_nome
            // 
            this.campo_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campo_nome.Enabled = false;
            this.campo_nome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_nome.ForeColor = System.Drawing.Color.White;
            this.campo_nome.Location = new System.Drawing.Point(80, 7);
            this.campo_nome.Name = "campo_nome";
            this.campo_nome.Size = new System.Drawing.Size(282, 27);
            this.campo_nome.TabIndex = 30;
            // 
            // altBtn
            // 
            this.altBtn.AutoSize = true;
            this.altBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.altBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altBtn.ForeColor = System.Drawing.Color.White;
            this.altBtn.Location = new System.Drawing.Point(0, 220);
            this.altBtn.Name = "altBtn";
            this.altBtn.Size = new System.Drawing.Size(93, 26);
            this.altBtn.TabIndex = 29;
            this.altBtn.Text = "Alterar";
            this.altBtn.UseVisualStyleBackColor = false;
            this.altBtn.Click += new System.EventHandler(this.altBtn_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Silver;
            this.labelUser.Location = new System.Drawing.Point(0, 165);
            this.labelUser.Margin = new System.Windows.Forms.Padding(0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(125, 19);
            this.labelUser.TabIndex = 27;
            this.labelUser.Text = "Nome de Usuário:";
            // 
            // petsList
            // 
            this.petsList.BackColor = System.Drawing.SystemColors.Window;
            this.petsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petsList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.petsList.FullRowSelect = true;
            this.petsList.GridLines = true;
            this.petsList.HideSelection = false;
            this.petsList.LabelEdit = true;
            this.petsList.Location = new System.Drawing.Point(213, 131);
            this.petsList.Name = "petsList";
            this.petsList.Size = new System.Drawing.Size(146, 180);
            this.petsList.TabIndex = 28;
            this.petsList.UseCompatibleStateImageBehavior = false;
            this.petsList.View = System.Windows.Forms.View.Details;
            // 
            // labelPets
            // 
            this.labelPets.AutoSize = true;
            this.labelPets.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPets.ForeColor = System.Drawing.Color.Silver;
            this.labelPets.Location = new System.Drawing.Point(209, 109);
            this.labelPets.Margin = new System.Windows.Forms.Padding(0);
            this.labelPets.Name = "labelPets";
            this.labelPets.Size = new System.Drawing.Size(41, 19);
            this.labelPets.TabIndex = 26;
            this.labelPets.Text = "Pets:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.ForeColor = System.Drawing.Color.Silver;
            this.labelEndereco.Location = new System.Drawing.Point(0, 55);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(73, 19);
            this.labelEndereco.TabIndex = 25;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.ForeColor = System.Drawing.Color.Silver;
            this.labelCPF.Location = new System.Drawing.Point(14, 109);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(37, 19);
            this.labelCPF.TabIndex = 24;
            this.labelCPF.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Silver;
            this.labelNome.Location = new System.Drawing.Point(14, 9);
            this.labelNome.Margin = new System.Windows.Forms.Padding(0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 19);
            this.labelNome.TabIndex = 23;
            this.labelNome.Text = "Nome:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Silver;
            this.title.Location = new System.Drawing.Point(135, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(130, 23);
            this.title.TabIndex = 21;
            this.title.Text = "Menu Principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Selecione o que deseja fazer";
            // 
            // prodPanel
            // 
            this.prodPanel.Controls.Add(this.btnPanel);
            this.prodPanel.Controls.Add(this.itemsList);
            this.prodPanel.Controls.Add(this.label6);
            this.prodPanel.Location = new System.Drawing.Point(12, 94);
            this.prodPanel.Name = "prodPanel";
            this.prodPanel.Size = new System.Drawing.Size(362, 329);
            this.prodPanel.TabIndex = 36;
            this.prodPanel.Visible = false;
            // 
            // itemsList
            // 
            this.itemsList.BackColor = System.Drawing.SystemColors.Window;
            this.itemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.itemsList.FullRowSelect = true;
            this.itemsList.GridLines = true;
            this.itemsList.HideSelection = false;
            this.itemsList.LabelEdit = true;
            this.itemsList.Location = new System.Drawing.Point(3, 34);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(356, 248);
            this.itemsList.TabIndex = 28;
            this.itemsList.UseCompatibleStateImageBehavior = false;
            this.itemsList.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Verifique os produtos que temos disponíveis:\r\n";
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(93, 26);
            this.addBtn.TabIndex = 38;
            this.addBtn.Text = "ADICIONAR";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.AutoSize = true;
            this.removeBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(97, 3);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(93, 26);
            this.removeBtn.TabIndex = 39;
            this.removeBtn.Text = "REMOVER";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.addBtn);
            this.btnPanel.Controls.Add(this.removeBtn);
            this.btnPanel.Location = new System.Drawing.Point(80, 293);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(193, 33);
            this.btnPanel.TabIndex = 40;
            this.btnPanel.Visible = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(386, 435);
            this.Controls.Add(this.prodPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.menuBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.prodPanel.ResumeLayout(false);
            this.prodPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuBox;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPets;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.ListView petsList;
        private System.Windows.Forms.Button altBtn;
        private System.Windows.Forms.TextBox campo_usuario;
        private System.Windows.Forms.TextBox campo_endereco;
        private System.Windows.Forms.TextBox campo_cpf;
        private System.Windows.Forms.TextBox campo_nome;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button altpBtn;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.Panel prodPanel;
        private System.Windows.Forms.ListView itemsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
    }
}