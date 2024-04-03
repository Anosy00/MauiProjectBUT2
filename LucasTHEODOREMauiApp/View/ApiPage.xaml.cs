using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using LucasTHEODOREMauiApp.ViewModel;
using Newtonsoft.Json;

namespace LucasTHEODOREMauiApp.View;

public partial class ApiPage : ContentPage
{
    public ApiPage()
    {
        InitializeComponent();
        List<Character> characters = new List<Character>()
        {
            new Character
            {
                Name = "Lucas",
                ImageUrl = "https://static.wikia.nocookie.net/disney/images/d/d3/Vlcsnap-2015-05-06-23h04m15s601.png",
                Description = "le meilleur"
            }
        };
        var character = 
        BindingContext = listCharacter;
        listCharacter.ItemsSource = characters;
    }


    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        var json = await client.GetStringAsync("https://api.disneyapi.dev/character?pageSize=1");
        CharacterList characterList = JsonConvert.DeserializeObject<CharacterList>(json);
        Console.Write(characterList);
        listCharacter.ItemsSource = characterList.Characters;
    }
}