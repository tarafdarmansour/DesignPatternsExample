namespace DesignPatternsExample.FactoryMethod
{
    public interface Report
    {
        string Print();
        void SetData(string header, string footer);
    }
}
