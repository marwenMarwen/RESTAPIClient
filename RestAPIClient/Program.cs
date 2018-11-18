using RestAPIClient.APIClient;
using System;

namespace RestAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHttpClient = new CustomHttpClient();

            var x = myHttpClient.GetItem<Object>("http://localhost:49597/Setting").Result;

            myHttpClient.PostItem(
                new Object(),
            "http://localhost:49597/Setting").Wait();

            Console.WriteLine(x);
            Console.Read();
        }
    }
}
