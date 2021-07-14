using System;
using System.Collections.Generic;
using System.Text;
namespace Entitites {
    class Company : TaxPayer {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anuallIncome, int numberOfEmployees) : base(name, anuallIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public Company() {
        }

        public override double Tax() {
            if (NumberOfEmployees < 20000.0) {
                return AnuallIncome * 0.14;
            }
            else {
                return AnuallIncome * 0.16;
            }
        }
    }
}
