namespace Core.Entities;

public class Desenvolvedor
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int AnosExperiencia { get; set; }
    public decimal RendaEstimada { get; set; }
    public Endereco? Endereco { get; set; }
}
