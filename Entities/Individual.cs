using System.Globalization;

namespace TaxPayers.Entities
{
    class Individual : Payers
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double income, double expenditures) : base(name, income)
        {
            HealthExpenditures = expenditures;
        }

        public override double Tax()
        {
            if (base.Income < 20000.00)
            {
                if (HealthExpenditures != 0.0)
                {
                    return base.Income * 0.15 - (HealthExpenditures * 0.5);
                }
                return base.Income * 0.15;
            }
            else
            {
                if (HealthExpenditures != 0.0)
                {
                    return base.Income * 0.25 - (HealthExpenditures * 0.5);
                }
                return base.Income * 0.25;
            }
        }
        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
