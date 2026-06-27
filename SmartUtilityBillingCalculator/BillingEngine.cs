using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilityBillingCalculator
{
     public class BillingEngine
    {
        private const double BASE_SERVICE_CHARGE = 100;
        private const double TAX_RATE = 0.12;
        private const double PRICE_PER_UNIT = 15;

        public double CalculateUsage(double[] readings)
        {
            double total = 0;

            foreach (double value in readings)
            {
                total += value;
            }

            return total;
        }

        public double CalculateSubtotal(double usage)
        {
            return BASE_SERVICE_CHARGE + (usage * PRICE_PER_UNIT);
        }
        public double CalculateTax(double subtotal)
        {
            return subtotal * TAX_RATE;
        }
        public double CalculateTotal(double subtotal)
        {
            return subtotal + CalculateTax(subtotal);
        }
    }
}
