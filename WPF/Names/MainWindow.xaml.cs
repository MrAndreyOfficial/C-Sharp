using System.Windows;

namespace Names;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddNameToListBox(object sender, RoutedEventArgs e)
    {
        var name = nameBox.Text;
        var canAddName = !string.IsNullOrWhiteSpace(name)
            && !listOfNames.Items.Contains(name);
        
        if (canAddName)
        {
            listOfNames.Items.Add(name);
            nameBox.Clear();
        }
    }

    private void RemoveName(object sender, RoutedEventArgs e)
    {
        var item = listOfNames.SelectedItem;

        listOfNames.Items.Remove(item);
    }

    private void ClearBox(object sender, RoutedEventArgs e) => nameBox.Clear();
}
