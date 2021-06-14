using System;

namespace Part4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public int DateHired { get; set; }

        public abstract void CalculateBonus();

        public abstract void CalculateVacation();
    }
}