namespace Enom
{
    public class TestUriBuilder : System.UriBuilder
    {
        public TestUriBuilder(string query)
        {
            Query = query;
            Scheme = "http";
            Host = "resellertest.enom.com";
            Path = "interface.asp";
            Port = 80;
        }
    }
}