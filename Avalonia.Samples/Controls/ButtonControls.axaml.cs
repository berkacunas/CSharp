using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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
}