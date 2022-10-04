using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PobreTITO
{
    internal class Incidente
    {

        public void RegistrarIncidente(string Problema, string Direcion, string Cuil)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;pwd=FG89fg89;database='pobretito'");
            conexion.Open();

            var id = Environment.TickCount;

            string scc = "insert into pobretito.incidente values(" + id + ",'" + Problema + "'," + Cuil + ",'" + Direcion + "');";
            MessageBox.Show(scc);

            MySqlCommand comando = new MySqlCommand(scc, conexion);
            try
            {
                int filas = comando.ExecuteNonQuery();
                MessageBox.Show("Incidente registrado");

            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
            conexion.Close();
        }
    }
}
