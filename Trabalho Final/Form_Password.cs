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
    public partial class Form_Password : Form
    {
        Form_Inicial formInicial = new Form_Inicial();

        public Form_Password()
        {
            InitializeComponent();
        }

        public Form_Password(string cpf)
        {
            InitializeComponent();
            CenterToParent();
            Posicao();
            BgColor();
            Preencher(cpf);
        }

        private void Posicao()
        {
            // titulo
            altBtn.Location = new Point((Width - altBtn.Width) / 2, 123);
        }

        private void BgColor()
        {
            BackColor = Color.FromArgb(40, 42, 54);
            senha_antiga.BackColor = Color.FromArgb(56, 58, 89);
            senha_nova.BackColor = Color.FromArgb(56, 58, 89);
            altBtn.BackColor = Color.FromArgb(56, 58, 89);
        }

        private void Preencher(string cpf)
        {
            DataTable dt = formInicial.conexao(string.Format("SELECT senha FROM clientes WHERE cpf = '{0}';", cpf));
            senha_antiga.Text = dt.Rows[0]["senha"].ToString();
        }

        private void altBtn_Click(object sender, EventArgs e)
        {
            ConexaoString strconn = new ConexaoString();
            string conexao = strconn.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string cmd = string.Format("UPDATE clientes SET senha = '{0}' WHERE senha = '{1}';", senha_nova.Text, senha_antiga.Text);

            using (NpgsqlCommand pgsqlcmd = new NpgsqlCommand(cmd, con))
            {
                pgsqlcmd.ExecuteNonQuery();
            }

            con.Close();
            Cursor = Cursors.Default;

            Close();
        }
    }
}
