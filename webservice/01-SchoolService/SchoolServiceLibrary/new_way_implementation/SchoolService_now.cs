using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolServiceLibrary
{
    public class SchoolService_now : ISchoolService_now
    {
        public void addCourse(string name)
        {
            using (schoolEntities db = new schoolEntities())
            {
                Course c = new Course { name = name };
                db.courses.Add(c);
                db.SaveChanges();
            }
        }

        public void addStudent(string firstname, string lastname)
        {
            using (schoolEntities db = new schoolEntities())
            {
                Student s = new Student { firstname = firstname, lastname = lastname };
                db.students.Add(s);
                db.SaveChanges();
            }
        }

        public void addTeacher(string firstname, string lastname)
        {
            using (schoolEntities db = new schoolEntities())
            {
                Teacher t = new Teacher { firstname = firstname, lastname = lastname };
                db.teachers.Add(t);
                db.SaveChanges();
            }
        }

        public List<Course> getCourses()
        {
            using (schoolEntities db = new schoolEntities())
            {
                return db.courses.ToList();
            }
        }

        public List<Student> getStudents()
        {
            using (schoolEntities db = new schoolEntities())
            {
                return db.students.ToList();
            }
        }

        public List<Teacher> getTeachers()
        {
            using (schoolEntities db = new schoolEntities())
            {
                return db.teachers.ToList();
            }
        }
    }
}
