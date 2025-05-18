using System;
using System.IO;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Create a request to the URL.
        WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");
        // If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultNetworkCredentials;
        // Get the response.
        WebResponse response = request.GetResponse();
        // Display the status.
        Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        Console.WriteLine(new String('*',50));
        // Get the stream containing content returned by the server.
        Stream dataStream = response.GetResponseStream();
        // Open the stream using a StreamReader for easy access.
        StreamReader reader = new StreamReader(dataStream);
        // Read the content fully up to the end of the stream.
        string responseFromServer = reader.ReadToEnd();
        // Display the content.
        Console.WriteLine(responseFromServer);
        Console.WriteLine(new String('*', 50));
        // Clean up the streams and the response.
        reader.Close();
        dataStream.Close();
        response.Close();
    }
}