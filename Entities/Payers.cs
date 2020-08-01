using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayers.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected Payers(string name, double income)
        {
            Name = name;
            Income = income;
        }
        public abstract double Tax();
    }
}
