using LibraryManagementSystem.Entity.Entity;
using LibraryManagementSystem.Entity.Model.Interface;

namespace LibraryManagementSystem.Entity.Model
{
    public class Teacher : User, ITeacher
    {
        public int Certifcate { get; set; }

        public string ClassName { get; set; } = string.Empty;

        public float YearsOfExperience { get; set; }

        public string Skill { get; set; } = string.Empty;

        public string RelationShip { get; set; } = string.Empty;

        public IEnumerable<Teacher> GetInformationTeacherByClass(string className, List<Teacher> teachers)
        {
            return teachers.FindAll(x => x.ClassName == className);
        }

        public Teacher GetInformationTeacherForCertifcates(string teacher, List<Teacher> teachers)
        {
            return teachers.Find(x => x.UserName.Equals(teacher)) ?? new Teacher();
        }

        public override string GetInformationUser()
        {
            return base.GetInformationUser() + $"- {ClassName} - {YearsOfExperience}";
        }
    }
}