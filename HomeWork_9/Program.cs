

using HomeWork_9;





    Console.Write("Your company type (local or foreign) :");
    String Companytype = Console.ReadLine();
    bool local = Companytype.ToLower() == "local";
    Company company = new Company(local);





    Console.Write("First Name: ");
    string firstname = Console.ReadLine();
    Console.Write("Last Name: ");
    string lastname = Console.ReadLine();
    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Position ");
    string position = Console.ReadLine();


    List<int> workedHours = new List<int>();
    Console.WriteLine("Enter the hours worked during the week: ");


    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine($"Day {i + 1} (Hours): ");
        if (int.TryParse(Console.ReadLine(), out int hours))
        {
            workedHours.Add(hours);
        }

    }

    Employee employee = new Employee(firstname, lastname, age, position, workedHours);

    double weeklySalary = employee.CalculateWeeklySalary();
    double tax = company.Calculatetax(weeklySalary);

    Console.WriteLine($"Salary: {weeklySalary} Company Tax: {tax}");


    Console.WriteLine("Student name");
    string studentname = Console.ReadLine();
    Console.WriteLine("Age: ");
    int studentage = int.Parse(Console.ReadLine());
    Console.WriteLine("University enrollmentrn year?:");
    int universityenrollmentyear = int.Parse(Console.ReadLine());



    Student student = new Student(studentname, studentage, universityenrollmentyear);
string subject = student.RandomSubject();
Teacher teacher = new Teacher("nini", true);
    
Console.WriteLine($"Years left to graduate: {student.Yearleft()}");
Console.WriteLine($"Random Subject: {subject}");
    
    teacher.evo(subject);

Console.ReadLine();

