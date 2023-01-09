namespace Trabalho_Final
{
    partial class Form_Add
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
            this.personalDataPanel = new System.Windows.Forms.Panel();
            this.painel_cliente = new System.Windows.Forms.Panel();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textQt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.personalDataPanel.SuspendLayout();
            this.painel_cliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalDataPanel
            // 
            this.personalDataPanel.Controls.Add(this.painel_cliente);
            this.personalDataPanel.Controls.Add(this.panel1);
            this.personalDataPanel.Controls.Add(this.panel3);
            this.personalDataPanel.Controls.Add(this.panel2);
            this.personalDataPanel.Location = new System.Drawing.Point(12, 12);
            this.personalDataPanel.Name = "personalDataPanel";
            this.personalDataPanel.Size = new System.Drawing.Size(418, 61);
            this.personalDataPanel.TabIndex = 33;
            // 
            // painel_cliente
            // 
            this.painel_cliente.Controls.Add(this.textNome);
            this.painel_cliente.Controls.Add(this.label3);
            this.painel_cliente.Location = new System.Drawing.Point(0, 0);
            this.painel_cliente.Name = "painel_cliente";
            this.painel_cliente.Size = new System.Drawing.Size(418, 26);
            this.painel_cliente.TabIndex = 25;
            // 
            // textNome
            // 
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.ForeColor = System.Drawing.Color.White;
            this.textNome.Location = new System.Drawing.Point(54, 0);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(361, 26);
            this.textNome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(-4, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textQt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 26);
            this.panel1.TabIndex = 28;
            // 
            // textQt
            // 
            this.textQt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQt.ForeColor = System.Drawing.Color.White;
            this.textQt.Location = new System.Drawing.Point(85, 0);
            this.textQt.Name = "textQt";
            this.textQt.Size = new System.Drawing.Size(46, 26);
            this.textQt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quantidade";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(240, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 26);
            this.panel2.TabIndex = 29;
            // 
            // textID
            // 
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.Color.White;
            this.textID.Location = new System.Drawing.Point(105, 0);
            this.textID.Mask = "000000000";
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(70, 26);
            this.textID.TabIndex = 3;
            this.textID.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(-3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "n° identificador";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textValue);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(139, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 26);
            this.panel3.TabIndex = 30;
            // 
            // textValue
            // 
            this.textValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValue.ForeColor = System.Drawing.Color.White;
            this.textValue.Location = new System.Drawing.Point(43, 0);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(51, 26);
            this.textValue.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(-3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor";
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(164, 97);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(93, 30);
            this.addBtn.TabIndex = 39;
            this.addBtn.Text = "ADICIONAR";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(443, 139);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.personalDataPanel);
            this.Name = "Form_Add";
            this.Text = "Adicionar Produto";
            this.personalDataPanel.ResumeLayout(false);
            this.painel_cliente.ResumeLayout(false);
            this.painel_cliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel personalDataPanel;
        private System.Windows.Forms.Panel painel_cliente;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textQt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.MaskedTextBox textID;
        private System.Windows.Forms.TextBox textValue;
    }
}