namespace Tamrin02
{
    public class Teacher
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Degree { get; set; }
        public string Field { get; set; }
        public double Salary { get; set; }

        // Methods
        public void Teach()
        {
            Console.WriteLine(LastName + " is teaching " + Field + ".");
        }

        public void TakeAttendance()
        {
            Console.WriteLine(LastName + " is taking attendance.");
        }

        public void GiveHomework()
        {
            Console.WriteLine(LastName + " gave a new homework.");
        }

        public void GradeExam()
        {
            Console.WriteLine(LastName + " is grading the exams.");
        }
    }
}
