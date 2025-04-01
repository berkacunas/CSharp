using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Controls;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    async public void buttonModalWindow_Click(object sender, RoutedEventArgs e)
    {
        textBlockMessage.Text = "Modal Window opened.";

        var window = new ModalWindow();
        var result = await window.ShowDialog<string>(this);

        textBlockMessage.Text = result;
    }

    public void buttonButtonControls_Click(object sender, RoutedEventArgs e)
    {
        textBlockMessage.Text = "ButtonControls window opened.";

        var window = new ButtonControls();
        window.ShowDialog(this);
    }
}