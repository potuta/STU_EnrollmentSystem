using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class SectionRepository : BaseRepository
    {
        public SectionRepository(string connectionString) : base(connectionString) { }

    }
}
