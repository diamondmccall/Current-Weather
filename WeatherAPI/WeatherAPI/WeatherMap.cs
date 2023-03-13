using System;
using Newtonsoft.Json.Linq;



namespace WeatherAPI
{
    public class WeatherMap
    {
        public static double Temp(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
            return temp;
        }
    }
}

