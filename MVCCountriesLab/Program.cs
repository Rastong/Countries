namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController country = new CountryController();
            country.WelcomeAction();
        }
    }
}
