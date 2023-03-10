using Npgsql;
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
        Form_Inicial formInicial = new Form_Inicial();

        public Form_cadastro()
        {
            InitializeComponent();
            CenterToParent();
            BgColor();
            Posicao();
        }

        private void BgColor()
        {
            // muda a cor de fundo de várias estruturas do form
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

        private void Posicao()
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
                if (textNome.Text == "" || textUser.Text == ""
                || textPwd.Text == "" || textCPF.Text == "")
                {
                    MessageBox.Show("Campos em branco.\nPreencha novamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    subtitle.Text = "Insira agora seu endereço.";
                    personalDataPanel.Visible = false;
                    addressPanel.Visible = true;
                    backBtn.Visible = true;

                    Posicao();
                }
            }
            else if (addressPanel.Visible == true)
            {
                if (ruaText.Text == "" || numeroText.Text == "" || bairroText.Text == "")
                {
                    MessageBox.Show("Campos em branco.\nPreencha novamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    subtitle.Text = "Digite o nome dos seus pets\n(separados por vírgulas).";
                    addressPanel.Visible = false;
                    petsPanel.Visible = true;
                    finalizarBtn.Visible = true;

                    Posicao();
                }
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

                Posicao();
            }
            else if (petsPanel.Visible == true)
            {
                subtitle.Text = "Insira agora seu endereço.";
                addressPanel.Visible = true;
                petsPanel.Visible = false;
                finalizarBtn.Visible = false;

                Posicao();
            }
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            if (namePets.Text == "")
            {
                MessageBox.Show("Campos em branco.\nPreencha novamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cursor = Cursors.WaitCursor;

                // criação da string endereço pela junção das strings de dados inseridas
                string endereco;

                if (compText.Text != string.Empty)
                {
                    endereco = string.Format("Rua {0} {1} {2}. Bairro {3}",
                        ruaText.Text, numeroText.Text, compText.Text, bairroText.Text);
                }
                else
                {
                    endereco = string.Format("Rua {0} {1}. Bairro {3}",
                        ruaText.Text, numeroText.Text, bairroText.Text);
                }

                // objeto de cadastro
                Cadastro novo_cadastro = new Cadastro(textNome.Text, textUser.Text,
                    textPwd.Text, textCPF.Text, endereco,
                    namePets.Text.Split(','));

                DataTable dt_cpf = formInicial.conexao(string.Format("SELECT * FROM clientes WHERE cpf = '{0}';", novo_cadastro.CPF));

                DataTable dt_user = formInicial.conexao(string.Format("SELECT * FROM clientes WHERE usuario = '{0}';", novo_cadastro.usuario));

                if (dt_cpf.Rows.Count != 0)
                {
                    MessageBox.Show("CPF já cadastrado.\nFaça o login.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else if (dt_user.Rows.Count != 0)
                {
                    MessageBox.Show("Usuário já cadastrado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor = Cursors.Default;
                }
                else
                {
                    ConexaoString strconn = new ConexaoString();

                    string conexao = strconn.ConnString();

                    NpgsqlConnection con = new NpgsqlConnection(conexao);

                    con.Open();

                    string cmd = string.Format("INSERT INTO clientes VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}');",
                    novo_cadastro.nome, novo_cadastro.CPF,
                    novo_cadastro.nPets, novo_cadastro.endereco,
                    novo_cadastro.usuario, novo_cadastro.senha);

                    using (NpgsqlCommand pgsqlcmd = new NpgsqlCommand(cmd, con))
                    {
                        pgsqlcmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < novo_cadastro.nPets; i++)
                    {
                        cmd = string.Format("INSERT INTO pets VALUES ('{0}', '{1}');", novo_cadastro.nome, novo_cadastro.nomePets[i].Trim());

                        using (NpgsqlCommand pgsqlcmd = new NpgsqlCommand(cmd, con))
                        {
                            pgsqlcmd.ExecuteNonQuery();
                        }
                    }

                    con.Close();
                    Close();
                }
            }
        }
    }
}
