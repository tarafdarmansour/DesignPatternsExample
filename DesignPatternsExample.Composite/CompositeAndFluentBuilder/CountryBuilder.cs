namespace DesignPatternsExample.Composite.CompositeAndFluentBuilder
{
    public class CountryBuilder : ICountryBuilder,ICountryHasNameBuilder, IProvinceAndCityBuilder
    {
        private Country _country;
        private Province _currentProvince;
        public ICountryHasNameBuilder WithName(string name)
        {
            _country = new Country(name);
            return this;
        }

        public IProvinceAndCityBuilder AddProvince(string name)
        {
            _currentProvince = new Province(name);
            _country.Add(_currentProvince);
            return this;
        }

        public IProvinceAndCityBuilder AddCity(int population , string name)
        {
            _currentProvince.Add(new City(population, name));
            return this;
        }

        public Country Build()
        {
            return _country;
        }
    }

    public interface ICountryBuilder
    {
        ICountryHasNameBuilder WithName(string name);
    }

    public interface ICountryHasNameBuilder
    {
        IProvinceAndCityBuilder AddProvince(string name);
    }
    
    public interface IProvinceAndCityBuilder
    {
        IProvinceAndCityBuilder AddProvince(string name);
        IProvinceAndCityBuilder AddCity(int population, string name);
        Country Build();
    }
}
