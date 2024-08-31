namespace DesignPatternsExample.Strategy.CompressionStrategy
{
    public class RarCompressionStrategy : ICompressionStrategy
    {
        public string Compress(string content)
        {
            return $"<compress-rar>{content}</compress-rar>";
        }

        public string DeCompress(string content)
        {
            return $"<decompress-rar>{content}</decompress-rar>";
        }
    }
}
