namespace DesignPatternsExample.Composite.CompositeAndFluentBuilder
{
    public class Country : GeoComponent
    {
        public Country(string name): base(name)
        {
            
        }

        public override void Add(IGeoComponent member)
        {
            if(member is Province)
                _components.Add(member);
        }

        public override IList<string> GetCities()
        {
            List<string> cities = new();
            foreach (var province in _components)
            {
                cities.AddRange(province.GetCities());
            }
            return cities;
        }

        public override IList<string> GetProvinces()
        {
            return _components.Select(p => p.GetName()).ToList();
        }
    }
}
