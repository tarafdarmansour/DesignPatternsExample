namespace DesignPatternsExample.Strategy.CompressionStrategy
{
    public interface ICompressionStrategy
    {
        string Compress(string content);
        string DeCompress(string content);
    }
}
