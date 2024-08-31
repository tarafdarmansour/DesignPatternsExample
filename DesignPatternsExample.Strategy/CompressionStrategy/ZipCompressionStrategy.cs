namespace DesignPatternsExample.Strategy.CompressionStrategy
{
    public class ZipCompressionStrategy : ICompressionStrategy
    {
        public string Compress(string content)
        {
            return $"<compress-zip>{content}</compress-zip>";
        }

        public string DeCompress(string content)
        {
            return $"<decompress-zip>{content}</decompress-zip>";
        }
    }
}
