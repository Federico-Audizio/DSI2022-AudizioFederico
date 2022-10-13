using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PobreTITO
{
    public partial class RegistarUsuario : Form
    {
        public RegistarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SQL = new Usuario();
            SQL.RegistrarUsuario(textCUIL.Text, textContraseña.Text, textTelefono.Text);
        }

        private void textCUIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
