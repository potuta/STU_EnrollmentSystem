using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class SubjectsRepository : BaseRepository
    {
        public SubjectsRepository(string connectionString) : base(connectionString) { }
       
    }
}
