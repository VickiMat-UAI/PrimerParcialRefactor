using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL;

public class TipoBicicletaDAO
{
    private string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;
    public List<TipoBicicleta> getAll()
    {
        try
        {
            List<TipoBicicleta> tiposBicicleta = new List<TipoBicicleta>();
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
    public TipoBicicleta ObtenerPorId(int id)
    {
        TipoBicicleta tipo = null;
        using (SqlConnection sqlConnection = new SqlConnection(conectionString))
        {
            sqlConnection.Open();
            string sql = "SELECT * FROM TipoBicicleta WHERE ID_TIPO_BICICLETA = @Id";
            using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tipo = TipoBicicletaMapper.Map(reader);
                    }
                }
            }
        }
        return tipo;
    }
}