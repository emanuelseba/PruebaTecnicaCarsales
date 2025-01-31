using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using RickAndMortyBFF.DTOs;
using RickAndMortyBFF.Configurations;

namespace RickAndMortyBFF.Services;

public class EpisodesService
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public EpisodesService(HttpClient httpClient, IOptions<ApiSettings> options)
    {
        _httpClient = httpClient;
        _baseUrl = options.Value.BaseUrl;
    }

    public async Task<EpisodesResponse?> GetEpisodesAsync(int page = 1)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<EpisodesResponse>($"{_baseUrl}/episode?page={page}");
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error en la solicitud HTTP: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
            return null;
        }
    }
}
