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
            PreencherInfos(cliente);
            PreencherLista();

            if (cliente.Usuario == "admin")
            {
                btnPanel.Visible = true;
            }
        }
        
        private void Form_Main_Load(object sender, EventArgs e)
        {
            menuBox.SelectedIndex = 0;

            itemsList.Columns.Add("Nome", Convert.ToInt16(itemsList.Width * 0.3), HorizontalAlignment.Left);
            itemsList.Columns.Add("Quantidade", Convert.ToInt16(itemsList.Width * 0.2), HorizontalAlignment.Left);
            itemsList.Columns.Add("Código de identificação", Convert.ToInt16(itemsList.Width * 0.3), HorizontalAlignment.Left);
            itemsList.Columns.Add("Preço", Convert.ToInt16(itemsList.Width * 0.2), HorizontalAlignment.Left);
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
            addBtn.BackColor = Color.FromArgb(56, 58, 89);
            removeBtn.BackColor = Color.FromArgb(56, 58, 89);
        }

        private void Posicao()
        {

            // titulo
            title.Location = new Point((Width - title.Width) / 2, 10);
        }
        
        private void PreencherInfos(Cliente cliente)
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

        private void PreencherLista()
        {
            // painel de produtos
            itemsList.Items.Clear();
            DataTable dt = formInicial.conexao(string.Format("SELECT * FROM produtos"));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["nome"].ToString());
                item.SubItems.Add(dt.Rows[i]["quantidade"].ToString());
                item.SubItems.Add(dt.Rows[i]["identificador"].ToString());
                item.SubItems.Add("R$" + dt.Rows[i]["preco"].ToString());

                itemsList.Items.Add(item);
            }
        }

        private void menuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuBox.SelectedIndex == 0)
            {
                infoPanel.Visible = true;
                prodPanel.Visible = false;

                this.Height = 460;
            }
            else if (menuBox.SelectedIndex == 1)
            {
                infoPanel.Visible = false;
                prodPanel.Visible = true;

                if (btnPanel.Visible == true)
                {
                    this.Height = 474;
                }
                else
                {
                    this.Height = 427;
                }
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form_Add form = new Form_Add();
            form.ShowDialog();
            PreencherLista();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Form_Delete form = new Form_Delete();
            form.ShowDialog();
            PreencherLista();
        }
    }
}