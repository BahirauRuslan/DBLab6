using System.Data;
using System.Data.SqlClient;

namespace DBLab6
{
    public class DataSetCreator
    {
        public DataSet CreateDataSet(SqlConnection connection, string command, string tableName)
        {
            var adapter = new SqlDataAdapter(command, connection);
            var dataSet = new DataSet();
            adapter.Fill(dataSet, tableName);
            return dataSet;
        }

        public void AddTableToDataSet(DataSet dataSet, SqlConnection connection, string command, string tableName)
        {
            var adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(dataSet, tableName);
        }
    }
}
