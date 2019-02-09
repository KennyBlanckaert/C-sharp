using SchoolServiceLibrary.entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolServiceLibrary.database
{
    public interface ICommunication
    {
        // Select
        List<entities.Student> getStudents();
        List<entities.Teacher> getTeachers();
        List<entities.Course> getCourses();

        // Insert
        void addStudent(string firstname, string lastname);
        void addTeacher(string firstname, string lastname);
        void addCourse(string name);
    }
}
