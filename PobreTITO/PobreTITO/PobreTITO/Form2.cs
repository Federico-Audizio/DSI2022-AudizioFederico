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
    public partial class RegistrarProblema : Form
    {
        public RegistrarProblema(String Cuil)
        {

            InitializeComponent();
            textCUIL.Text = Cuil;
            //textCUIL.Text = Convert.ToString(info.CUIL);

            MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;pwd=FG89fg89;database='pobretito'");
            conexion.Open();

            DataTable dt = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM pobretito.incidente;", conexion);
            adaptador.Fill(dt);
            Grilla.DataSource = dt;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            var incidente = new Incidente();

            incidente.RegistrarIncidente(listProblema.Text, textDireccion.Text, textCUIL.Text);
            
        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescripcionIncidente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCUIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
