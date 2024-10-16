using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    internal class Teacher
    {
        public string Teachername {  get; set; }    
        public bool TeacherSert { get; set; }


        public Teacher(string teachername, bool teacherSert )
        {
            Teachername = teachername;
            TeacherSert = teacherSert;
        }


        public void evo(string subject)
        {


            switch (subject) 
            
            {

                case "Mathematics":
                    Random random = new Random();
                    int num1 = random.Next(1, 101);
                    int num2 = random.Next(1, 101);
                    Console.WriteLine($"Result:{num1+ num2 }");
                    break;

                case "Chemistry":
                    string[] formulas = { "H2O", "CO2", "NaCl", "C6H12O6" }; 
                    Console.WriteLine($"Chemistry Formula: {formulas[new Random().Next(formulas.Length)]}");
                    break;

                case "English":
                    
                    Console.WriteLine($"Random text in English");
                    break;

                default:
                    Console.WriteLine("I am not competent in this subject.");
                    break;









            }




        }

    }
}
