using System;
using System.Collections.Generic;

namespace MVCCountriesLab
{
    class CountryController
    {
        List<Country> CountryDb;

        public CountryController()
        {
            CountryDb = new List<Country>()
            {
                new Country("USA","North America", new List<string>{"Red", "White", "Blue" }),
                new Country("Japan","Asia", new List<string>{"Red", "White"}),
                new Country("Finland","Europe", new List<string>{"White", "Blue" }),
                new Country("Sweden","Europe", new List<string>{"Yellow","Blue" })
            };
        }
        public void CountryAction(Country c)
        {
            CountryView CV = new CountryView(c);
            CV.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countryLV = new CountryListView(CountryDb);
            Console.WriteLine($"Hello, Welcome to the country app. Please select a country from the following list:");
            bool runProgram = true;
            while (runProgram)
            {
                CountryListAction(countryLV);
                Console.WriteLine("Would you like to continue? y/n");
                runProgram = Validator.Validator.GetContinue();
                Console.Clear();
            }
        }

        public void CountryListAction(CountryListView country)
        {
            country.Display();
            Console.WriteLine($"Select 0 - {CountryDb.Count}");
            int chosen = Validator.Validator.GetInt();
            Country c = CountryDb[chosen];
            CountryAction(c);
        }
    }
}
