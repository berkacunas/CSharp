using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Controls;

public partial class ButtonControls : Window
{
    private int _spinnerContent = 123;
    public ButtonControls()
    {
        InitializeComponent();

        this.buttonSpinner.Content = _spinnerContent;
        this.buttonSpinner.ValidSpinDirection = ValidSpinDirections.Increase | ValidSpinDirections.Decrease;
    }

    public void buttonSpinner_Spin(object sender, SpinEventArgs e)
    {
        this.buttonSpinner.Content = (e.Direction == SpinDirection.Increase) ? ++_spinnerContent : --_spinnerContent;
    }

    public void radioButton_Checked(object sender, RoutedEventArgs e)
    {
        if (e.Source == null)
            return;

        RadioButton? radioButton = e.Source as RadioButton;
        this.textBlockMessage.Text = (radioButton.Content != null) ? radioButton.Content.ToString() : "Empty";
    }

    public void repeatButton_Click(object sender, RoutedEventArgs e)
    {
        this.repeatButtonMessage.Text += "\rButton clicked!";
    }

    public void splitButton_Click(object sender, RoutedEventArgs e)
    {
        if (e.Source == null)
            return;

        object? header = ((MenuItem)e.Source).Header;
        string headerText = (header != null) ? header.ToString() : null;

        switch (header) 
        {
            case "Subitem 1":
                this.textBlockMessage.Text = "Subitem 1";
                break;
            case "Subitem 2":
                this.textBlockMessage.Text = "Subitem 2";
                break;
            case "Subitem 3":
                this.textBlockMessage.Text = "Subitem 3";
                break;
            case "Item 2":
                this.textBlockMessage.Text = "Item 2";
                break;
            case "Item 3":
                this.textBlockMessage.Text = "Item 3";
                break;
            default:
                throw new ArgumentException("MenuItem Header value error !");
        }
    }

}