using Entity;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL;

public class TipoBicicletaDAO
{
    public List<TipoBicicleta> getAll()
    {
        try
        {
            List<TipoBicicleta> tiposBicicleta = new List<TipoBicicleta>();
            string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;
            using (SqlConnection conection = new SqlConnection(conectionString))
            {
                conection.Open();
                string query = "SELECT ID_TIPO_BICICLETA, DESCRIPCION FROM TipoBicicleta";
                using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoBicicleta turismo = new TipoBicicleta
                            {
                                IdTipoBicicleta = reader.GetInt32(0),
                                Descripcion = reader.GetString(1)
                            };
                            tiposBicicleta.Add(turismo);
                        }
                    }
                }
            }
            return tiposBicicleta;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}