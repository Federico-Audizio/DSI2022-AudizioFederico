using MySql.Data.MySqlClient;


namespace PobreTITO
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox GetTextCUIL()
        {
            return textCUIL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SQL = new Usuario();

            SQL.InicioSecion(textCUIL.Text, textContraseña.Text);
  
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistarUsuario registarusuario = new RegistarUsuario();
            registarusuario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}