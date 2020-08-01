using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TaxPayers.Entities
{
    class Company : Payers
    {
        public int NumberOfEmployees { get; set; }
        public Company(string name, double income, int employees) : base(name, income)
        {
            NumberOfEmployees = employees;
        }
        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return base.Income * 0.14;
            }
            else
            {
                return base.Income * 0.16;
            }
        }
        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
