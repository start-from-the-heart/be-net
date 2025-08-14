using LibraryManagementSystem.Entity.Helper;
using LibraryManagementSystem.Entity.Model;
using LibraryManagementSystem.Entity.Model.Interface;

namespace LibraryManagementSystem.Display
{
    public class Program
    {
        private readonly IStudent _student;

        public Program(IStudent student)
        {
            _student = student;
        }

        private static void Main(string[] args)
        {
            var listStudent = new List<Student>()
            {
                new Student(20251418001,"hoangnv34","hoangnvtes@gmail.com","ASdfk12@", "085445211", "1,2,3,4,5", 1,"12A", 14, 1),
                new Student(20251418002,"quannt24","quannt24@gmail.com","ASdfk12@", "1232141", "1,4,2", 2,"12A", 14, 1),
                new Student(20251418003,"quangnv115","quangnv115@gmail.com","ASdfk12@", "234524", "5,6,7", 3,"12A", 14, 1),
                new Student(20251418004,"huytq11","huytq11@gmail.com","ASdfk12@", "324567254", "1,3,2", 3,"12A", 14, 1),
                new Student(20251418005,"hoangnv34","hoangnv34@gmail.com","ASdfk12@", "32141234", "", 3,"12A", 14, 1)
            };

            //var listTeacher = new List<Teacher>()
            //{
            //    new Teacher(1,"AnhTTMl3","AnhTTMl3@gmail.com", "dsafas123@","02564546","1,2,3,4,5",5,2, "12A", 8, "Math", "Single"),
            //    new Teacher(2,"QuyT12","QuyT12@gmail.com", "dsafas123@","1234","1,3,4",5,2, "12A", 3, "Math", "Single"),
            //    new Teacher(3,"HungLM12","HungLM12@gmail.com", "dsafas123@","12321","2,3,6",5,2, "12A", 2, "Math", "Single"),
            //    new Teacher(4,"NAMHH1","NAMHH1@gmail.com", "dsafas123@","12312","4,8,7",5,2, "12A", 1, "Math", "Single"),
            //    new Teacher(5,"TrongTT98","TrongTT98@gmail.com", "dsafas123@","123","4,6,7",5,2, "12A", 6, "Math", "Single"),
            //};

            //var listRole = new List<Role>()
            //{
            //    new Role
            //    {
            //        RoleID = 1,
            //        RoleName = "Captain",
            //        ParentRole = 5
            //    },
            //    new Role
            //    {
            //        RoleID = 2,
            //        RoleName = "Deputy Class",
            //        ParentRole = 5
            //    },
            //    new Role
            //    {
            //        RoleID = 3,
            //        RoleName = "Normal Student",
            //        ParentRole = 5
            //    },
            //    new Role
            //    {
            //        RoleID = 5,
            //        RoleName = "Deputy Class",
            //        ParentRole = 5
            //    },
            //};

            //var listBookStore = new List<Book>()
            //{
            //    new Book(1,"Hally Porter","Nam Cao", 1999,2000000,"11"),
            //    new Book(2,"Lean Rich","Will", 2001,502445,"12"),
            //    new Book(3,"Think Rich","Harry", 2006,652145,"13"),
            //    new Book(4,"Father Rich or Father Poor","Cuong Toi", 2015,32541,"3"),
            //    new Book(5,"Life cycle of SamSung","Park Seo Jon", 1256,256456,"1"),
            //    new Book(6,"Story of my life","Khanh Sky", 2014,152214,"2"),
            //    new Book(7,"Who is set of your river?","Kim Mi So", 2020,2215564,"4"),
            //};

            //// Q1: Get danh sach hoc sinh muon sach

            //var listStudentReadBook = new Dictionary<long, string>();

            //foreach (var student in listStudent)
            //{
            //    listStudentReadBook.Add(student.UserID, student.BorrowedBooks);
            //}

            //// Q2 vi du ve hastable

            //var getListStudentOtherName = new Hashtable();
            //foreach (var student in listStudent)
            //{
            //    getListStudentOtherName.Add(student.UserID, student.UserName);
            //}

            //// Display item
            //foreach (var student in listStudent)
            //{
            //    Console.WriteLine(student.GetInformationUser());
            //}

            // Demo File

            string fileName = "FileInformation" + "/" + "FileTest.txt";

            string directory = Directory.GetCurrentDirectory();

            if (!string.IsNullOrEmpty(directory))
            {
                string projectDir = Directory.GetParent(directory).Parent.Parent.FullName;

                string targetPath = Path.Combine(projectDir, fileName);

                //TextFileManager.WriteToFile(targetPath, "File is create");

                //TextFileManager.AppendToFile(targetPath, listStudent[0].GetInformationUser());

                string contentFile = TextFileManager.ReadFromFile(targetPath);

                Console.WriteLine(contentFile);
            }
        }
    }
}