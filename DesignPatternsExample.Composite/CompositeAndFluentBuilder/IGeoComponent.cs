namespace DesignPatternsExample.Composite.CompositeAndFluentBuilder;

public interface IGeoComponent
{
    int GetPopulation();
    void Remove(IGeoComponent member);
    void Add(IGeoComponent member);
    string GetName();
    IList<string> GetCities();
    IList<string> GetProvinces();
}