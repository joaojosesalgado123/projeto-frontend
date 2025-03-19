namespace ES2TrabFrontend.Services;
using ES2TrabFrontend.Models;
using System.Net.Http.Json;
public class ProjetoService
{
    private readonly HttpClient _httpClient;

    public ProjetoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Projeto>> GetProjetosAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Projeto>>("api/projetos");
    }

    public async Task<Projeto> GetProjetoByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Projeto>($"api/projetos/{id}");
    }

    public async Task<HttpResponseMessage> CreateProjetoAsync(Projeto projeto)
    {
        return await _httpClient.PostAsJsonAsync("api/projetos", projeto);
    }

    public async Task<HttpResponseMessage> UpdateProjetoAsync(int id, Projeto projeto)
    {
        return await _httpClient.PutAsJsonAsync($"api/projetos/{id}", projeto);
    }

    public async Task<HttpResponseMessage> DeleteProjetoAsync(int id)
    {
        return await _httpClient.DeleteAsync($"api/projetos/{id}");
    }
}
