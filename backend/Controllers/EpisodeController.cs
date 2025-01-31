using Microsoft.AspNetCore.Mvc;
using RickAndMortyBFF.Services;
using RickAndMortyBFF.DTOs;

namespace RickAndMortyBFF.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EpisodesController : ControllerBase
{
    private readonly EpisodesService _episodeService;

    public EpisodesController(EpisodesService episodeService)
    {
        _episodeService = episodeService;
    }

    /// <summary>
    /// Obtiene una lista de episodios de Rick and Morty.
    /// </summary>
    /// <param name="page">Número de página (por defecto: 1).</param>
    /// <returns>Lista de episodios.</returns>
    [HttpGet]
    [ProducesResponseType(typeof(EpisodesResponse), 200)]
    [ProducesResponseType(500)]
    public async Task<IActionResult> GetEpisodes([FromQuery] int page = 1)
    {
        var result = await _episodeService.GetEpisodesAsync(page);
        if (result == null)
        {
            return StatusCode(500, "Error al obtener los episodios.");
        }
        return Ok(result);
    }
}
