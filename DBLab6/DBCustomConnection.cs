using System.Data.SqlClient;

namespace DBLab6
{
    public static class DBCustomConnection
    {
        private static readonly string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=EducationalDepartment;Integrated Security=True";
        private static readonly object Stub = new object();
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                lock (Stub)
                {
                    if (connection == null)
                    {
                        connection = new SqlConnection(ConnectionString);
                    }
                }
            }

            return connection;
        }
    }
}
