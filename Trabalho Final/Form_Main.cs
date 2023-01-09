using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final
{
    public partial class Form_Main : Form
    {
        Form_Inicial formInicial = new Form_Inicial();

        public Form_Main()
        {
            InitializeComponent();
        }

        public Form_Main(Cliente cliente)
        {
            InitializeComponent();
            CenterToParent();
            BgColor();
            Posicao();
            Preencher(cliente);

            menuBox.SelectedIndex = 0;
        }

        private void BgColor()
        {
            BackColor = Color.FromArgb(40, 42, 54);
            menuBox.BackColor = Color.FromArgb(56, 58, 89);
            campo_nome.BackColor = Color.FromArgb(56, 58, 89);
            campo_cpf.BackColor = Color.FromArgb(56, 58, 89);
            campo_endereco.BackColor = Color.FromArgb(56, 58, 89);
            campo_usuario.BackColor = Color.FromArgb(56, 58, 89);
            altBtn.BackColor = Color.FromArgb(56, 58, 89);
            altpBtn.BackColor = Color.FromArgb(56, 58, 89);
            cnclBtn.BackColor = Color.FromArgb(184, 101, 131);
        }

        private void Posicao()
        {
            // titulo
            title.Location = new Point((Width - title.Width) / 2, 10);
        }
        
        private void Preencher(Cliente cliente)
        {
            // painel de informações
            campo_nome.Text = cliente.Nome;
            campo_cpf.Text = cliente.Cpf;
            campo_endereco.Text = cliente.Endereco;
            campo_usuario.Text = cliente.Usuario;

            petsList.Columns.Add("Nome", petsList.Width, HorizontalAlignment.Left);

            DataTable dt = formInicial.conexao(string.Format("SELECT nome FROM pets WHERE dono = '{0}';", cliente.Nome));

            for (int i = 0; i < cliente.NPets; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["nome"].ToString());
                petsList.Items.Add(item);
            }
        }

        private void menuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuBox.SelectedIndex == 0)
            {
                infoPanel.Visible = true;
                prodPanel.Visible = false;
            }
            else if (menuBox.SelectedIndex == 1)
            {
                infoPanel.Visible = false;
                prodPanel.Visible = true;
            }
        }

        private void altBtn_Click(object sender, EventArgs e)
        {
            if (campo_usuario.Enabled == false)
            {
                campo_usuario.Enabled = true;
                cnclBtn.Visible = true;
                altBtn.Text = "OK";
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                cnclBtn.Visible = false;

                campo_usuario.Enabled = false;
                altBtn.Text = "Alterar";

                DataTable dt = formInicial.conexao(string.Format("SELECT * FROM clientes WHERE usuario = '{0}';", campo_usuario.Text));

                if (dt.Rows.Count != 0)
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

                    string cmd = string.Format("UPDATE clientes SET usuario = '{0}' WHERE cpf = '{1}';", campo_usuario.Text, campo_cpf.Text);

                    using (NpgsqlCommand pgsqlcmd = new NpgsqlCommand(cmd, con))
                    {
                        pgsqlcmd.ExecuteNonQuery();
                    }

                    con.Close();
                    Cursor = Cursors.Default;

                    MessageBox.Show("Usuário modificado com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            cnclBtn.Visible = false;
            campo_usuario.Enabled = false;
            altBtn.Text = "Alterar";
        }

        private void altpBtn_Click(object sender, EventArgs e)
        {
            Form_Password form = new Form_Password(campo_cpf.Text);
            form.ShowDialog();
        }
    }
}