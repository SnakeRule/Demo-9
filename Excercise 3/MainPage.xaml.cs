using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Excercise_3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double value;
            bool check;
            double wWidth = 0;
            double wHeight = 0;
            double wArea = 0;
            double fWidth = 45;
            double gArea = 0;
            double fCircle = 0;

            if (check = (double.TryParse(windowWidthTextBox.Text, out value)))
                wWidth = double.Parse(windowWidthTextBox.Text);
            
            if (check = (double.TryParse(windowHeightTextBox.Text, out value)))
                wHeight = double.Parse(windowHeightTextBox.Text);

            if (check = (double.TryParse(frameWidthTextBox.Text, out value)))
                fWidth = double.Parse(frameWidthTextBox.Text);

            wArea = (wWidth * wHeight) / 10;
            gArea = (wWidth - (fWidth*2)) * (wHeight - (fWidth*2)) / 10;
            fCircle = ((2 * wHeight) + (2 * wWidth)) / 10;

            windowAreaTextBox.Text = wArea.ToString() + " CM^2";
            glassAreatextBox.Text = gArea.ToString() + " CM^2";
            frameCircleTextBox.Text = fCircle.ToString() + " CM";
        }
    }
}
