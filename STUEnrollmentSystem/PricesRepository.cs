﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUEnrollmentSystem
{
    class PricesRepository : BaseRepository
    {
        public PricesRepository(string connectionString) : base(connectionString) { }

    }
}
