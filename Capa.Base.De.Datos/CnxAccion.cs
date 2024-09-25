using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;

namespace Capa.Base.De.Datos
{
    public class CnxAccion
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Replace("\\\\", "\\");
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public CnxAccion()
        {
        }

        public int AccionEjecutar(string sqlQuery, Dictionary<string, string> parametros)
        {
            int result = 0;
            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sqlQuery, cnn))
                    {
                        if (parametros != null)
                        {
                            foreach (var p in parametros)
                            {
                                cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                            }
                        }
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

                //MessageBox.Show("Falla en la capa datos: " + e.Message);
            }
            return result;
        }
    }
}

