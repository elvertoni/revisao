namespace API.Models;
public class IMC
{
    public int IMCId { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public Usuario? Usuario { get; set; }
    public int UsuarioId { get; set; }
}

