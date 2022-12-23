using Core.Entities;

namespace Core.Specifications;

public class DesenvolvedorRendaEstimadaSpec : BaseSpecification<Desenvolvedor>
{
    public DesenvolvedorRendaEstimadaSpec(decimal renda) : base(x => x.RendaEstimada > renda)
    {
        AddOrderByDescending(x => x.RendaEstimada);
    }
}
