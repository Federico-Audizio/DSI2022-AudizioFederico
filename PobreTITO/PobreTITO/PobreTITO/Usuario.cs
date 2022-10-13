using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PobreTITO
{
    public class Usuario
    {
        public String CuilUsuario; 

        public String CUIL { get => CuilUsuario; set => CuilUsuario = value; }
        


        public void InicioSecion(string CUIL, string Contraseña)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;pwd=FG89fg89;database='pobretito'");
            conexion.Open();

            string scc = ("Select *from usuario where CUIL = " + CUIL + " and Contraseña = '" + Contraseña + "'");
            MySqlCommand comando = new MySqlCommand(scc, conexion);
            try
            {
                int filas = comando.ExecuteNonQuery();

                RegistrarProblema registrarusuario = new RegistrarProblema(CUIL);
                registrarusuario.Show();


            }
            catch
            {
                MessageBox.Show("Contraseña incorrecta");
            }
            conexion.Close();
        }

        public void RegistrarUsuario(string CUIL, string Contraseña, string Telefono)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;pwd=FG89fg89;database='pobretito'");
            conexion.Open();

            string scc = "insert into usuario values(" + CUIL + ",'" + Contraseña + "'," + Telefono + ")";
            MySqlCommand comando = new MySqlCommand(scc, conexion);
            try
            {
                int filas = comando.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado");

                RegistrarProblema registrarusuario = new RegistrarProblema(CUIL);
                registrarusuario.Show();

            }
            catch
            {
                MessageBox.Show("Usuario ya exitente");
            }
            conexion.Close();
        }

    }
}
