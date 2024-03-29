using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LucasTHEODOREMauiApp.Services;

namespace LucasTHEODOREMauiApp.ViewModel;

public partial class ApiPageViewModel : ObservableObject
{
    private readonly HttpClient _client = new HttpClient();
    
    
    public async Task<FetchApi> GetDisneyCharacter()
    {
        _client.BaseAddress = new Uri("https://api.disneyapi.dev/character");
        
        if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
        {
            return null;
        }

        return await _client.GetFromJsonAsync<FetchApi>("?pageSize=10");
    }
    private string name;
    private string imageUrl;
    private string description;
    
    private async Task FetchDisneyCharacter()
    {
        var fetchData = await GetDisneyCharacter();
        if (fetchData != null)
        {
            JsonConverter converter = new JsonConverter();
        }
    }
    
}