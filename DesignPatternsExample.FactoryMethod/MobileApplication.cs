namespace DesignPatternsExample.FactoryMethod;

public class MobileApplication : Application
{
    public Report CreateReport()
    {
        return new BlackWhiteReport();
    }
}