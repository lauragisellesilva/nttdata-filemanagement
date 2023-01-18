using NttData.FileManagement.Common.Model;
using NttData.FileManagement.DataAccess.Repository.Contracts;
using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace NttData.FileManagement.DataAccess.Repository.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public bool Add(Student student)
        {
            string path = ConfigurationManager.AppSettings.Get("StudentFilePath");
            string createText = student.ToString() + Environment.NewLine;
            if (!File.Exists(path))
                File.WriteAllText(path, createText, Encoding.UTF8);
            else
                File.AppendAllText(path, createText, Encoding.UTF8);

            return true;
            throw new NotImplementedException();
        }
    }
}
