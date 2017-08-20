namespace Enom
{
    public class ProdUriBuilder : System.UriBuilder
    {
            
        public ProdUriBuilder(string query)
        {
            Query = query;
            Scheme = "https";
            Host = "reseller.enom.com";
            Path = "interface.asp";
            Port = 443;
        }
    }
}
