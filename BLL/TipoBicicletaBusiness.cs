using DAL;
using Entity;

namespace BLL;

public class TipoBicicletaBusiness
{
    private TipoBicicletaDAO tipoBicicletaDAO = new TipoBicicletaDAO();
    public List<TipoBicicleta> getAll()
    {
        try
        {
            return tipoBicicletaDAO.getAll();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

}
