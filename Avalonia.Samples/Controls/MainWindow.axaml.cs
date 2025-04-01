using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Controls;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    async public void buttonOpenModalWindow_Click(object sender, RoutedEventArgs e)
    {
        textBlockMessage.Text = "Button clicked!";

        var ownerWindow = this;
        var window = new ModalWindow();
        var result = await window.ShowDialog<string>(ownerWindow);

        textBlockMessage.Text = result;
    }
}