namespace IPLSeasonStats.Extensions.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message)
        : base(message)
        {
        }
    }
}
