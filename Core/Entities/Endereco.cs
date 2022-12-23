namespace Core.Entities;

public class Endereco
{
    public int Id { get; set; }
    public string Cidade { get; set; } = string.Empty;
    public string Localidade { get; set; }= string.Empty;
}
