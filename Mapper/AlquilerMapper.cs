using Entity;
using Microsoft.Data.SqlClient;

namespace Mapper;

public class AlquilerMapper
{
    public static Alquiler Map(SqlDataReader sqlDataReader, TipoBicicleta tipoBicicleta)
    {
        Alquiler alquiler = new Alquiler();
        alquiler.NumeroAlquiler = Convert.ToInt32(sqlDataReader["NUMERO_ALQUILER"]);
        alquiler.DniCliente = sqlDataReader["DNI_CLIENTE"].ToString();
        alquiler.ImporteTotal = Convert.ToDecimal(sqlDataReader["IMPORTE_TOTAL"]);
        alquiler.FechaRegistro = Convert.ToDateTime(sqlDataReader["FECHA_REGISTRO"]);
        alquiler.FechaAlquiler = Convert.ToDateTime(sqlDataReader["FECHA_ALQUILER"]);

        alquiler.TipoBicicleta = tipoBicicleta;

        return alquiler;
    }
}
