//ELdemo



//#region Encapsulation
//using EmployeeManagement;

//Employee employee = new Employee(1, "MARIAM", 10000);
//Console.WriteLine(employee);
////employee.Id = 2; //Set value of attribute directly
////Console.WriteLine(employee.Id);  //Get value of attribute directly
////employee.Salary = 3000;
////employee.Name = "Mariam"; //Invalid
////employee.SetName("Omnia Mohamed");
////Console.WriteLine(employee.GetName());

//////employee.salary = 1000; //Invalid
////employee.Salary = 3000;
////Console.WriteLine(employee);

////employee.Age = 20;
////Console.WriteLine(employee.Age);

//Console.WriteLine(employee.Deduction);

//            #endregion

//            #region Encapsulation [Setter - Getter]
//            //PhoneBook Note = new PhoneBook(3);
//            //Note.AddPerson(0, "Mariam", 123);
//            //Note.AddPerson(1, "Mona", 456);
//            //Note.AddPerson(2, "Mohamed", 789);

//            //Console.WriteLine("Before changing phoneNumber");
//            //int PhoneNumebr = Note.GetPersonPhoneNumber("Mona"); //456
//            //Console.WriteLine(PhoneNumebr == -1 ? "NotFound" : PhoneNumebr);
//            //Console.WriteLine("After changing phoneNumber");
//            //Note.SetPersonPhoneNumber("Mona", 111);
//            //PhoneNumebr = Note.GetPersonPhoneNumber("Mona"); //111
//            //Console.WriteLine(PhoneNumebr == -1 ? "NotFound" : PhoneNumebr);

//            #endregion

//            #region Encapsulation [Indexer]
//            //PhoneBook Note = new PhoneBook(3);
//            //Note.AddPerson(0, "Mariam", 123);
//            //Note.AddPerson(1, "Mona", 456);
//            //Note.AddPerson(2, "Mohamed", 789);

//            //// Note["Mariam"]; 
//            ////Note["Mariam"] = 999;
//            ////Console.WriteLine(Note["Mariam"]);

//            //for(int i = 0; i < Note.Size ; i++)
//            //{
//            //    Console.WriteLine(Note[i]);
//            //}

//            //string Name = "Mahmoud";
//            //Console.WriteLine(Name[0]);
//            //Name[0] = 'Z';


//            #endregion

//            #region Class
//            //Car C1; 
//            //Declare reference from type Car
//            //Reference can refer to an object from type Car or any object from class inhiret from type Car
//            //Clr will allocate 4 bytes in stack
//            //0 Bytes will allocate in heap

//            //C1 = new Car();
//            //New
//            //1] Allocate required bytes in heap [16 bytes]
//            //2] Intialize allocated bytes with default value of datatype
//            //3] Call user defined constructor if exist
//            //4] Assign the reference C1 to allocated object at heap

//            /// Console.WriteLine(C1);

//            //Car C1 = new Car(1, 2000, "Bmw");
//            //Console.WriteLine(C1);
//            // Console.WriteLine("*****************************");
//            //Car C2 = new Car(2, 1000);
//            //Console.WriteLine(C2);
//            //Console.WriteLine("*****************************");
//            //Car C3 = new Car(3);
//            //Console.WriteLine(C3);


//            #endregion

//            #region Inhiertance
//            //Parent P1 = new Parent(1, 2);
//            ////Console.WriteLine(P1.ToString());
//            //Console.WriteLine(P1);
//            //Console.WriteLine($"P1 Product ==> {P1.Product()}");

//            //Child C1 = new Child(3, 4, 5);
//            //Console.WriteLine(C1);
//            //Console.WriteLine($"C1 Product ==> {C1.Product()}");
//            #endregion

//            #region Access modifiers [Protected]
//            //TypeA typeA = new TypeA();
//            //typeA.X = 100; //Invalid
//            //typeA.Y = 100; //Invalid
//            //typeA.Z = 200; //Invalid
//            //typeA.M = 100; //Invalid
//            #endregion

using System;

namespace EmployeeManagement
{
    #region HiringDate Class
    // Class to represent the hiring date of an employee
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor
        public HiringDate(int day, int month, int year)
        {
            // Ensure valid date inputs
            if (day < 1 || day > 31) throw new ArgumentException("Invalid day");
            if (month < 1 || month > 12) throw new ArgumentException("Invalid month");
            if (year < 1900 || year > DateTime.Now.Year) throw new ArgumentException("Invalid year");

            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
    #endregion

    #region Employee Class
    // Enum for security levels
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    // Class to represent an employee
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private char gender;
        public char Gender
        {
            get => gender;
            set
            {
                if (value != 'M' && value != 'F')
                    throw new ArgumentException("Gender must be 'M' or 'F'");
                gender = value;
            }
        }

        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        // Constructor
        public Employee(int id, string name, char gender, SecurityLevel securityLevel, decimal salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }

        // Override ToString to display employee data
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nGender: {(Gender == 'M' ? "Male" : "Female")}\nSecurity Level: {SecurityLevel}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HireDate}";
        }
    }
    #endregion

    #region Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of employees with size 3
            Employee[] employees = new Employee[3];

            // Initialize employees
            employees[0] = new Employee(1, "khalid", 'M', SecurityLevel.DBA, 7500.50m, new HiringDate(12, 3, 2020));
            employees[1] = new Employee(2, "Arwa", 'F', SecurityLevel.Guest, 3000.75m, new HiringDate(5, 7, 2022));
            employees[2] = new Employee(3, "Kamal", 'M', SecurityLevel.SecurityOfficer, 9000.00m, new HiringDate(18, 1, 2018));

            // Display employee information
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("----------------------------------");
            }
        }
    }
    #endregion
}
