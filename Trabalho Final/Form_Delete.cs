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
using static System.Net.Mime.MediaTypeNames;

namespace Trabalho_Final
{
    public partial class Form_Delete : Form
    {
        public Form_Delete()
        {
            InitializeComponent();
            CenterToParent();
            BgColor();
            Posicao();
        }

        private void BgColor()
        {
            BackColor = Color.FromArgb(40, 42, 54);
            deleteBtn.BackColor = Color.FromArgb(56, 58, 89);
            textID.BackColor = Color.FromArgb(56, 58, 89);
        }

        private void Posicao()
        {
            deleteBtn.Location = new Point((Width - deleteBtn.Width) / 2, 62);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ConexaoString strconn = new ConexaoString();
            string conexao = strconn.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string cmd = string.Format("DELETE FROM produtos WHERE identificador ='{0}';", Convert.ToInt64(textID.Text));

            using (NpgsqlCommand pgsqlcmd = new NpgsqlCommand(cmd, con))
            {
                pgsqlcmd.ExecuteNonQuery();
            }

            con.Close();
            Close();
        }
    }
}
