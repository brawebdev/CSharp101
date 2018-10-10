using _03_Defining_Classes_2;
using System;

namespace _03_Defining_Classes_2_UI
{
    class ProgramUI
    {
        private WeatherRepository _weatherRepo;

        public void Run()
        {
            _weatherRepo = new WeatherRepository();

            Console.WriteLine("Enter the Weather ID:");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current temp (°f):"); //-- alt + 0176
            var temp = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Wind Speed (mph):");
            var speed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Wind Direction:\n" +
                "1. N \n2. NE \n3. E \n4. SE \n5. S \n6. SW \n7. W \n8. NW");
            var direction = int.Parse(Console.ReadLine());
            WindDirection windDirection = (WindDirection)direction;

            bool isWet;
            Console.WriteLine("Is it precipitating? (y/n)");
            var isWetString = Console.ReadLine();
            if (isWetString == "y") isWet = true;
            else isWet = false;

            var weather = new Weather
            {
                WeatherID = id,
                WeatherDate = DateTimeOffset.Now,
                WindSpeed = speed,
                WindDirection = windDirection,
                IsPrecipitating = isWet,
                Temperature = temp
            };

            _weatherRepo.AddWeatherItemToList(weather);
        }
    }
}