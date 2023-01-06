using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final
{
    public partial class Form_cadastro : Form
    {
        public Form_cadastro()
        {
            InitializeComponent();
            CenterToParent();
            bgColor();
            posicionamento();
        }

        private void bgColor()
        {
            BackColor = Color.FromArgb(40, 42, 54);
            textNome.BackColor = Color.FromArgb(56, 58, 89);
            textUser.BackColor = Color.FromArgb(56, 58, 89);
            textPwd.BackColor = Color.FromArgb(56, 58, 89);
            textCPF.BackColor = Color.FromArgb(56, 58, 89);
            nextBtn.BackColor = Color.FromArgb(56, 58, 89);
            finalizarBtn.BackColor = Color.FromArgb(56, 58, 89);
            backBtn.BackColor = Color.FromArgb(56, 58, 89);
            numeroText.BackColor = Color.FromArgb(56, 58, 89);
            ruaText.BackColor = Color.FromArgb(56, 58, 89);
            compText.BackColor = Color.FromArgb(56, 58, 89);
            bairroText.BackColor = Color.FromArgb(56, 58, 89);
            comboPets.BackColor = Color.FromArgb(56, 58, 89);
            namePets.BackColor = Color.FromArgb(56, 58, 89);
        }

        private void posicionamento()
        {
            // titulo
            title.Location = new Point((Width - title.Width) / 2, 10);

            // subtitulo
            subtitle.Location = new Point((Width - subtitle.Width) / 2, 40);

            // painel inicial
            personalDataPanel.Location = new Point((Width - personalDataPanel.Width) / 2, (Height - personalDataPanel.Height) / 2);

            // painel de endereço
            addressPanel.Location = new Point((Width - addressPanel.Width) / 2, (Height - addressPanel.Height) / 2);

            // painel de pets
            petsPanel.Location = new Point((Width - petsPanel.Width) / 2, (Height - petsPanel.Height) / 2);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (personalDataPanel.Visible == true)
            {
                subtitle.Text = "Insira agora seu endereço.";
                personalDataPanel.Visible = false;
                addressPanel.Visible = true;
                backBtn.Visible = true;

                posicionamento();
            }
            else if (addressPanel.Visible == true)
            {
                subtitle.Text = "Digite o nome dos seus pets\n(separados por vírgulas).";
                addressPanel.Visible = false;
                petsPanel.Visible = true;
                finalizarBtn.Visible = true;

                posicionamento();
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (addressPanel.Visible == true)
            {
                subtitle.Text = "Preencha os seguintes dados pessoais.";
                personalDataPanel.Visible = true;
                addressPanel.Visible = false;
                backBtn.Visible = false;

                posicionamento();
            }
            else if (petsPanel.Visible == true)
            {
                subtitle.Text = "Insira agora seu endereço.";
                addressPanel.Visible = true;
                petsPanel.Visible = false;
                finalizarBtn.Visible = false;

                posicionamento();
            }
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
