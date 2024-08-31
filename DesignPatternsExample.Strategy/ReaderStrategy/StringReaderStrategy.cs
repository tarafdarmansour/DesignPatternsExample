namespace DesignPatternsExample.Strategy.ReaderStrategy
{
    public class StringReaderStrategy : IReaderStrategy
    {
        public string Read(string address)
        {
            return $"<read-string>{address}</read-string>";
        }
    }
}
