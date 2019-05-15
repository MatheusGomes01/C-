using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProduct.Entities
{
    class UserProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UserProduct()
        {

        }

        public UserProduct(string name, double price, DateTime manuFactureDate) : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + "(Manifacture date: " + ManuFactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
