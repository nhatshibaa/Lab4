using System;

namespace Part4
{
    public class Faculty : Employee
    {
        public int OfficeHour { get; set; }
        public string Rank { get; set; }
        public override void CalculateBonus()
        {
            double bonus = 1000 + 0.5 * Salary;
            Console.WriteLine($"Total bonus for faculty: {bonus}");
        }

        public override void CalculateVacation()
        {
            int vacationWeek = 4;
            if (DateHired == 3 && Rank == "Senior Lecture")
            {
                vacationWeek += 1;
            }

            Console.WriteLine($"Total vacation for faculty: {vacationWeek}");
        }
    }
}