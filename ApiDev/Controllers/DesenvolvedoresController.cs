using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace ApiDev.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DesenvolvedoresController : ControllerBase
{
    public readonly IGenericRepository<Desenvolvedor> _repository;
    public DesenvolvedoresController(IGenericRepository<Desenvolvedor> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var desenvolvedores = await _repository.GetAllAsync();
        return Ok(desenvolvedores);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var desenvolvedor = await _repository.GetByIdAsync(id);
        return Ok(desenvolvedor);
    }

    [HttpGet("endereco/{anos}")]
    public ActionResult EnderecosPorAnos(int anos)
    {
        var specification1 = new DesenvolvedorExperienciaEnderecoSpec(anos);
        var desenvolvedores = _repository.FindWithSpecificationPattern(specification1);

        return Ok(desenvolvedores);
    }

    [HttpGet("renda/{renda}")]
    public ActionResult RendaOrdenada(decimal renda)
    {
        var specification2 = new DesenvolvedorRendaEstimadaSpec(renda);
        var desenvolvedores = _repository.FindWithSpecificationPattern(specification2);
        return Ok(desenvolvedores);
    }
}
