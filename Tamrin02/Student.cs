namespace Tamrin02
{
    public class Student
    {
        // Properties
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double Average { get; set; }

        // Methods
        public void EnrollCourse()
        {
            Console.WriteLine(FirstName + " enrolled in a course.");
        }

        public void AttendClass()
        {
            Console.WriteLine(FirstName + " is in the class.");
        }

        public void SubmitHomework()
        {
            Console.WriteLine(FirstName + " submitted the homework.");
        }

        public void TakeExam()
        {
            Console.WriteLine(FirstName + " is taking the exam.");
        }
    }
}
