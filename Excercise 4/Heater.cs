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
                if (value <= 120 && value > 0)
                    temperature = value;
            }
        }
        public double Humidity { get; set; }

        public double Value { get; set; }
    }
}
