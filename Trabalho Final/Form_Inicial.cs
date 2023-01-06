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
            posicionamento();
            bgColor();
        }

        private void posicionamento()
        {
            // titulo
            title.Location = new Point((Width - title.Width) / 2, 10);

            // painel de cadastro
            cadPanel.Location = new Point((Width - cadPanel.Width) / 2, 140);
        }

        private void bgColor()
        {
            BackColor = Color.FromArgb(40, 42, 54);
            clientUser.BackColor = Color.FromArgb(56, 58, 89);
            clientPassword.BackColor = Color.FromArgb(56, 58, 89);
            entrarBtn.BackColor = Color.FromArgb(56, 58, 89);
            cadBtn.BackColor = Color.FromArgb(56, 58, 89);
        }

        public void limpar()
        {
            clientUser.Text = "";
            clientPassword.Text = "";
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if (clientUser.Text == "" || clientPassword.Text == "")
            {
                MessageBox.Show("Campos em branco.\nPreencha novamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                ConexaoString strconn = new ConexaoString();

                // salva a string de conexão dentro da instância
                string conexao = strconn.ConnString();

                // conexão com o banco de dados
                NpgsqlConnection con = new NpgsqlConnection(conexao); 

                // objeto para armazenar a tabela
                DataTable dt = new DataTable();
                
                // é aberta a conexão com o servidor
                con.Open(); 

                string cmd = string.Format("SELECT * FROM clientes WHERE usuario = '{0}' AND senha = '{1}';", clientUser.Text, clientPassword.Text); // query para efetuar o login

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd, con))
                {
                    Adpt.Fill(dt);
                }
                if (dt.Rows.Count == 0) // caso não haja usuário e senha correspondentes, dt terá 0 de linhas
                {
                    MessageBox.Show("Usuário ou senha incorretos.\nPreencha novamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    // preenchendo o objeto cliente com os dados correspondentes ao login
                    Cliente objCliente = new Cliente(dt.Rows[0]["nome"].ToString(), 
                        dt.Rows[0]["cpf"].ToString(), 
                        Convert.ToInt16(dt.Rows[0]["numero_de_pets"]), 
                        dt.Rows[0]["endereco"].ToString(), dt.Rows[0]["usuario"].ToString());

                    MessageBox.Show(objCliente.Nome, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
        }

        private void cadBtn_Click(object sender, EventArgs e)
        {
            Form_cadastro form = new Form_cadastro();
            form.Show();
        }
    }
}
