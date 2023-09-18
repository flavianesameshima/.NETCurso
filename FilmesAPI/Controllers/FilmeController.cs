using AutoMapper;
using CursoNET.FilmeContext;
using CursoNET.FilmeContext.Model;
using FilmesApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private readonly FilmeContext _context;
    private readonly IMapper _mapper;

    public FilmeController(FilmeContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Adiciona um filme ao banco de dados
    /// </summary>
    /// <param name="filmeDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AdicionaFilme(
        [FromBody] FilmeDTO filmeDTO)
    {
        //código omitido 
        Filme filme = _mapper.Map<Filme>(filmeDTO);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscarFilmePorId), new { id = filme.Id }, filme);
    }

    [HttpGet("{id}")]
    public Filme BuscarFilmePorId(int Id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == Id);
        return filme;
    }

    [HttpGet]
    public IActionResult BuscarFilme([FromQuery] int skip, [FromQuery] int take)
    {
        var filme = _context.Filmes.Skip(skip).Take(take);
        return Ok(filme);
    }
}
