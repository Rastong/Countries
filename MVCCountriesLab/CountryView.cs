using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name, -10}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent, -10}");
            foreach(string c in DisplayCountry.Colors)
            {
                Console.WriteLine(c);
            }
        }

    }
}
