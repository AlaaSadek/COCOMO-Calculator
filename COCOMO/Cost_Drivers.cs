using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOMO
{
    class Cost_Drivers
    {
        double vLow, low, nominal, high, vHigh, eHigh;
        string costDriver;

        public Cost_Drivers(double vLow, double low, double nominal,double high,double vHigh,double eHigh,string costDriver)
        {
            this.vLow = vLow;
            this.low = low;
            this.nominal = nominal;
            this.high = high;
            this.vHigh = vHigh;
            this.eHigh = eHigh;
            this.costDriver = costDriver;
        }



   
    }
}
