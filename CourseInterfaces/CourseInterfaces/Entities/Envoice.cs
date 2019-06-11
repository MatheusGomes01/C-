using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CourseInterfaces.Entities
{
    class Envoice
    {
        public double BasePayment { get; set; }
        public double Tax { get; set; }

        public Envoice(double basePayment, double tax)
        {
            BasePayment = basePayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasePayment + Tax; }
        }

        public override string ToString()
        {
            return "BasePayment: " + BasePayment.ToString("F2", CultureInfo.InvariantCulture) +
                "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture) +
                "\nTotalPayment: " + Tax.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
