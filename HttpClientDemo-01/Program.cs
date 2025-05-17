using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static readonly HttpClient httpClient = new HttpClient();
    static async Task Main(string[] args)
    {
        string uri = "http//www.contoso.com/";
        //Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {
            // Send a GET request to the specified URI and wait for the response.
            HttpResponseMessage response = await httpClient.GetAsync(uri);
            // Ensure the request was successful.
            response.EnsureSuccessStatusCode();
            // Read the response content as a string asynchronously.
            string responseBody = await response.Content.ReadAsStringAsync();
            // Output the response body to the console.
            Console.WriteLine(responseBody);
        }
        catch (HttpRequestException e)
        {
            // Handle any exceptions that occur during the request.
            Console.WriteLine($"Request error: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            // Handle task cancellation exceptions, which may indicate a timeout.
            Console.WriteLine($"Request timed out: {e.Message}");
        }
        catch (Exception e)
        {
            // Handle any other exceptions that may occur.
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}