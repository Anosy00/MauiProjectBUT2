using System.Collections;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace LucasTHEODOREMauiApp;

public class FetchApi
{
    [JsonPropertyName("info")]
    public FetchApiInfo info { get; set; }
    [JsonPropertyName("data")]
    public FetchApiData data { get; set; }
}

public class RootObject
{
    
}

public class FetchApiInfo
{
    public int count { get; set; }
    public int totalPages { get; set; }
    public object previousPage { get; set; }
    public string nextPage { get; set; }
}

public class FetchApiData
{
    public int _id { get; set; }
    public string[] films { get; set; }
    public object[] shortFilms { get; set; }
    public string[] tvShows { get; set; }
    public string[] videoGames { get; set; }
    public object[] parkAttractions { get; set; }
    public object[] allies { get; set; }
    public object[] enemies { get; set; }
    public string sourceUrl { get; set; }
    public string name { get; set; }
    public string imageUrl { get; set; }
    public string createdAt { get; set; }
    public string updatedAt { get; set; }
    public string url { get; set; }
    public int __v { get; set; }
}
