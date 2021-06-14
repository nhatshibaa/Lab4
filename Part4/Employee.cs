using System;

namespace Part4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateHired { get; set; }

        void CalculateBonus()
        {
            
        }

        void CalculateVacation()
        {
            
        }
    }
}