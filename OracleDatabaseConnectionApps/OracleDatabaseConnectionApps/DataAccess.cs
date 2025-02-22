using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace OracleDatabaseConnectionApps
{
    public class DataAccess
    {
        private readonly string _connectionString;

        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                var command = new OracleCommand(query, connection);
                var adapter = new OracleDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
    
