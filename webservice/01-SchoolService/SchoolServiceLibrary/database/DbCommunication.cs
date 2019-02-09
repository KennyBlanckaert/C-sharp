using MySql.Data.MySqlClient;
using SchoolServiceLibrary.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolServiceLibrary.database
{
    public class DbCommunication : ICommunication
    {
        // Fields
        private DatabaseConfig config;
        private MySqlConnection connection;

        // Constructor
        public DbCommunication(string user, string password, string database)
        {
            config = DatabaseConfig.getInstance();
            config.User = user;
            config.Password = password;
            config.Database = database;
        }

        // Connect 
        public bool Connect()
        {
            if(config.Connect())
            {
                connection = config.MySQLConnection();
                return true;
            }

            return false;
        }

        // Queries
        public List<entities.Course> getCourses()
        {
            List<entities.Course> courses = new List<entities.Course>();

            string query = "SELECT * FROM courses";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                courses.Add(new entities.Course { ID = reader.GetInt32(0), Name = reader.GetString(1) });
            }
            reader.Close();

            return courses;
        }

        public List<entities.Student> getStudents()
        {
            List<entities.Student> students = new List<entities.Student>();

            string query = "SELECT * FROM students";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new entities.Student { ID = reader.GetInt32(0), FirstName = reader.GetString(1), LastName = reader.GetString(2) });
            }
            reader.Close();

            return students;
        }

        public List<entities.Teacher> getTeachers()
        {
            List<entities.Teacher> teachers = new List<entities.Teacher>();

            string query = "SELECT * FROM teachers";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                teachers.Add(new entities.Teacher { ID = reader.GetInt32(0), FirstName = reader.GetString(1), LastName = reader.GetString(2) });
            }
            reader.Close();

            return teachers;
        }

        public void addCourse(string name)
        {
            string query = "INSERT INTO courses (name) VALUES (@name)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Prepare();
            command.ExecuteNonQuery();
        }

        public void addStudent(string firstname, string lastname)
        {
            string query = "INSERT INTO students (firstname, lastname) VALUES (@firstname, @lastname)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Prepare();
            command.ExecuteNonQuery();
        }

        public void addTeacher(string firstname, string lastname)
        {
            string query = "INSERT INTO courses (firstname, lastname) VALUES (@firstname, @lastname)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Prepare();
            command.ExecuteNonQuery();
        }
    }
}
