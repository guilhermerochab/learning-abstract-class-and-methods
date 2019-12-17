using System;
using CourseTaxPayers.Entities;

namespace CourseTaxPayers.Entities {
    public class Individual : TaxPayer {
        public double Health { get; set; }

        public Individual(string name, double anualIncome, double health)
            : base(name, anualIncome) {
            Health = health;
        }

        public override double Tax() {
            double tax = 0.15;
            if (AnualIncome > 20000.00) {
                tax = 0.25;
            }

            return (AnualIncome * tax) - (Health * 0.5);
        }
    }
}
