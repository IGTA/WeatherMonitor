using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeather
{
    public class Coord // координаты города
    {
        public double lon; // ширина
        public double lat; // долгота
    }
    public class Wind
    {
        public double speed; // скорость ветра
        public double deg; // направление ветра в град (метеорологическое)
        public double gust; // порыв ветра
    }
    public class Rain
    {
        [JsonProperty("1h")] public double h1; // кол-во осадков за 1 час
        [JsonProperty("3h")] public double h3; // кол-во осадков за 3 часа
    }
    public class Snow
    {
        [JsonProperty("1h")]  public double h1; // кол-во осадков за 1 час
        [JsonProperty("3h")]  public double h3; // кол-во осадков за 3 часа
    }
    public class Sys
    {
        public string country; // код страны 
        public string sunrise; // восход солнца
        public string sunset; // закат
    }
    public class Main
    {
        public double temp; // температура
        public double feels_like; // как люди ощущают эту температуру

        public double pressure; // атмосферное давление
        public double humidity; // влажность воздуха %

        public double temp_min;
        public double temp_max;

        public double sea_level; // Атмосферное давление на уровне моря, гПа
        public double grnd_level; // Атмосферное давление на уровне земли, гПа
    }
    public class Weather
    {
        public int id; // id типа погоды
        public string main; // тип погоды (Дождь, Снег и т.д.)
        public string description; // описание погоды
        public string icon; // код значка погоды
    }
    public class Clouds
    {
        public double all; // облочность
    }



    public class WeatherData
    {
        public static WeatherData instance;

        public string dt; // Время расчета данных, Unix, UTC    
        public int timezone; // Сдвиг в секундах от UTC

        public Sys sys;
        public Main main;
        public Coord coord;
        public Wind wind;
        public Snow snow;
        public Rain rain;
        public Clouds clouds;
        public Weather[] weather;

        public int id; /// id города
        public string name; // название города 

        public WeatherData()
        {
            instance = this;
        }

    }
}
