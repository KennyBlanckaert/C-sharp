using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SchoolServiceLibrary.database;
using SchoolServiceLibrary.entities;

namespace SchoolServiceLibrary
{
    public class SchoolService_old : ISchoolService_old
    {
        // Fields
        private DbCommunication database;

        // Constructor
        public SchoolService_old()
        {
            database = new DbCommunication("Kenny", "Azerty123", "School");
            if (!database.Connect()) { throw new CommunicationException("Could not connect to database"); }
        }

        public void addCourse(string name)
        {
            database.addCourse(name);
        }

        public void addStudent(string firstname, string lastname)
        {
            database.addStudent(firstname, lastname);
        }

        public void addTeacher(string firstname, string lastname)
        {
            database.addTeacher(firstname, lastname);
        }

        public List<entities.Course> getCourses()
        {
            return database.getCourses();
        }

        public List<entities.Student> getStudents()
        {
            return database.getStudents();
        }

        public List<entities.Teacher> getTeachers()
        {
            return database.getTeachers();
        }
    }
}
