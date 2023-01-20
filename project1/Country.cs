class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public double Area { get; set; }
    public long GDP { get; set; }

    public void LearnQueryEmployee()
    {
        List<Country> countries = new List<Country>(){

                new Country(){Name="Nepal",Continent="Asia",Area=343434,GDP=53535353},
                new Country(){Name="India",Continent="Asia",Area=35353453,GDP=76867888},
                 new Country(){Name="America",Continent="North America",Area=432535324,GDP=767676},
                new Country(){Name="German",Continent="Europr",Area=675676657,GDP=445454},


    };
        //var countrynames = countries.Where(c => c.Continent == "Asia");
        var countriesnames = countries.Where(c => c.Continent == "Asia").Select(c => c.Name);
        //var softwareEnginerer = employees.Where(e => e.age < 22 && e.Designation == "Developer");
        foreach (var e in countriesnames)
        {
            Console.WriteLine(e);
        }

    }


}

class TestCountry
{



    public static void Main()
    {

Country c1=new Country();
c1.LearnQueryEmployee();


    }
}