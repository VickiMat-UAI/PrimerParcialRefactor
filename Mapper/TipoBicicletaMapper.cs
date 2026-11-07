using Entity;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public class TipoBicicletaMapper
    {
        public static TipoBicicleta Map(SqlDataReader reader)
        {
            return new TipoBicicleta
            {
                IdTipoBicicleta = Convert.ToInt32(reader["ID_TIPO_BICICLETA"]),
                Descripcion = reader["DESCRIPCION"].ToString()
            };
        }
    }
}
