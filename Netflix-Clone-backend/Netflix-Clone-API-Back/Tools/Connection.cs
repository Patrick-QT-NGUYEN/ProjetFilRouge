using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_Clone_API_Back.Tools
{
    internal class Connection
    {
        private static string connectionString = @"Data Source = (LocalDb)\Netflix-Clone.dbo; Integrated Security = True";
        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
