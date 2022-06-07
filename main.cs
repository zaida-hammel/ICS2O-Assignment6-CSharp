// Created by: Zaida Hammel
// Created on: May 2022
//
// This program accepts user input

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(
            "https://shibe.online/api/shibes?count=[1-100]"
        );
        var json = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        JsonNode jsonData = JsonNode.Parse(response)!;
        JsonNode url = jsonData[0]["url"];

        Console.WriteLine("Shiba Inu picture " + url + " .");
        Console.WriteLine("\nDone");
    }
}