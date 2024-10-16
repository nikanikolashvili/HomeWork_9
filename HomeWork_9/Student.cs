using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_9
{
    internal class Student
    {
        public string Studentname { get; set; }
        public int Studentage { get; set; }
        public int Universityenrollmentyear { get; set; }
        public object DataTime { get; private set; }

        public Student(string studentname, int studentage, int universityenrollmentyear)
        {
           Studentname = studentname;
            Studentage = studentage;
            Universityenrollmentyear = universityenrollmentyear;

        }
        public int Yearleft()
        {
            
            return (Universityenrollmentyear +4) - DateTime.Now.Year;
           
        }

        public String RandomSubject()
        {

            string[] subjects = { "Mathematics", "Physics", "Chemistry", "Biology", "Literature", "History", "Computer Science" };
            Random random = new Random();
            int index = random.Next(subjects.Length);
            return subjects[index];


        }
        
        
        



    }

    
    

}
