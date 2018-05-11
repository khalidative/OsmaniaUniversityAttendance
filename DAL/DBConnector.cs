using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBConnector
    {

        public SqlConnection FacultyConnection;
        public SqlCommand FacultyCommand;
        public SqlDataAdapter FacultyAdapter;

        public SqlConnection StudentConnection;
        public SqlCommand StudentCommand;
        public SqlDataAdapter StudentAdapter;

        public SqlConnection ClassConnection;
        public SqlCommand ClassCommand;
        public SqlDataAdapter ClassAdapter;

        public SqlConnection AttendanceConnection;
        public SqlCommand AttendanceCommand;
        public SqlDataAdapter AttendanceAdapter;

        public SqlConnection AttendanceDetailConnection;
        public SqlCommand AttendanceDetailCommand;
        public SqlDataAdapter AttendanceDetailAdapter;


        public DBConnector()
        {
            string connectionString = "Data Source=osmaniauniversity.database.windows.net;Initial Catalog=osmaniauniversity;Persist Security Info=True;User ID=khalid;Password=99%isnotenough";

            //Faculty
            FacultyConnection = new SqlConnection(connectionString);
            FacultyConnection.Open();
            FacultyCommand = new SqlCommand();
            FacultyCommand.Connection = FacultyConnection;
            FacultyCommand.CommandText = "select * from Faculty";
            FacultyAdapter = new SqlDataAdapter();
            FacultyAdapter.SelectCommand = FacultyCommand;
            //Faculty_InitializeCommands();

            //Student
            StudentConnection = new SqlConnection(connectionString);
            StudentConnection.Open();
            StudentCommand = new SqlCommand();
            StudentCommand.Connection = StudentConnection;
            StudentCommand.CommandText = "select * from Student";
            StudentAdapter = new SqlDataAdapter();
            StudentAdapter.SelectCommand = StudentCommand;
            //Student_InitializeCommands();

            //Class
            ClassConnection = new SqlConnection(connectionString);
            ClassConnection.Open();
            ClassCommand = new SqlCommand();
            ClassCommand.Connection = ClassConnection;
            ClassCommand.CommandText = "select * from Class";
            ClassAdapter = new SqlDataAdapter();
            ClassAdapter.SelectCommand = ClassCommand;
            //Class_InitializeCommands();

            //Attendance
            AttendanceConnection = new SqlConnection(connectionString);
            AttendanceConnection.Open();
            AttendanceCommand = new SqlCommand();
            AttendanceCommand.Connection = AttendanceConnection;
            AttendanceCommand.CommandText = "select * from Attendance";
            AttendanceAdapter = new SqlDataAdapter();
            AttendanceAdapter.SelectCommand = AttendanceCommand;
            Attendance_InitializeCommands();

            //AttendanceDetail
            AttendanceDetailConnection = new SqlConnection(connectionString);
            AttendanceDetailConnection.Open();
            AttendanceDetailCommand = new SqlCommand();
            AttendanceDetailCommand.Connection = AttendanceDetailConnection;
            AttendanceDetailCommand.CommandText = "select * from AttendanceDetail";
            AttendanceDetailAdapter = new SqlDataAdapter();
            AttendanceDetailAdapter.SelectCommand = AttendanceDetailCommand;
            AttendanceDetail_InitializeCommands();

        }

        public void AddParms(SqlCommand cmd, params string[] cols)
        {
            foreach (string column in cols)
            {
                cmd.Parameters.Add("@" + column, SqlDbType.Char, 0, column);
            }
        }

        public void Attendance_InitializeCommands()
        {
            AttendanceAdapter.InsertCommand = AttendanceConnection.CreateCommand();
            AttendanceAdapter.InsertCommand.CommandText = "Insert into Attendance(AttendanceCode, ClassId, Date, FacultyId, Period) values(@AttendanceCode, @ClassId, @Date, @FacultyId, @Period)";
            AddParms(AttendanceAdapter.InsertCommand, "AttendanceCode", "ClassId", "Date", "FacultyId", "Period");

            AttendanceAdapter.UpdateCommand = AttendanceConnection.CreateCommand();
        }

        public void AttendanceDetail_InitializeCommands()
        {
            AttendanceDetailAdapter.InsertCommand = AttendanceDetailConnection.CreateCommand();
            AttendanceDetailAdapter.InsertCommand.CommandText = "Insert into AttendanceDetail(AttendanceCode, RollNo, Presence) values(@AttendanceCode, @RollNo, @Presence)";
            AddParms(AttendanceDetailAdapter.InsertCommand, "AttendanceCode", "RollNo", "Presence");

            AttendanceDetailAdapter.UpdateCommand = AttendanceDetailConnection.CreateCommand();
        }

        public void FacultyLoad(DataSet DataSet)
        {

            this.FacultyAdapter.Fill(DataSet, "Faculty");

        }

        public void StudentLoad(DataSet DataSet,string ClassId)
        {
            StudentCommand.CommandText = "select * from Student where ClassId = " + ClassId ;
            StudentAdapter.SelectCommand = StudentCommand;

            this.StudentAdapter.Fill(DataSet, "Student");

        }

        public void StudentRecordsLoad(DataSet DataSet, string ClassId)
        {
            StudentCommand.CommandText = "select * from Student where ClassId = " + ClassId;
            StudentAdapter.SelectCommand = StudentCommand;

            this.StudentAdapter.Fill(DataSet, "StudentRecords");

        }

        public void ClassLoad(DataSet DataSet)
        {

            this.ClassAdapter.Fill(DataSet, "Class");

        }

        public void AttendanceDefault(DataSet DataSet)
        {
            AttendanceCommand.CommandText = "select * from Attendance where AttendanceCode = 0";
            AttendanceAdapter.SelectCommand = AttendanceCommand;

            this.AttendanceAdapter.Fill(DataSet, "Attendance");

        }

        public void GetAttendanceRecord(DataSet DataSet,int FacultyId,int ClassId)
        {
            AttendanceCommand.CommandText = "select rec.AttendanceCode,rec.Date,rec.FacultyId,rec.ClassId,rec.Period,recDetail.RollNo,recDetail.Presence from Attendance as rec Inner Join AttendanceDetail as recDetail on rec.AttendanceCode=recDetail.AttendanceCode where rec.FacultyId = " + FacultyId.ToString() + " and rec.ClassId = " + ClassId.ToString() + " order by rec.Date asc ";
            AttendanceAdapter.SelectCommand = AttendanceCommand;

            this.AttendanceAdapter.Fill(DataSet, "AttendanceRecord");

        }

        public void AttendanceDetailDefault(DataSet DataSet)
        {
            AttendanceDetailCommand.CommandText = "select * from AttendanceDetail where AttendanceCode = 0";
            AttendanceDetailAdapter.SelectCommand = AttendanceDetailCommand;

            this.AttendanceDetailAdapter.Fill(DataSet, "AttendanceDetail");

        }

        public void AttendanceAdd(Attendance rec, DataSet dataset)
        {
            DataTable dataTable = dataset.Tables["Attendance"];
            DataRow newRow = dataTable.NewRow();
            
            newRow["AttendanceCode"] = rec.AttendanceCode;
            newRow["ClassId"] = rec.ClassId;
            newRow["Date"] = rec.Date;
            newRow["FacultyId"] = rec.FacultyId;
            newRow["Period"] = rec.Period;

            dataTable.Rows.Add(newRow);
            this.AttendanceAdapter.Update(dataset, "Attendance");
            dataset.AcceptChanges();


        }

        public void AttendanceDetailAdd(List<AttendanceDetail> details, DataSet dataset)
        {
            DataTable dataTable = dataset.Tables["AttendanceDetail"];
            
            foreach(AttendanceDetail detail in details)
            {
                DataRow newRow = dataTable.NewRow();

                newRow["AttendanceCode"] = detail.AttendanceCode;
                newRow["RollNo"] = detail.RollNo;
                newRow["Presence"] = detail.Presence;

                dataTable.Rows.Add(newRow);
            }
            
            this.AttendanceDetailAdapter.Update(dataset, "AttendanceDetail");
            dataset.AcceptChanges();


        }

    }
}
