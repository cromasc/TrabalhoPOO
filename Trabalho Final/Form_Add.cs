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
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
            CenterToParent();
            BgColor();
            Posicao();
        }

        private void BgColor()
        {
            BackColor = Color.FromArgb(40, 42, 54);
            addBtn.BackColor = Color.FromArgb(56, 58, 89);
            textNome.BackColor = Color.FromArgb(56, 58, 89);
            textID.BackColor = Color.FromArgb(56, 58, 89);
            textQt.BackColor = Color.FromArgb(56, 58, 89);
            textValue.BackColor = Color.FromArgb(56, 58, 89);

        }

        private void Posicao()
        {
            addBtn.Location = new Point((Width - addBtn.Width) / 2, 97);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ConexaoString strconn = new ConexaoString();

            string conexao = strconn.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string cmd = string.Format("INSERT INTO produtos VALUES ('{0}', '{1}', {2}, '{3}');", 
                textNome.Text, Convert.ToInt16(textQt.Text), 
                Convert.ToInt64(textID.Text), Convert.ToDouble(textValue.Text));

            using (NpgsqlCommand pgsqlcmd = new NpgsqlCommand(cmd, con))
            {
                pgsqlcmd.ExecuteNonQuery();
            }

            con.Close();
            Close();
        }
    }
}
