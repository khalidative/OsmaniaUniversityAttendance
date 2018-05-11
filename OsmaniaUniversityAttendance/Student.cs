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
    public partial class Student : Form
    {

        public string LoginId;
        DBAccessor accessor = new DBAccessor();

        public Student(string loginId)
        {
            InitializeComponent();
            LoginId = loginId;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            string userName = accessor.getStudentName(LoginId);
            StatusStripLabel.Text = "Welcome " + userName;
        }
    }
}
