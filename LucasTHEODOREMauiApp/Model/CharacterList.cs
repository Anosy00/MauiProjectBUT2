using System.Collections;
using System.Text.Json.Nodes;

namespace LucasTHEODOREMauiApp;

public class CharacterList
{
    public List<Character> Characters { get; set; }
    public JsonNode Info { get; set; }
    public JsonNode Data { get; set; }
    
}