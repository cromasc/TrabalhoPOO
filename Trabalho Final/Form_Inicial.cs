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
    public partial class Form_Inicial : Form
    {
        public Form_Inicial()
        {
            InitializeComponent();
            CenterToScreen();
            Posicao();
            BgColor();
        }

        private void Posicao()
        {
            // titulo
            title.Location = new Point((Width - title.Width) / 2, 10);

            // painel de cadastro
            cadPanel.Location = new Point((Width - cadPanel.Width) / 2, 140);
        }

        private void BgColor()
        {
            BackColor = Color.FromArgb(40, 42, 54);
            clientUser.BackColor = Color.FromArgb(56, 58, 89);
            clientPassword.BackColor = Color.FromArgb(56, 58, 89);
            entrarBtn.BackColor = Color.FromArgb(56, 58, 89);
            cadBtn.BackColor = Color.FromArgb(56, 58, 89);
        }

        private void limpar()
        {
            clientUser.Text = string.Empty; 
            clientPassword.Text = string.Empty;
        }

        public DataTable conexao(string cmd)
        {
            ConexaoString strconn = new ConexaoString();
            string conexao = strconn.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable();

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd, con))
            {
                Adpt.Fill(dt);
            }

            con.Close();
            return dt;
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if (clientUser.Text == "" || clientPassword.Text == "")
            {
                MessageBox.Show("Campos em branco.\nPreencha novamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                DataTable dt = conexao(string.Format("SELECT * FROM clientes WHERE usuario = '{0}' AND senha = '{1}';", clientUser.Text, clientPassword.Text));

                if (dt.Rows.Count == 0) // caso não haja usuário e senha correspondentes, dt terá 0 de linhas
                {
                    MessageBox.Show("Usuário ou senha incorretos.\nPreencha novamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clientPassword.Text = string.Empty;
                }
                else
                {
                    // preenchendo o objeto cliente com os dados correspondentes ao login
                    Cliente objCliente = new Cliente(dt.Rows[0]["nome"].ToString(), 
                        dt.Rows[0]["cpf"].ToString(), 
                        Convert.ToInt16(dt.Rows[0]["numero_de_pets"]), 
                        dt.Rows[0]["endereco"].ToString(), dt.Rows[0]["usuario"].ToString());

                    limpar();
                    Form_Main form = new Form_Main(objCliente);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
            }
        }

        private void cadBtn_Click(object sender, EventArgs e)
        {
            limpar();
            Form_cadastro form = new Form_cadastro();
            form.ShowDialog();
        }

        private void clientPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrarBtn_Click(sender, e);
            }
        }
    }
}
