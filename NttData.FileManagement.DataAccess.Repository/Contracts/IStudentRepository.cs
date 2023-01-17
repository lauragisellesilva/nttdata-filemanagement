using NttData.FileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttData.FileManagement.DataAccess.Repository.Contracts
{
    public interface IStudentRepository
    {
        //lo ideal es que devuelva el estudiante
        bool Add(Student student);
    }
}
