namespace DesignPatternsExample.Composite.CompositeAndFluentBuilder
{
    public class City : GeoComponent
    {
        private readonly int _population = 0;
        public City(int population,string name): base(name)
        {
            _population = population;
        }

        public override IList<string> GetCities()
        {
            return new List<string>();
        }

        public override IList<string> GetProvinces()
        {
            return new List<string>();
        }

        public override int GetPopulation()
        {
            return _population;
        }

        public override void Add(IGeoComponent member)
        {
        }
    }
}
