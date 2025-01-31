using RickAndMortyBFF.Models;

namespace RickAndMortyBFF.DTOs;

public class EpisodesResponse
{
    public PageInfo Info { get; set; } = new PageInfo();
    public List<Episodes> Results { get; set; } = new();
}
