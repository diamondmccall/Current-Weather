using System;
using System.IO;
using Newtonsoft.Json.Linq;
using WeatherAPI;

namespace WeatherAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("What is your zipcode.");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIKey}&units=imperial";

            Console.WriteLine();

            Console.WriteLine($"Currently it is {WeatherMap.Temp(apiCall)} degrees F in your location.");


        }
    }
}
