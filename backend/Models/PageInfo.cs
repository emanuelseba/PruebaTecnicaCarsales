using System.Text.Json.Serialization;

namespace RickAndMortyBFF.Models;
public class PageInfo
{
    public int Count { get; set; }
    public int Pages { get; set; }
}