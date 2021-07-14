using System;
using System.Collections.Generic;
using System.Text;
namespace Entitites {
    abstract class TaxPayer {
        public string Name { get; set; }
        public double AnuallIncome { get; set; }

        public TaxPayer() {
        }

        protected TaxPayer(string name, double anuallIncome) {
            Name = name;
            AnuallIncome = anuallIncome;
        }

        public abstract double Tax();
    }
}
