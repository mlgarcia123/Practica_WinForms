using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_WinForms
{
    public class Conexion
    {
        public SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=WINAPY2GPPZUL8K\\SQLEXPRESS;Initial Catalog=ListadoSeries;Integrated Security=True");
                Console.WriteLine("Éxito al conectar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar. " + ex.Message);
            }
        }
    }
}
