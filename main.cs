using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(
            "https://shibe.online/api/shibes?count=[1-100]"
        );
        var shibaUrl = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        Console.WriteLine("");
        JsonNode resultNode = JsonNode.Parse(response)!;

        Console.WriteLine("Shiba URL is: " + shibaUrl + ".");
        Console.WriteLine("\nDone.");
    }
}