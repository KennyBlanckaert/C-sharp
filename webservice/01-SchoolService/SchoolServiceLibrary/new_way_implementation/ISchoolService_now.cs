using SchoolServiceLibrary.entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SchoolServiceLibrary
{
    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface ISchoolService_now
    {
        [OperationContract]
        [WebGet(UriTemplate = "/courses")]
        List<Course> getCourses();

        [OperationContract]
        [WebGet(UriTemplate = "/students")]
        List<Student> getStudents();

        [OperationContract]
        [WebGet(UriTemplate = "/teachers")]
        List<Teacher> getTeachers();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/course/add/{name}")]
        void addCourse(string name);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/student/add/{firstname}/{lastname}")]
        void addStudent(string firstname, string lastname);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/teacher/add/{firstname}/{lastname}")]
        void addTeacher(string firstname, string lastname);
    }
}