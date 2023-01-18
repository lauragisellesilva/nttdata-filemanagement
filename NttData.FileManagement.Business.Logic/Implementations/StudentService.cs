using NttData.FileManagement.Business.Logic.Contracts;
using NttData.FileManagement.Common.Model;
using NttData.FileManagement.DataAccess.Repository.Contracts;
using NttData.FileManagement.DataAccess.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.Business.Logic.Implementations
{
    public class StudentService : IStudentService
    {
        public bool Add(Student student)
        {
            bool ageIsNotEmpty = false;
            int age = GetAge(student.Birthday);

            if (age > 0)
            {
                student.Age = age;
                IStudentRepository studentRepository = new StudentRepository();
                studentRepository.Add(student);
                ageIsNotEmpty = true;
            }
            return ageIsNotEmpty;
        }

        private int GetAge(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int edad = DateTime.Today.Year - birthday.Year;
            if (DateTime.Today < birthday.AddYears(edad))
                --edad;

            return edad;
        }
    }
}
