using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 //შექმენით კომპანიის კლასი(Company) რომელსაც აქვს 1 პარამეტრი რომელიც
//განსაზღვრავს ადგილობრივი კომპანიაა თუ უცხოური ასევე ერთი მეთოდი რომელიც
//ამოწმებს თუ ადგილობრივი კომპანია მაშინ ჯამურად გადახდილი თანხის 18 %
//გადაირიცხება ბიუჯეტში თუ უცხოური კომპანიაა მაშინ 5%
*/



namespace HomeWork_9
{
    internal class Company
    {
        public bool Local  { get; set; }
        public Company(bool local)
        {
            Local = local;

        }

        public double Calculatetax (double totalSalary)
        {
            if (Local) { return totalSalary * 0.18; }
            else { return totalSalary * 0.05; } 
        }
    }


}
