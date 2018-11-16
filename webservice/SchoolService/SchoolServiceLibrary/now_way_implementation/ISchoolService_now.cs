using SchoolServiceLibrary.entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SchoolServiceLibrary
{
    [ServiceContract]
    public interface ISchoolService_now
    {
        [OperationContract]
        List<Course> getCourses();

        [OperationContract]
        List<Student> getStudents();

        [OperationContract]
        List<Teacher> getTeachers();

        [OperationContract]
        void addCourse(string name);

        [OperationContract]
        void addStudent(string firstname, string lastname);

        [OperationContract]
        void addTeacher(string firstname, string lastname);
    }
}