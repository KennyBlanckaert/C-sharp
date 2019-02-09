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
    public interface ISchoolService_old
    {
        [OperationContract]
        List<entities.Course> getCourses();

        [OperationContract]
        List<entities.Student> getStudents();

        [OperationContract]
        List<entities.Teacher> getTeachers();

        [OperationContract]
        void addCourse(string name);

        [OperationContract]
        void addStudent(string firstname, string lastname);

        [OperationContract]
        void addTeacher(string firstname, string lastname);
    }
}