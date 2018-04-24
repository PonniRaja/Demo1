using OpenWeatherMapAPI.UWP.Models;
namespace OpenWeatherMapAPI.UWP
{
    public partial class Configuration
    {

        //The base Uri for API calls
        public static string BaseUri = "http://api.openweathermap.org/data/2.5";

        //API key to authorize requests. If you don't have an OpenWeatherMap API key, use `fd4698c940c6d1da602a70ac34f0b147`.
        //TODO: Replace the Appid with an appropriate value
        public static string Appid = "";

    }
}