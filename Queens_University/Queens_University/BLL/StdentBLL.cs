using Queens_University.DAL;
using Queens_University.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens_University.BLL
{
    class StdentBLL
    {
        /// <summary>
        /// Returns All Students Details in the DB
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAllStudentsDetails()
        {
            try
            {
                StudentDAL objdal = new StudentDAL();
                return objdal.GetAllStdentDetails();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Add New Student to List in the Repository
        /// </summary>
        /// <param name="student"></param>
        public void AddNewStudent(Student student)
        {
            StudentDAL objdal = new StudentDAL();
            objdal.AddNewStudentDetails(student);
        }

        /// <summary>
        /// Update the Grideview When user add new entry
        /// </summary>
        /// <returns></returns>
        public List<Student> UpdateGridView()
        {
                StudentDAL objdal = new StudentDAL();
                return objdal.AddLatestEntryToGridView();
        }

        /// <summary>
        /// Save all new Entries to DB
        /// </summary>
        /// <returns></returns>
        public bool UpdateDatabase()
        {
            StudentDAL objdal = new StudentDAL();
            return objdal.SaveToDataDatabase();
        }

       
    }
}
