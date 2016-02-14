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

namespace Excercise_4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Heater heater = new Heater();
        public MainPage()
        {
            this.InitializeComponent();
        }
        bool check;
        double value;


        /// <summary>
        /// Action when pressing the input keypad buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void Button_Click(object sender, RoutedEventArgs e)
         {
            Button button = sender as Button;
            if (button != null)
            {

                for (int i = 0; i < 10; i++) // Checking if the input was 1-9 numbers
                {
                    if (button.Content.ToString() == i.ToString())
                    {
                        valueTextBox.Text += button.Content.ToString();
                    }
                }
                if (button.Content.ToString() == "<-") // Checking if the delete input button was pressed
                {
                    if (valueTextBox.Text != "")
                    {
                        string removeChar = valueTextBox.Text.Substring(0, valueTextBox.Text.Length - 1);
                        valueTextBox.Text = removeChar;
                    }
                }
                if (button.Content.ToString() == ".") // Checking if the . button was pressed
                    valueTextBox.Text += ".";
            }
        }


        /// <summary>
        /// Actions when pressing the ok button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (temperatureRadioButton.IsChecked == true)
            {
                if (check = (double.TryParse(valueTextBox.Text, out value))) // Checking if the temperature radio button is checked
                {
                    if (value <= 120)
                    {
                        temperatureTextBlock.Text = heater.SetTemperature(value);
                        infoTextBlock.Text = "Info : Temperature set!";
                    }
                    else if (value > 120)
                    {
                        infoTextBlock.Text = "Info : Temperature too high -- Try a lower temperature";
                    }
                }
                else
                    infoTextBlock.Text = "Invalid input!";
            }

            else if (humidityRadioButton.IsChecked == true) // Checking if the humidity radio button is checked
            {
                if (check = (double.TryParse(valueTextBox.Text, out value)))
                {
                    if (value <= 100)
                    {
                        humidityTextBlock.Text = heater.SetHumidity(value);
                        infoTextBlock.Text = "Info : Humidity set!";
                    }
                    else if (value > 100)
                    {
                        infoTextBlock.Text = "info : Humidity too high -- Try a lower humidity";
                    }
                }
                else
                    infoTextBlock.Text = "Invalid input!";
            }

            valueTextBox.Text = ""; // Resetting the value input textbox
        }
    }

}

