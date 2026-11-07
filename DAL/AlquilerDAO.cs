using Entity;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL;

public class AlquilerDAO
{
    public void eliminarAlquiler(int idAlquiler)
    {
        string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;

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
        string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;

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
            string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;

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
                            Alquiler alquiler = new Alquiler
                            {
                                NumeroAlquiler = Convert.ToInt32(reader["NUMERO_ALQUILER"].ToString()),
                                IdTipoBicicleta = Convert.ToInt32(reader["ID_TIPO_BICICLETA"].ToString()),
                                DniCliente = reader["DNI_CLIENTE"].ToString(),
                                ImporteTotal = Convert.ToDecimal(reader["IMPORTE_TOTAL"].ToString()),
                                FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"].ToString()),
                                FechaAlquiler = Convert.ToDateTime(reader["FECHA_ALQUILER"].ToString())
                            };
                            lista.Add(alquiler);
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
        string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;

        try
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Alquiler (ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER) VALUES(@IdTipoBicicleta, @DniCliente, @ImporteTotal, @FechaRegistro, @FechaAlquiler)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdTipoBicicleta", alquiler.IdTipoBicicleta);
                    command.Parameters.AddWithValue("@DniCliente", alquiler.DniCliente);
                    command.Parameters.AddWithValue("@ImporteTotal", alquiler.ImporteTotal);
                    command.Parameters.AddWithValue("@FechaRegistro", alquiler.FechaRegistro);
                    command.Parameters.AddWithValue("@FechaAlquiler", alquiler.FechaAlquiler);
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
            string conectionString = ConfigurationManager.ConnectionStrings["ParcialConection"].ConnectionString;

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
                            alquiler = new Alquiler
                            {
                                NumeroAlquiler = Convert.ToInt32(reader["NUMERO_ALQUILER"].ToString()),
                                IdTipoBicicleta = Convert.ToInt32(reader["ID_TIPO_BICICLETA"].ToString()),
                                DniCliente = reader["DNI_CLIENTE"].ToString(),
                                ImporteTotal = Convert.ToDecimal(reader["IMPORTE_TOTAL"].ToString()),
                                FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"].ToString()),
                                FechaAlquiler = Convert.ToDateTime(reader["FECHA_ALQUILER"].ToString()),
                            };
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
