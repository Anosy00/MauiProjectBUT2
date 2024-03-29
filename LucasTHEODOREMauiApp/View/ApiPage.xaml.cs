using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucasTHEODOREMauiApp.ViewModel;

namespace LucasTHEODOREMauiApp.View;

public partial class ApiPage : ContentPage
{
    public ApiPage()
    {
        InitializeComponent();
        List<Character> characters = new List<Character>()
        {
            new Character{ Name="Lucas", ImageUrl = "https://static.wikia.nocookie.net/disney/images/d/d3/Vlcsnap-2015-05-06-23h04m15s601.png", Description = "le meilleur"}
        };
        
        listCharacter.ItemsSource = characters;
    }
    
    

}