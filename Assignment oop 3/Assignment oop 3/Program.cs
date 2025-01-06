#region MCQ  
// Question 1: What is the primary purpose of an interface in C#?
// Answer: b) To define a blueprint for a class

// Question 2: Which of the following is NOT a valid access modifier for interface members in C#?
// Answer: a) private

// Question 3: Can an interface contain fields in C#?
// Answer: b) No

// Question 4: In C#, can an interface inherit from another interface?
// Answer: b) Yes, interfaces can inherit from multiple interfaces

// Question 5: Which keyword is used to implement an interface in a class in C#?
// Answer: d) implements

// Question 6: Can an interface contain static methods in C#?
// Answer: b) No

// Question 7: In C#, can an interface have explicit access modifiers for its members?
// Answer: b) No, all members are implicitly public

// Question 8: What is the purpose of an explicit interface implementation in C#?
// Answer: a) To hide the interface members from outside access

// Question 9: In C#, can an interface have a constructor?
// Answer: b) No, interfaces cannot have constructors

// Question 10: How can a C# class implement multiple interfaces?
// Answer: c) By separating interface names with commas
#endregion


#region IShape Interface
public interface IShape
{
    double Area { get; }
    void DisplayShapeInfo();
}
#endregion

#region ICircle Interface
public interface ICircle : IShape
{
    double Radius { get; set; }
}
#endregion

#region IRectangle Interface
public interface IRectangle : IShape
{
    double Width { get; set; }
    double Height { get; set; }
}
#endregion

#region Circle Class Implementation
public class Circle : ICircle
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
    }
}
#endregion

#region Rectangle Class Implementation
public class Rectangle : IRectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area => Width * Height;

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}");
    }
}
#endregion

#region Test Implementation
public class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Enter radius for Circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter width for Rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter height for Rectangle:");
        double height = Convert.ToDouble(Console.ReadLine());

       
        ICircle circle = new Circle { Radius = radius };
        IRectangle rectangle = new Rectangle { Width = width, Height = height };

        
        circle.DisplayShapeInfo();
        rectangle.DisplayShapeInfo();
    }
}
#endregion
