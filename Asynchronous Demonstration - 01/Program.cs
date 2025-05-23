using System;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    //Using Event-Based Asynchronous Pattern (EAP)
    private static void DownloadAsynchronously()
    {
        WebClient client = new WebClient();
        client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadComplete);
        client.DownloadStringAsync(new Uri("https://dotnet.microsoft.com/en-us/apps/aspnet"));
    }

    private static void DownloadComplete(object sender, DownloadStringCompletedEventArgs e)
    {
        if (e.Error != null)
        {
            Console.WriteLine("Error: " + e.Error.Message);
            return;
        }
        //Print result
        Console.WriteLine(e.Result);
        Console.WriteLine(new String('*', 30));
        Console.WriteLine("Download completed.");
    }

    static void Main(string[] args)
    {
        DownloadAsynchronously();
        Console.WriteLine("Main thread: Done");
        Console.WriteLine(new String('*', 30));
        Console.ReadLine();
    }
}