namespace Trabalho_Final
{
    partial class Form_Password
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
            this.labelUser = new System.Windows.Forms.Label();
            this.senha_antiga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.senha_nova = new System.Windows.Forms.TextBox();
            this.altBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Silver;
            this.labelUser.Location = new System.Drawing.Point(9, 32);
            this.labelUser.Margin = new System.Windows.Forms.Padding(0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(89, 19);
            this.labelUser.TabIndex = 28;
            this.labelUser.Text = "Senha atual:";
            // 
            // senha_antiga
            // 
            this.senha_antiga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senha_antiga.Enabled = false;
            this.senha_antiga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_antiga.ForeColor = System.Drawing.Color.White;
            this.senha_antiga.Location = new System.Drawing.Point(109, 30);
            this.senha_antiga.Name = "senha_antiga";
            this.senha_antiga.Size = new System.Drawing.Size(225, 27);
            this.senha_antiga.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nova senha:";
            // 
            // senha_nova
            // 
            this.senha_nova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senha_nova.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_nova.ForeColor = System.Drawing.Color.White;
            this.senha_nova.Location = new System.Drawing.Point(109, 77);
            this.senha_nova.Name = "senha_nova";
            this.senha_nova.Size = new System.Drawing.Size(225, 27);
            this.senha_nova.TabIndex = 36;
            // 
            // altBtn
            // 
            this.altBtn.AutoSize = true;
            this.altBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.altBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altBtn.ForeColor = System.Drawing.Color.White;
            this.altBtn.Location = new System.Drawing.Point(131, 124);
            this.altBtn.Name = "altBtn";
            this.altBtn.Size = new System.Drawing.Size(93, 26);
            this.altBtn.TabIndex = 37;
            this.altBtn.Text = "ALTERAR";
            this.altBtn.UseVisualStyleBackColor = false;
            this.altBtn.Click += new System.EventHandler(this.altBtn_Click);
            // 
            // Form_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(346, 162);
            this.Controls.Add(this.altBtn);
            this.Controls.Add(this.senha_nova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senha_antiga);
            this.Controls.Add(this.labelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Password";
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox senha_antiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senha_nova;
        private System.Windows.Forms.Button altBtn;
    }
}