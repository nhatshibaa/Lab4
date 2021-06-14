using System;

namespace Part4
{
    public class Staff : Employee
    {
        public string Title { get; set; }
        public override void CalculateBonus()
        {
            double bonus = 0.6 * Salary;
            Console.WriteLine($"Total bonus for staff: {bonus}");
        }

        public override void CalculateVacation()
        {
            int vacationWeek = 3;
            if (DateHired == 5)
            {
                vacationWeek += 1;
            }

            Console.WriteLine($"Total vacation for staff: {vacationWeek}");
        }
    }
}