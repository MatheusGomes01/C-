using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePeople.Entities
{
    class Company : TaxPayer
    {
        public int NumberOrEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOrEmployees) : base(name, anualIncome)
        {
            NumberOrEmployees = numberOrEmployees;
        }

        public override double Tax()
        {
            if (NumberOrEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.10;
            }
        }
    }
}
