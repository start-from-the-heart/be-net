namespace LibraryManagementSystem.Entity.Model.Interface
{
    public interface ITeacher
    {
        Teacher GetInformationTeacherForCertifcates(string teacher, List<Teacher> teachers);

        IEnumerable<Teacher> GetInformationTeacherByClass(string className, List<Teacher> teachers);
    }
}