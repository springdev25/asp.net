using System;
using System.Net.Http;
using System.Windows;

namespace HttpClientDemo_02
{
    public partial class MainWindow : Window
    {
        // Creating an instance of HttpClient to use for fetching content
        readonly HttpClient client = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Close button event handler
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Clear button event handler
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtContent.Text = string.Empty;
        }

        // View HTML button event handler
        private async void btnViewHTML_Click(object sender, RoutedEventArgs e)
        {
            string uri = txtURL.Text; // Get URL from the TextBox

            // Try to fetch the HTML from the URL
            try
            {
                // Asynchronous call to fetch HTML content
                string responseBody = await client.GetStringAsync(uri);
                txtContent.Text = responseBody.Trim(); // Display the result in the TextBox
            }
            catch (HttpRequestException ex)
            {
                // Handle any errors that occur during the HTTP request
                MessageBox.Show($"Error: {ex.Message}", "Request Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}