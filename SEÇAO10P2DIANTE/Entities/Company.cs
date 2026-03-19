using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace SEÇAO10P2DIANTE.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmplyees { get; set; }

        public Company(string name , double anualincome, int numberofemplyees) : base(name , anualincome)
        {
              NumberOfEmplyees = numberofemplyees;
        }

        public override double Tax()
        {
            double emptax = AnualIncome * 0.16;
            if (NumberOfEmplyees > 10)
            {
                emptax = AnualIncome * 0.14;
            }
            return emptax;

        }
    }
}
