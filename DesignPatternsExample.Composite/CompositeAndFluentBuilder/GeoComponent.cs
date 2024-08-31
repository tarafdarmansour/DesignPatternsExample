namespace DesignPatternsExample.Composite.CompositeAndFluentBuilder
{
    public abstract class GeoComponent : IGeoComponent
    {
        protected IList<IGeoComponent> _components;
        private string _name;

        protected GeoComponent(string name)
        {
            _components = new List<IGeoComponent>();
            _name = name;
        }
        public void Remove(IGeoComponent member)
        {
            _components.Remove(member);
        }

        public abstract void Add(IGeoComponent member);
        
        public string GetName()
        {
            return _name;
        }

        public abstract IList<string> GetCities();
        
        public abstract IList<string> GetProvinces();

        public virtual int GetPopulation()
        {
            return _components.Sum(c => c.GetPopulation());
        }
    }
}
