using System.Collections.Generic;
using System.Linq;

namespace BTVN.Models
{
    public static class StudentService
    {
        private static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static int CountBySpecialization(string chuyenNganh)
        {
            return students.Count(s => s.ChuyenNganh == chuyenNganh);
        }

        public static List<Student> GetAllStudents()
        {
            return students;
        }
    }
}