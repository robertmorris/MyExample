using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyExample.Models
{
    public class Gear
    {
        private double chainring, cog;
        private Wheel wheel;

        public Gear(double chainring,double cog, Wheel wheel)
        {
            this.chainring = chainring;
            this.cog = cog;
            this.wheel = wheel;
        }

        public double ratio()
        {
            return chainring / cog;
        }

        public double gear_inches()
        {
            return ratio() * wheel.diameter();
        }

    }
}