namespace DesignPatternsExample.FactoryMethod;

public class WebApplication : Application
{
    public Report CreateReport()
    {
        return new ColorfulReport();
    }
}