using SchoolMusic.Entidades;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMusic.BD
{
    public class CnxSelect
    {
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private DataTable table = null;
        private int idFound = 0;
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Replace("\\\\", "\\");

        public DataTable SelectData(string sqlQuery, Dictionary<string, string> prm)
        {
            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    try
                    {
                        cnn.Open();
                        using (cmd = new SqlCommand(sqlQuery, cnn))
                        {
                            if (prm != null)
                            {
                                foreach (var p in prm)
                                {
                                    cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                                }
                            }
                            using (reader = cmd.ExecuteReader())
                            {
                                table = new DataTable();
                                table.Load(reader);
                            }
                        }
                    }
                    catch (Exception e)
                    {

                        //MessageBox.Show("Error al traer registro de la base de datos");
                    }
                }
            }
            catch (Exception e)
            {

                //MessageBox.Show("Falla en la capa datos: " + e.Message);
            }
            return table;
        }
    }
}
