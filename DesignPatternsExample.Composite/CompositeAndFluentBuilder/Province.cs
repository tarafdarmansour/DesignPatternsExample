namespace DesignPatternsExample.Composite.CompositeAndFluentBuilder
{
    public class Province : GeoComponent
    {
        public Province(string name): base(name)
        {
            
        }

        public override void Add(IGeoComponent member)
        {
            if (member is Province)
                _components.Add(member);
        }

        public override IList<string> GetCities()
        {
            return _components.Select(c => c.GetName()).ToList();
        }

        public override IList<string> GetProvinces()
        {
            return new List<string>();
        }
    }
}
