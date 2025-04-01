using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Controls;

public partial class ModalWindow : Window
{
    public ModalWindow()
    {
        InitializeComponent();
    }

    public void buttonCloseWindow_Click(object sender, RoutedEventArgs e)
    {
        this.Close("This is a message from modal window when it's closed!");
    }
}