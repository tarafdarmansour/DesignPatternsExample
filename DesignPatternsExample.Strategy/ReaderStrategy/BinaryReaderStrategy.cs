
namespace DesignPatternsExample.Strategy.ReaderStrategy
{
    public class BinaryReaderStrategy : IReaderStrategy
    {
        public string Read(string address)
        {
            return $"<read-binary>{address}</read-binary>";
        }
    }
}
