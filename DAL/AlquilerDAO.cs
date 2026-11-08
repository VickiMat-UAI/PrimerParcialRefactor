using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL;

public class AlquilerDAO
{
    private string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;
    private TipoBicicletaDAO tipoBicicletaDAO = new TipoBicicletaDAO();
    public void eliminarAlquiler(int idAlquiler)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                con.Open();
                string query = "DELETE FROM Alquiler WHERE NUMERO_ALQUILER = @NumeroAlquiler";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@NumeroAlquiler", idAlquiler);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public void modificarAlquiler(Alquiler alquiler)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                con.Open();
                string query = "UPDATE Alquiler SET FECHA_ALQUILER = @FechaAlquiler, IMPORTE_TOTAL = @ImporteTotal WHERE NUMERO_ALQUILER = @NumeroAlquiler";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@NumeroAlquiler", alquiler.NumeroAlquiler);
                    command.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaAlquiler);
                    command.Parameters.AddWithValue("@ImporteTotal", alquiler.ImporteTotal);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public List<Alquiler> getAll()
    {
        try
        {
            List<Alquiler> lista = new List<Alquiler>();

            using (SqlConnection con = new SqlConnection(conectionString))
            {
                con.Open();
                string query = "SELECT NUMERO_ALQUILER, ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER FROM Alquiler";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idTipo = Convert.ToInt32(reader["ID_TIPO_BICICLETA"]);
                            TipoBicicleta tipoObj = tipoBicicletaDAO.ObtenerPorId(idTipo);

                            lista.Add(AlquilerMapper.Map(reader, tipoObj));
                        }
                    }
                }
            }
            return lista;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public void guardarAlquiler(Alquiler alquiler)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Alquiler (ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER) VALUES(@IdTipoBicicleta, @DniCliente, @ImporteTotal, @FechaRegistro, @FechaAlquiler)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@DniCliente", alquiler.DniCliente);
                    command.Parameters.AddWithValue("@ImporteTotal", alquiler.ImporteTotal);
                    command.Parameters.AddWithValue("@FechaRegistro", alquiler.FechaRegistro);
                    command.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaAlquiler);

                    command.Parameters.AddWithValue("@IdTipoBicicleta", alquiler.TipoBicicleta.IdTipoBicicleta);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public Alquiler getById(int idAlquiler)
    {
        try
        {
            Alquiler alquiler = null;

            using (SqlConnection con = new SqlConnection(conectionString))
            {
                con.Open();
                string query = "SELECT NUMERO_ALQUILER, ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER FROM Alquiler WHERE NUMERO_ALQUILER = @NumeroAlquiler";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@NumeroAlquiler", idAlquiler);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idTipo = Convert.ToInt32(reader["ID_TIPO_BICICLETA"]);
                            TipoBicicleta tipoObj = tipoBicicletaDAO.ObtenerPorId(idTipo);

                            alquiler = AlquilerMapper.Map(reader, tipoObj);
                        }
                    }
                }
            }
            return alquiler;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

}
