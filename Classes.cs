// Tamrin 02 - Paniz Khooshani
// Only properties and method names (no implementation)

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public void Register() { }
    public void PlaceOrder() { }
    public void Pay() { }
    public void CancelOrder() { }
}

public class Student
{
    public string StudentNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Major { get; set; }
    public double Average { get; set; }

    public void EnrollCourse() { }
    public void AttendClass() { }
    public void SubmitHomework() { }
    public void TakeExam() { }
}

public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Degree { get; set; }
    public string Field { get; set; }
    public double Salary { get; set; }

    public void Teach() { }
    public void TakeAttendance() { }
    public void GiveHomework() { }
    public void GradeExam() { }
}

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }

    public void CheckIn() { }
    public void Work() { }
    public void RequestLeave() { }
    public void GetSalary() { }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    public string Color { get; set; }

    public void CalculateArea() { }
    public void CalculatePerimeter() { }
    public void Resize() { }
}

public class Square
{
    public double Side { get; set; }
    public string Color { get; set; }

    public void CalculateArea() { }
    public void CalculatePerimeter() { }
    public void Resize() { }
}

public class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public double Weight { get; set; }

    public void Bark() { }
    public void Eat() { }
    public void Run() { }
    public void Sleep() { }
}

public class Cat
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public double Weight { get; set; }

    public void Meow() { }
    public void Eat() { }
    public void Sleep() { }
    public void Scratch() { }
}
