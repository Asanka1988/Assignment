using Queens_University.Exceptions;
using Queens_University.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens_University.DAL.Repositories
{
    public class StudentDetailsRepository : IStudentDetailsRepository
    {
        SqlConnection con = DBConnection.GetInstance().GetDBConnection();
        List<Student> StudentList = new List<Student>();

        internal static List<Student> CacheStudentList = new List<Student>();
        Student student;

        public List<Student> GetAllStudentDetails()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SelectAllStdents", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        student = new Student();
                        student.StudentId = int.Parse(rd["StudentId"].ToString());
                        student.Name = rd["Name"].ToString();
                        student.DateOfBirth = DateTime.Parse(rd["DOB"].ToString());
                        student.Average = double.Parse(rd["GradePointAvg"].ToString());
                        student.IsActive = bool.Parse(rd["Active"].ToString());
                        StudentList.Add(student);
                    }
                    CacheStudentList = StudentList;
                    return StudentList;
                }
            }
            catch (CustomizeSqlException ex)
            {
                throw new ConfigurationSettingException(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void AddNewStudent(Student student)
        {
            int lastStuId = CacheStudentList.OrderBy(a => a.StudentId).Select(s => s.StudentId).LastOrDefault();
            student.StudentId = lastStuId + 1;
            CacheStudentList.Add(student);
        }

        public List<Student> TemararyUpDateGridView()
        {
            return CacheStudentList.OrderByDescending(a => a.StudentId).ToList();
        }

        public bool UpDateDataBase()
        {
            try
            {
                foreach (var item in CacheStudentList)
                {
                    using (SqlCommand cmd = new SqlCommand("InsertOrUpdateStudent", con))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = item.StudentId;
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = item.Name;
                        cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = item.DateOfBirth;
                        cmd.Parameters.Add("@Average", SqlDbType.Float).Value = item.Average;
                        cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = item.IsActive;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }

                }
                return true;
            }
            catch (CustomizeSqlException ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
