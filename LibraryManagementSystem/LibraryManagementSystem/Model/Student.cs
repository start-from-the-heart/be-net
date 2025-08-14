using LibraryManagementSystem.Entity.Entity;
using LibraryManagementSystem.Entity.Model.Interface;

namespace LibraryManagementSystem.Entity.Model
{
    public class Student : User, IStudent
    {
        public string ClassName { get; set; } = string.Empty;

        public int Age { get; set; }

        public int ManagementOfTeacher { get; set; }

        public Student()
        { }

        public Student(long userID, string userName, string email,
                       string password, string phoneNumber, string borrowedBooks,
                       long roleID, string className, int age,
                       int managementOfTeacher) : base(userID, userName, email, password, phoneNumber, borrowedBooks, roleID)
        {
            ClassName = className;
            Age = age;
            ManagementOfTeacher = managementOfTeacher;
        }

        public int GetMaxAgeByStudent(List<Student> students)
        {
            return students.Max(x => x.Age);
        }

        public Student GetStudentNameLikeThat(int studentID, List<Student> students)
        {
            return students.Find(x => x.UserID.Equals(studentID)) ?? new Student();
        }

        public override string GetInformationUser()
        {
            return base.GetInformationUser() + $" - {Age}";
        }
    }
}