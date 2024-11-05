using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class ScheduleRepository : BaseRepository
    {
        public ScheduleRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to ScheduleRepository can be added here

    }
}
