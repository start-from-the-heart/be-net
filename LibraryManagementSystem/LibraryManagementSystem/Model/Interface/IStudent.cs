namespace LibraryManagementSystem.Entity.Model.Interface
{
    public interface IStudent
    {
        Student GetStudentNameLikeThat(int studentID, List<Student> students);

        int GetMaxAgeByStudent(List<Student> students);
    }
}