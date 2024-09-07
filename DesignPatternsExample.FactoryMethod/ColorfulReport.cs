namespace DesignPatternsExample.FactoryMethod;

public class ColorfulReport : Report
{
    private string _footer;
    private string _header;

    public string Print()
    {
        return $"Printing Colorful Report{Environment.NewLine}Header:{_header}{Environment.NewLine}Footer:{_footer}";
    }

    public void SetData(string header, string footer)
    {
        _header = header;
        _footer = footer;
    }
}