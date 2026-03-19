using System;
using System.Collections.Generic;
using System.Text;

namespace SEÇAO10P2DIANTE.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }


        public Individual(string name, double anualIncome, double healtexpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healtexpenditures;
        }

        public override double Tax()
        {
            double basictax = 0;
            if (AnualIncome < 20000.00)
            {
                 basictax = AnualIncome * 0.15;
            }
            else if (AnualIncome >= 20000.00)
            {
                 basictax = AnualIncome * 0.25;
            }
            if (HealthExpenditures > 0)
            {
                basictax -= (HealthExpenditures / 2);
            }
            return basictax;
        }
    }
}
