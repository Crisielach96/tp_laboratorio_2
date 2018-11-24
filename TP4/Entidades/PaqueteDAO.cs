using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand _comando;
        private static SqlConnection _conexion;


        static PaqueteDAO()
        {
            PaqueteDAO._conexion = new SqlConnection(Properties.Settings.Default.connectionStr);
            PaqueteDAO._comando = new SqlCommand();
            PaqueteDAO._comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO._comando.Connection = PaqueteDAO._conexion;
        }
        
        public static bool Insertar(Paquete p)
        {
            bool bandera = false;
            try
            {
                string query = "INSERT INTO " + "dbo.Paquetes" + "(direccionEntrega,trackingID,alumno) VALUES('"
                + p.DireccionEntrega + "','" + p.TrackingID + "','Cristian Sielach')";

                PaqueteDAO._comando.CommandText = query;
                PaqueteDAO._conexion.Open();
                PaqueteDAO._comando.ExecuteNonQuery();

                bandera = true;
            }
            catch (Exception)
            {
                bandera = false;
            }
            finally
            {
                if (PaqueteDAO._conexion.State == System.Data.ConnectionState.Open)
                {
                    PaqueteDAO._conexion.Close();
                }
            }
            return bandera;
        }


    }
}
