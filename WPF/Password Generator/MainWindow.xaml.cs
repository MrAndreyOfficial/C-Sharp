using System.Text;
using System.Windows;

namespace Password_Generator;

public partial class MainWindow : Window
{
    public MainWindow() => InitializeComponent();

    private async void OnGenerateButtonClick(object sender, RoutedEventArgs e)
    {
        var lengthPassword = lengthBox.Text;

        if (!int.TryParse(lengthPassword, out int _))
        {
            MessageBox.Show("Enter an integer");
            return;
        }

        var password = await GeneratePassword(int.Parse(lengthPassword));

        generatedPasswordBox.Text = password;
    }

    private static async Task<string> GeneratePassword(int length)
    {
        var random = new Random();
        var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        var result = new StringBuilder(length);

        while (length-- > 0)
        {
            var symbol = chars[random.Next(chars.Length)];

            result.Append(symbol);

            await Task.Delay(1);
        }

        return result.ToString();
    }
}
