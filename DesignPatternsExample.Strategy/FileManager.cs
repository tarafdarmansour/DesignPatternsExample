using DesignPatternsExample.Strategy.CompressionStrategy;
using DesignPatternsExample.Strategy.ReaderStrategy;

namespace DesignPatternsExample.Strategy;

public class FileManager
{
    private readonly IReaderStrategy _reader;
    private readonly ICompressionStrategy _compression;

    public FileManager(IReaderStrategy reader, ICompressionStrategy compression)
    {
        _reader = reader;
        _compression = compression;
    }

    public string ReadFile(string address)
    {
        return _reader.Read(address);
    }

    public string CompressFile(string content)
    {
        return _compression.Compress(content);
    }
    public string DeCompressFile(string content)
    {
        return _compression.DeCompress(content);
    }
}