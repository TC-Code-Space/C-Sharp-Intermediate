using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Polymorphism
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            DbCommand oracle = new DbCommand(new OracleConnection("Oracle"), "oracle command");
            DbCommand sql = new DbCommand(new SqlConnection("SQL"), "sql command");

            oracle.Execute();
            sql.Execute();
            
        }
    }
}
 