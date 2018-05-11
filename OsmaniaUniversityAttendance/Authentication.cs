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
    public partial class Authentication : Form
    {
        DBAccessor accessor = new DBAccessor();

        public Authentication()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string loginid = txtLogin.Text;
            string password = txtPassword.Text;
            string Role = cmbRole.Text;

            if(Role == "Faculty")
            {
                if (accessor.FacultyId_Exists(loginid))
                {
                   string actualpassword = accessor.getFacultyPassword(loginid);

                    if (actualpassword.Equals(password))
                    {
                            Faculty faculty = new Faculty(loginid);
                            faculty.Show();
                    }
                    else
                    {
                        MessageBox.Show("LoginID or Password is incorrect");
                        txtLogin.Text = "";
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("FacultyId does not exist");
                }
            }
            else if(Role == "Student")
            {
                if (accessor.RollNo_Exists(loginid))
                {
                    string actualpassword = accessor.getStudentPassword(loginid);

                    if (actualpassword.Equals(password))
                    {
                        Student student = new Student(loginid);
                        student.Show();
                    }
                    else
                    {
                        MessageBox.Show("LoginID or Password is incorrect");
                        txtLogin.Text = "";
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("RollNo does not exist");
                }
            }
            else if (Role == "Admin")
            {
                if (accessor.AdminId_Exists(loginid))
                {
                    string actualpassword = accessor.getAdminPassword(loginid);

                    if (actualpassword.Equals(password))
                    {
                        Admin admin = new Admin(loginid);
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("LoginID or Password is incorrect");
                        txtLogin.Text = "";
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Administrator ID does not exist");
                }
            }



        }
    }
}
