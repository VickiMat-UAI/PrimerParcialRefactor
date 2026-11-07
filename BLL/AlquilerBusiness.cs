using DAL;
using Entity;

namespace BLL;

public class AlquilerBusiness
{
    private AlquilerDAO alquilerDAO = new AlquilerDAO();

    public void guardarAlquiler(Alquiler alquiler)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(alquiler.DniCliente))
            {
                throw new Exception("El número de DNI del cliente no puede estar vacío.");
            }

            if (alquiler.DniCliente.Trim().Length <= 5)
            {
                throw new Exception("El número de DNI del cliente debe tener más de 5 caracteres.");
            }

            if (alquiler.IdTipoBicicleta <= 0)
            {
                throw new Exception("Debe seleccionar un tipo de bicicleta.");
            }

            if (alquiler.ImporteTotal <= 0)
            {
                throw new Exception("El importe total del alquiler no puede ser igual o menor a cero.");
            }

            if (alquiler.FechaAlquiler.Date < DateTime.Today)
            {
                throw new Exception("La fecha del alquiler no puede ser menor a la fecha actual del sistema.");
            }

            alquiler.FechaRegistro = DateTime.Now;

            alquilerDAO.guardarAlquiler(alquiler);

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
            return alquilerDAO.getAll();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public void eliminarAlquiler(int idAlquiler)
    {
        try
        {
            if (idAlquiler <= 0)
            {
                throw new Exception("El ID del alquiler debe ser un número entero mayor a cero.");
            }

            Alquiler alquilerExistente = alquilerDAO.getById(idAlquiler);

            if (alquilerExistente == null)
            {
                throw new Exception($"No se encontró ningún alquiler registrado con el ID {idAlquiler}.");
            }


            alquilerDAO.eliminarAlquiler(idAlquiler);
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public void modificarAlquiler(int idAlquiler, DateTime fechaAlquiler, decimal montoAlquiler)
    {
        try
        {
            if (idAlquiler <= 0)
            {
                throw new Exception("El ID del alquiler debe ser un número entero mayor a cero.");
            }

            Alquiler alquilerExistente = alquilerDAO.getById(idAlquiler);

            if (alquilerExistente == null)
            {
                throw new Exception($"No se encontró ningún alquiler registrado con el ID {idAlquiler}.");
            }


            if (montoAlquiler <= 0)
            {
                throw new Exception("El importe total debe ser mayor a cero.");
            }


            if (fechaAlquiler.Date < DateTime.Today)
            {
                throw new Exception("La fecha del alquiler no puede ser anterior a la fecha actual del sistema.");
            }


            alquilerExistente.ImporteTotal = montoAlquiler;
            alquilerExistente.FechaAlquiler = fechaAlquiler;

            alquilerDAO.modificarAlquiler(alquilerExistente);
        }
        catch (Exception ex)
        {
            throw;
        }

    }
}
