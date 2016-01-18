using System;

namespace SmallStore.German.Tests
{
    public class Eintrag
    {
        private double value;

        public Eintrag(double value)
        {
            this.value = value;
        }

        public double GetValue()
        {
            var rounded = Math.Round(value * 2, MidpointRounding.AwayFromZero) / 2;
            
            return rounded;
        }
    }
}