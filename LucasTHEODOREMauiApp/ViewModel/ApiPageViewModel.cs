using System.Net.Http.Json;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LucasTHEODOREMauiApp.ViewModel;

public partial class ApiPageViewModel : ObservableObject
{
    private readonly HttpClient _client = new HttpClient();
    public string Name { get; set;}
    public string ImageUrl { get; set;}
    public string Description { get; set;}
    
    /*public async Task<FetchApi> GetDisneyCharacter()
    {
        _client.BaseAddress = new Uri("https://api.disneyapi.dev/character");
        
        if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
        {
            return null;
        }

        return await _client.GetFromJsonAsync<FetchApi>("?pageSize=10");
    }
    
    
    private async Task FetchDisneyCharacter()
    {
        var fetchData = await GetDisneyCharacter();
        if (fetchData != null)
        {
            Name = fetchData.data.name;
            ImageUrl = fetchData.data.imageUrl;
            Description = fetchData.data.sourceUrl;
        }
    }*/
    
}