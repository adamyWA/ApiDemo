using System;
using System.Net;
using System.IO;
using Enom;


class App
{
    static void Main()
    {
        Parameter[] paramArray = new Parameter[6]
        {
            new Parameter("command", "check"),
            new Parameter("sld", "google"),
            new Parameter("tld", "com"),
            new Parameter("uid", "resellid"),
            new Parameter("pw", "resellpw"),
            new Parameter("responseType", "xml")
        };

        Parameters parameters = new Parameters(paramArray);

        string query = Format.Input(parameters);
        
        UriBuilder uri = new TestUriBuilder(query);

        Console.WriteLine("The API call:");
        Console.WriteLine(uri.Uri);

        WebRequest request = WebRequest.CreateHttp(uri.Uri);
        WebResponse response = request.GetResponse();
        Stream stream = response.GetResponseStream();
        StreamReader readStream = new StreamReader(stream);


        Console.WriteLine("The API Response:");
        Console.WriteLine(readStream.ReadToEnd());

    }
}

