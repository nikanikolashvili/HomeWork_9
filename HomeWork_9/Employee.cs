using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    internal class Employee
    {



        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public String Position { get; set; }
        public List<int> WorkedHours { get; set; }


        public Employee(String firstname, string lastname, int age, string position, List<int> workedHours)
        {

            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Position = position;
           WorkedHours = workedHours;



        }

        private double GetHourlyRate(string position)
        {
            switch (position.ToLower())

            {

                case "manager": return 40;
                case "developer": return 30;
                case "tester": return 20;
                default: return 10;

            }



        }



        public double CalculateWeeklySalary()
        {


            double hourlyRate = GetHourlyRate(Position); 
            double totalsalary = 0;
            int totalWorkedHours = 0;
            for (int i = 0; i < WorkedHours.Count; i++)
            {
                int Hours = WorkedHours[i];
                totalWorkedHours += Hours;

                if (i == 5 || i == 6)
                {
                    totalsalary += Hours * hourlyRate * 2;

                }
                else
                {
                    totalsalary += Hours * hourlyRate;
                        if (Hours > 8) {

                        totalsalary += (Hours - 8) * 5;

                    }
                        
                        
                }


                
            }
            if (totalWorkedHours > 50) { totalsalary += totalsalary * 0.20; }
            return totalsalary;


        }

        



















        }
    }
