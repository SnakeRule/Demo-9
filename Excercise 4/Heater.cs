using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    class Heater
    {

        private double temperature { get; set; }
        private double humidity { get; set; }

        public double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value <= 120)
                    temperature = value;
            }
        }
        public double Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                if (value <= 100)
                    humidity = value;
            }
        }

        public double Value { get; set; }

        public string SetTemperature(double value)
        {
            Temperature = value;
            return Temperature.ToString();
        }

        public string SetHumidity(double value)
        {
            Humidity = value;
            return Humidity.ToString();
        }
    }
}
