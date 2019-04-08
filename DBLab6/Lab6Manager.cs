using System.Data;

namespace DBLab6
{
    public class Lab6Manager
    {
        private DataSetCreator _creator = new DataSetCreator();

        public void SetFilterToDataView(DataView dataView, string filter)
        {
            dataView.RowFilter = filter;
        }

        public void SetSortToDataView(DataView dataView, string sort)
        {
            dataView.Sort = sort;
        }

        public DataView GetViewTable()
        {
            return new DataView(GetTable().Tables["Students"]);
        }

        public DataView GetViewTableWithCalculatedColumn()
        {
            var dataSet = GetTable();
            AddTable(dataSet);
            var relation = new DataRelation(
                "StudMarks",
                dataSet.Tables["Students"].Columns["Id"],
                dataSet.Tables["MarkRecords"].Columns["StudentId"]);
            dataSet.Relations.Add(relation);
            var count = new DataColumn(
             "Кол-во оценок", 
             typeof(int), 
             "COUNT(Child(StudMarks).StudentId)");
            dataSet.Tables["Students"].Columns.Add(count);
            return new DataView(dataSet.Tables["Students"]);
        }

        public void AddTable(DataSet dataSet)
        {
            _creator.AddTableToDataSet(
                dataSet,
                DBCustomConnection.GetConnection(),
                "SELECT Id, StudentId FROM MarkRecords", 
                "MarkRecords");
        }

        public DataSet GetTable()
        {
            return _creator.CreateDataSet(
                DBCustomConnection.GetConnection(),
                "SELECT Students.Id, FullName, Number FROM Students JOIN Groups ON Students.GroupId = Groups.Id", 
                "Students");
        }
    }
}
