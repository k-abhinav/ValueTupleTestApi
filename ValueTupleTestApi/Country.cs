namespace ValueTupleTestApi
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
    }

    internal class ErrorResource
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
    }
}