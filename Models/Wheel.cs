using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyExample.Models
{
    public class Wheel
    {
        private double rim, tire;

        public Wheel(double rim, double tire)
        {
            this.rim = rim;
            this.tire = tire;
        }

        internal double diameter()
        {
            return rim + (tire * 2);
        }

        internal double circumference()
        {
            return diameter() * Math.PI;
        }

    }
}