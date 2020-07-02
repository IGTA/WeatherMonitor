using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeather
{
    public class RequestSettings
    {
        public static RequestSettings Use;

        private string url  = "http://api.openweathermap.org/data/2.5/weather";
        private string city  = "Иваново";
        private string appid = "a8934a33b74774a52a92e072ab3b4d55";
        private string lang  = "en";
        private string units = "metric";

        public RequestSettings()
        {
            Use = this;
        }

        public string GetRequestString()
        {
            return $"{url}?q={city}&appid={appid}&lang={lang}&units={units}"; 
        }

        public string GetRequestString(string _city)
        {
            return $"{url}?q={_city}&appid={appid}&lang={lang}&units={units}";
        }
    }
}
