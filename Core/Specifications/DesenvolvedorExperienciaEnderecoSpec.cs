using Core.Entities;

namespace Core.Specifications;

public class DesenvolvedorExperienciaEnderecoSpec : BaseSpecification<Desenvolvedor>
{
    public DesenvolvedorExperienciaEnderecoSpec(int anos) : base(x => x.AnosExperiencia > anos)
    {
        AddInclude(x => x.Endereco);
    }
}
