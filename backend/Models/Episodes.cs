using System.Text.Json.Serialization;

namespace RickAndMortyBFF.Models;

public class Episodes
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("air_date")]
    public string AirDate { get; set; } = string.Empty;
    
    public string Episode { get; set; } = string.Empty;
}
