namespace Entity;

public class Alquiler
{
    public int NumeroAlquiler { get; set; }

    public string DniCliente { get; set; }

    public decimal ImporteTotal { get; set; }
    public DateTime FechaRegistro { get; set; }

    public DateTime FechaAlquiler { get; set; }

    public string DescripcionTipoBicicleta { get => TipoBicicleta?.Descripcion ?? string.Empty; }

    public TipoBicicleta TipoBicicleta { get; set; }

}
