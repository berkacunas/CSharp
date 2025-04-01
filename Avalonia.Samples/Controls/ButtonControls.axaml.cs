using Avalonia.Controls;
using Avalonia.Controls.Primitives;
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
        RadioButton? obj = e.Source as RadioButton;

        if (obj == null)
            return;

        if (obj.Content == null)
            return;

        textBlockMessage.Text = obj.Content.ToString();
    }
}