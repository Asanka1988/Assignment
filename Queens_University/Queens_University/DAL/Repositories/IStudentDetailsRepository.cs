using Queens_University.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens_University.DAL.Repositories
{
    public interface IStudentDetailsRepository
    {
        List<Student> GetAllStudentDetails();

        void AddNewStudent(Student stdent);

        bool UpDateDataBase();
    }
}
