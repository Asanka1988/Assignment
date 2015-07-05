using Queens_University.Models;
using Queens_University.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens_University.DAL
{
    class StudentDAL
    {
        SqlConnection con = DBConnection.GetInstance().GetDBConnection();

        StudentDetailsRepository objStudentDetailsRepository = new StudentDetailsRepository();

        /// <summary>
        /// Get All Saved Student Details From Repository
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAllStdentDetails()
        {
            return objStudentDetailsRepository.GetAllStudentDetails();
        }

        /// <summary>
        /// Add New Entry to List in Repository
        /// </summary>
        /// <param name="student"></param>
        public void AddNewStudentDetails(Student student)
        {
            objStudentDetailsRepository.AddNewStudent(student);
        }

        /// <summary>
        /// Pass Newly Added Entry to Business Layer
        /// </summary>
        /// <returns></returns>
        public List<Student> AddLatestEntryToGridView()
        {
            return objStudentDetailsRepository.TemararyUpDateGridView();
        }

        /// <summary>
        /// Save All newly Added Entries to DB
        /// </summary>
        /// <returns></returns>
        public bool SaveToDataDatabase()
        {
           return objStudentDetailsRepository.UpDateDataBase();
            
        }

        
    }
}
