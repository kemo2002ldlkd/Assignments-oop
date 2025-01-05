/*
 Eldemo :
namespace ProjectOOP1
{
    //NameSpace Level
    //Class Struct Enum Interface 
    //Access  Internal Public=> Default Internal
    //Struct => Structure => ValueType => Inhertance 
    //Attributes / Methods 
    //Private
    //Internal 
    //Public 
    //Class => Public Internal Private Protected PrivateProtected Internal Procted
    #region Enum
    //Labels => User Can See
    //Storage => Long/Int/Byte
    //enum Grades //--> Default 
    //{
    //    A,B,C,D,E,F
    //}
    //enum Gender
    //{
    //    M=1,Male=1,Female=2,F=2
    //}

    //enum Branches : byte
    //{
    //    dokki = 1, Maadi = 2, NasrCity = 4
    //}
    //class Employee
    //{
    //    public int id;
    //    public string name;
    //    public Gender gender;
    //}
    #endregion

    //Interface 
    //Signature for Methods //Private Public  Internal  
    //Signature for Prop 


    internal class Program
    {
       
        #region Exception Handling
        //Try Catch => Last Defence Line
        //static void DoSomeCode()
        //{
        //    try
        //    {//UnExpected
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine());
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y;

        //        int[] arr = { 1, 2, 3 };
        //        arr[100] = 90;
        //    }
        //    catch (Exception ex)//Class 
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    //Exceotion 
        //    //System Exception 
        //    //1)Format Exception
        //    //2)Index out Of Range Exception
        //    //3) Null Exception 
        //    //4) Arthamtic Exception 
        //    //Application Exception => Hardware 
        //}

        static void DoSomeProtectiveCode()
        {
           
           //UnExpected
                int x, y, z;
                bool flag= false;
                do
                {
                    flag = int.TryParse(Console.ReadLine(),out x);

                } while (!flag);

                do
                {
                    flag = int.TryParse(Console.ReadLine(), out y);

                } while (!flag || y == 0);
                z = x / y;
                //Console.WriteLine(z);

                int[] arr = { 1, 2, 3 };
                if(arr?.Length >= 100)
                {
                    arr[100] = 90;

            }


            //Exceotion 
            //System Exception 
            //1)Format Exception
            //2)Index out Of Range Exception
            //3) Null Exception 
            //4) Arthamtic Exception 
            //Application Exception => Hardware 
        }
        #endregion
        static void Main(string[] args)
        {

            #region Exception Handling
            //try
            //{
            //    DoSomeProtectiveCode();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Ay 7aga");
            #endregion

            #region Enum
            // Grades Grade = Grades.A;
            //Grades Grade =(Grades)1;//RunTime => Explicit Casting
            //Console.WriteLine(Grade);
            //if(Grade == Grades.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine(":(");
            //Employee employee = new Employee();
            //employee.id = 1;
            //employee.name = "Ahmed";
            //employee.gender = Gender.Male;//1

            //Branches branches = (Branches)3;
            #endregion

            #region Access Modifires ->C# keywords => 6 
            //Private 
            //Private Protected
            //Protected
            //Internal 
            //Internal Protected
            //Public 
            //TypeA typeA = new TypeA();  
            //typeA.x
            //typeA.x
            #endregion

            #region Struct 
            //ValueType 
            //Struct 
            //Class
            //-->Attributes => Variables
            //-->Methods [Constructor  - Getter/Setter -User Defined]
            //--->Property [Full Prop -Autamatic Prop - Indexer]
            //Point P1;//CLR Generated Object at Stack
            //P1 = new Point(3,5);//Built In
            ////Console.WriteLine(P1.z);

            //Console.WriteLine(P1.ToString());//P1
            #endregion
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Q1: Define the WeekDays enum
        #region Q1
        /*
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        Console.WriteLine("Days of the week:");
        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
        */
        #endregion

        // Q2: Define the Person struct
        #region Q2
        /*
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        Person[] persons = new Person[3];
        persons[0] = new Person("kamal", 25);
        persons[1] = new Person("kemo", 30);
        persons[2] = new Person("ahmed", 35);

        Console.WriteLine("\nDetails of persons:");
        foreach (var person in persons)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
        */
        #endregion

        // Q3: Define the Season enum and display month range
        #region Q3
        /*
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        Console.WriteLine("\nEnter a season (Spring, Summer, Autumn, Winter):");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Season season))
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid season.");
        }
        */
        #endregion

        // Q4: Add, Remove, and Check Permissions
        #region Q4
        /*
        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        Permissions userPermissions = Permissions.None;

        // Add permissions
        userPermissions |= Permissions.Read;
        userPermissions |= Permissions.Write;

        Console.WriteLine("\nCurrent Permissions: " + userPermissions);

        // Check if a specific permission exists
        if ((userPermissions & Permissions.Read) == Permissions.Read)
        {
            Console.WriteLine("Permission Read is granted.");
        }

        // Remove a permission
        userPermissions &= ~Permissions.Write;
        Console.WriteLine("Permissions after removing Write: " + userPermissions);

        // Check if a specific permission exists
        if ((userPermissions & Permissions.Write) != Permissions.Write)
        {
            Console.WriteLine("Permission Write is not granted.");
        }
        */
        #endregion

        // Q5: Create Colors enum and check if the color is primary
        #region Q5
        /*
        enum Colors
        {
            Red,
            Green,
            Blue,
            Yellow,
            Orange,
            Purple
        }

        Console.WriteLine("Enter a color (Red, Green, Blue, Yellow, Orange, Purple):");
        string colorInput = Console.ReadLine();

        if (Enum.TryParse(colorInput, true, out Colors color))
        {
            if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            {
                Console.WriteLine($"{colorInput} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{colorInput} is not a primary color.");
            }
        }
        else
        {
            Console.WriteLine("Invalid color input.");
        }
        */
        #endregion

        // Q6: Calculate distance between two points
        #region Q6
        /*
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double CalculateDistance(Point otherPoint)
            {
                return Math.Sqrt(Math.Pow(X - otherPoint.X, 2) + Math.Pow(Y - otherPoint.Y, 2));
            }
        }

        Console.WriteLine("Enter the first point (X and Y):");
        Console.Write("X: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second point (X and Y):");
        Console.Write("X: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double y2 = double.Parse(Console.ReadLine());

        Point point1 = new Point(x1, y1);
        Point point2 = new Point(x2, y2);

        double distance = point1.CalculateDistance(point2);
        Console.WriteLine($"Distance between the points: {distance}");
        */
        #endregion

        // Q7: Find the oldest person
        #region Q7
        /*
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        Person[] people = new Person[3];

        Console.WriteLine("Enter details for 3 persons:");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter name for person {i + 1}: ");
            string name = Console.ReadLine();
            Console.Write($"Enter age for person {i + 1}: ");
            int age = int.Parse(Console.ReadLine());
            people[i] = new Person(name, age);
        }

        Person oldestPerson = people[0];
        for (int i = 1; i < people.Length; i++)
        {
            if (people[i].Age > oldestPerson.Age)
            {
                oldestPerson = people[i];
            }
        }

        Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with age {oldestPerson.Age}.");
        */
        #endregion
    }
}
