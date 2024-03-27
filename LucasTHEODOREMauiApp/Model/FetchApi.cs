using System.Collections;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace LucasTHEODOREMauiApp;

public class FetchApi
{
    private ObservableCollection<Character> _observableCollection;
    public async void fetchDisneyCharacter()
    {
        Uri uri = new Uri("https://api.disneyapi.dev/character?page=1&pageSize=10000");
        HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage responseMessage = await client.GetAsync(uri);
            if (responseMessage.IsSuccessStatusCode)
            {
                string content = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                using (JsonDocument doc = JsonDocument.Parse(content))
                {
                    JsonElement root = doc.RootElement;
                    if (root.TryGetProperty("data", out JsonElement data))
                    {
                        foreach (JsonElement item in data.EnumerateArray())
                        {
                            Character character = new Character();
                            character.Name = item.GetProperty("name").GetString();
                            character.ImageUrl = item.GetProperty("imageurl").GetString();
                            character.Description = item.GetProperty("films").GetString();
                            _observableCollection.Add(character);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data property found");
                    }
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public ObservableCollection<Character> GetArrayList()
    {
        return _observableCollection;
    }
}