using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal interface IConnectionRepository
    {
        void OpenConnection();
        void CloseConnection();
        string GetConnectionString();
    }
}
