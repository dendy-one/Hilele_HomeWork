using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    //1
    //class City
    //{

    //    public string CityName { get; set; }
    //    public string RegionName { get; set; }
    //    public string CountryName { get; set; }
    //    public int Population { get; set; }
    //    public string PostalCode { get; set; }
    //    public string PhoneCode { get; set; }


    //    public City(string cityName, string regionName, string countryName, int population, string postalCode, string phoneCode)
    //    {
    //        CityName = cityName;
    //        RegionName = regionName;
    //        CountryName = countryName;
    //        Population = population;
    //        PostalCode = postalCode;
    //        PhoneCode = phoneCode;
    //    }


    //    public void GetCityInfo()
    //    {
    //        Console.WriteLine($"Місто: {CityName}");
    //        Console.WriteLine($"Регіон: {RegionName}");
    //        Console.WriteLine($"Країна: {CountryName}");
    //        Console.WriteLine($"Населення: {Population} жителів");
    //        Console.WriteLine($"Поштовий індекс: {PostalCode}");
    //        Console.WriteLine($"Телефонний код: {PhoneCode}");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.OutputEncoding = Encoding.UTF8;
    //        City kharkiv = new City("Харків", "Харківська область", "Україна", 1431000, "61000", "+38057");
    //        kharkiv.GetCityInfo();
    //        Console.WriteLine();


    //        City donetsk = new City("Донецьк", "Донецька область", "Україна", 950000, "83000", "+38062");
    //        donetsk.GetCityInfo();
    //        Console.WriteLine();


    //        City zhytomyr = new City("Житомер", "Житомирська область", "Україна", 270000, "10000", "+38041");
    //        zhytomyr.GetCityInfo();

    //        Console.ReadLine();
    //    }
    //}





    //2
    //class Country
    //{
      
    //    public string CountryName { get; set; }
    //    public string ContinentName { get; set; }
    //    public int Population { get; set; }
    //    public string PhoneCode { get; set; }
    //    public string CapitalName { get; set; }
    //    public string[] CityNames { get; set; }

        
    //    public Country(string countryName, string continentName, int population, string phoneCode, string capitalName, string[] cityNames)
    //    {
    //        CountryName = countryName;
    //        ContinentName = continentName;
    //        Population = population;
    //        PhoneCode = phoneCode;
    //        CapitalName = capitalName;
    //        CityNames = cityNames;
    //    }

        
    //    public void GetCountryInfo()
    //    {
    //        Console.WriteLine($"Країна: {CountryName}");
    //        Console.WriteLine($"Континент: {ContinentName}");
    //        Console.WriteLine($"Населення: {Population} жителів");
    //        Console.WriteLine($"Телефонний код: {PhoneCode}");
    //        Console.WriteLine($"Столиця: {CapitalName}");
    //        Console.WriteLine($"Міста: {string.Join(", ", CityNames)}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.OutputEncoding = Encoding.UTF8;
    //        Country greece = new Country("Греція", "Європа", 10715549, "+30", "Афіни", new string[] { "Салоніки", "Патра", "Ларіса" });
    //        greece.GetCountryInfo();


    //        Country croatia = new Country("Хорватія", "Європа", 4105493, "+385", "Загреб", new string[] { "Спліт", "Рієка", "Осієк" });
    //        croatia.GetCountryInfo();


    //        Country mexico = new Country("Мексика", "Північна Америка", 126190788, "+52", "Мехіко", new string[] { "Гвадалахара", "Монтеррей", "Пуебла" });
    //        mexico.GetCountryInfo();

    //        Console.ReadLine();
    //    }



    //}
}
