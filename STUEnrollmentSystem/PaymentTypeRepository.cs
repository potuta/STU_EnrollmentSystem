using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    internal class PaymentTypeRepository : BaseRepository
    {
        public PaymentTypeRepository(string connectionString) : base(connectionString) { }

        // Additional methods specific to PaymentTypeRepository can be added here

    }
}
