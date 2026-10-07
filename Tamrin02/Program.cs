using Tamrin02;

Console.WriteLine("===== Tamrin 02 - Paniz Khooshani =====");
Console.WriteLine();

// Customer
Customer customer = new Customer();
customer.FirstName = "Sara";
customer.LastName = "Ahmadi";
customer.Register();
customer.PlaceOrder();
customer.Pay();
Console.WriteLine();

// Student
Student student = new Student();
student.FirstName = "Paniz";
student.LastName = "Khooshani";
student.Major = "Multimedia";
student.EnrollCourse();
student.AttendClass();
student.SubmitHomework();
Console.WriteLine();

// Teacher
Teacher teacher = new Teacher();
teacher.LastName = "Rezaei";
teacher.Field = "C# Programming";
teacher.Teach();
teacher.GiveHomework();
Console.WriteLine();

// Employee
Employee employee = new Employee();
employee.FirstName = "Reza";
employee.Position = "Designer";
employee.Salary = 30000000;
employee.CheckIn();
employee.Work();
employee.GetSalary();
Console.WriteLine();

// Rectangle
Rectangle rectangle = new Rectangle();
rectangle.Width = 5;
rectangle.Height = 3;
Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter());
rectangle.Resize(10, 4);
Console.WriteLine("New rectangle area: " + rectangle.CalculateArea());
Console.WriteLine();

// Square
Square square = new Square();
square.Side = 4;
Console.WriteLine("Square area: " + square.CalculateArea());
Console.WriteLine("Square perimeter: " + square.CalculatePerimeter());
Console.WriteLine();

// Dog
Dog dog = new Dog();
dog.Name = "Max";
dog.Bark();
dog.Run();
Console.WriteLine();

// Cat
Cat cat = new Cat();
cat.Name = "Luna";
cat.Meow();
cat.Sleep();
