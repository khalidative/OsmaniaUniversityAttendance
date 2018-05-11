using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace OsmaniaUniversityAttendance
{
    public partial class Faculty : Form
    {
        public string LoginId;
        public DataSet DataSet;
        public DBAccessor accessor;
        public DBConnector Connector;

        public int SelectedClassId;
        public int SelectedRecordsClassId;
        public int AttendanceCode;
        public Boolean studentsExist = false;
        public Boolean StudentRecordsExist = false;
        public Boolean AttendanceRecordExist = false;


        public Faculty(string loginId)
        {
            InitializeComponent();
            LoginId = loginId;
            DataSet = new DataSet();
            accessor = new DBAccessor();
            Connector = new DBConnector();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;

            string date = now.GetDateTimeFormats('d')[0];

            string FacultyName = accessor.getFacultyName(LoginId);
            StatusStripLabel.Text = "Welcome " + FacultyName;

            Connector.ClassLoad(DataSet);
            Connector.AttendanceDefault(DataSet);
            Connector.AttendanceDetailDefault(DataSet);
            DataTable Class = DataSet.Tables["Class"];
            cmbClass.Items.Clear();
            cmbRecordsClass.Items.Clear();

            foreach (DataRow Row in Class.Rows)
            {

                cmbClass.Items.Add(Row["Name"]);
                cmbRecordsClass.Items.Add(Row["Name"]);
                
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;

            string SelectedClass = cmbClass.SelectedItem.ToString();
            DataRow[] result = DataSet.Tables["Class"].Select("Name = '" + SelectedClass + "'");

            SelectedClassId = Convert.ToInt32(result[0]["CLassId"]);

        }

        private void cmbRecordsClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedClass = cmbRecordsClass.SelectedItem.ToString();
            DataRow[] result = DataSet.Tables["Class"].Select("Name = '" + SelectedClass + "'");

            SelectedRecordsClassId = Convert.ToInt32(result[0]["CLassId"]);
        }

        private int generateAttendanceCode()
        {
            Random code = new Random();
            code.Next(100000000, 1000000000);

            return code.Next(100000000, 1000000000); ;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpDate.Value.Date.ToString());
            //MessageBox.Show(Convert.ToDateTime(dtpDate.Value.ToString("dd/MM/yyyy")).ToString());
            btnSave.Enabled = true;

            dataGridView1.Rows.Clear();

            if (studentsExist)
            {
                DataSet.Tables["Student"].Clear();
            }
            

            Connector.StudentLoad(DataSet,SelectedClassId.ToString());
            studentsExist = true;

            //dataGridView1.DataSource = DataSet.Tables["Student"].DefaultView;

            int i = 0;
            foreach (DataRow Row in DataSet.Tables["Student"].Rows)
            {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["RollNo"].Value = Row["RollNo"];
                dataGridView1.Rows[i].Cells["Presence"].Value = true;

                i++;

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            AttendanceCode = generateAttendanceCode();

            Attendance rec = new Attendance(AttendanceCode, SelectedClassId, 
                dtpDate.Value, Convert.ToInt32(LoginId), Convert.ToInt32(cmbPeriod.Text));

            Connector.AttendanceAdd(rec, DataSet);

            List<AttendanceDetail> details = new List<AttendanceDetail>();

            int i = 0;
            foreach (DataRow Row in DataSet.Tables["Student"].Rows)
            {
                AttendanceDetail recDetail = new AttendanceDetail(AttendanceCode, Convert.ToInt64(Row["RollNo"]), Convert.ToBoolean(dataGridView1.Rows[i].Cells["Presence"].Value));
                details.Add(recDetail);
                i++;
            }

            Connector.AttendanceDetailAdd(details, DataSet);


        }

        private void btnRecordsEnter_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            if (StudentRecordsExist)
            {
                DataSet.Tables["StudentRecords"].Clear();
            }

            Connector.StudentRecordsLoad(DataSet, SelectedClassId.ToString());
            StudentRecordsExist = true;

            if (AttendanceRecordExist)
            {
                DataSet.Tables["AttendanceRecord"].Clear();
            }

            Connector.GetAttendanceRecord(DataSet, Convert.ToInt32(LoginId), SelectedClassId);
            dataGridView3.DataSource = DataSet.Tables["AttendanceRecord"].DefaultView;

            dataGridView2.Columns.Add("Date", "Date");
            int i = 0;
            foreach (DataRow Row in DataSet.Tables["StudentRecords"].Rows)
            {

                dataGridView2.Columns.Add(Row["RollNo"].ToString(), Row["RollNo"].ToString());

                i++;

                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[i].Cells["RollNo"].Value = Row["RollNo"];
                //dataGridView1.Rows[i].Cells["Presence"].Value = true;

            }
            //DataTable Dates = DataSet.Tables["AttendanceRecord"];


            //i = 0;
            //foreach (DataRow Row in Dates.DefaultView.ToTable(true, "Date").Rows)
            //{

            //    dataGridView2.Rows.Add(Row["RollNo"].ToString(), Row["RollNo"].ToString());

            //    i++;

            //    //dataGridView1.Rows.Add();
            //    //dataGridView1.Rows[i].Cells["RollNo"].Value = Row["RollNo"];
            //    //dataGridView1.Rows[i].Cells["Presence"].Value = true;

            //}

            //int j = 0;

        }
    }
}
