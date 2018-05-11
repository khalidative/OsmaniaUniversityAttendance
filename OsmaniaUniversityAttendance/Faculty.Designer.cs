namespace OsmaniaUniversityAttendance
{
    partial class Faculty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTakeAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAttendance = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageRecords = new System.Windows.Forms.TabPage();
            this.btnRecordsEnter = new System.Windows.Forms.Button();
            this.cmbRecordsClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageDemo = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAttendance.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageDemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTakeAttendance,
            this.MenuItemRecords,
            this.MenuItemExit});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // MenuItemTakeAttendance
            // 
            this.MenuItemTakeAttendance.Name = "MenuItemTakeAttendance";
            this.MenuItemTakeAttendance.Size = new System.Drawing.Size(163, 22);
            this.MenuItemTakeAttendance.Text = "&Take Attendance";
            // 
            // MenuItemRecords
            // 
            this.MenuItemRecords.Name = "MenuItemRecords";
            this.MenuItemRecords.Size = new System.Drawing.Size(163, 22);
            this.MenuItemRecords.Text = "&Records";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(163, 22);
            this.MenuItemExit.Text = "&Exit";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 406);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(649, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(16, 17);
            this.StatusStripLabel.Text = "   ";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAttendance);
            this.tabControl.Controls.Add(this.tabPageRecords);
            this.tabControl.Controls.Add(this.tabPageDemo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(649, 382);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageAttendance
            // 
            this.tabPageAttendance.Controls.Add(this.groupBox2);
            this.tabPageAttendance.Controls.Add(this.groupBox1);
            this.tabPageAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabPageAttendance.Name = "tabPageAttendance";
            this.tabPageAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttendance.Size = new System.Drawing.Size(641, 356);
            this.tabPageAttendance.TabIndex = 0;
            this.tabPageAttendance.Text = "Take Attendance";
            this.tabPageAttendance.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.cmbPeriod);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.lblPeriod);
            this.groupBox2.Controls.Add(this.lblClass);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnEnter);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(339, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(84, 75);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 20);
            this.dtpDate.TabIndex = 15;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbPeriod.Location = new System.Drawing.Point(84, 117);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(190, 21);
            this.cmbPeriod.TabIndex = 14;
            this.cmbPeriod.Text = "1";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(84, 39);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(190, 21);
            this.cmbClass.TabIndex = 13;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(17, 81);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 12;
            this.Date.Text = "Date";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(17, 120);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(37, 13);
            this.lblPeriod.TabIndex = 11;
            this.lblPeriod.Text = "Period";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(17, 42);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "Class";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(2, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(221, 288);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Sheet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RollNo,
            this.Presence});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "Roll Number";
            this.RollNo.Name = "RollNo";
            this.RollNo.ReadOnly = true;
            this.RollNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RollNo.Width = 170;
            // 
            // Presence
            // 
            this.Presence.HeaderText = "Presence";
            this.Presence.Name = "Presence";
            this.Presence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Presence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Presence.Width = 90;
            // 
            // tabPageRecords
            // 
            this.tabPageRecords.Controls.Add(this.btnRecordsEnter);
            this.tabPageRecords.Controls.Add(this.cmbRecordsClass);
            this.tabPageRecords.Controls.Add(this.label1);
            this.tabPageRecords.Controls.Add(this.dataGridView2);
            this.tabPageRecords.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecords.Name = "tabPageRecords";
            this.tabPageRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecords.Size = new System.Drawing.Size(641, 356);
            this.tabPageRecords.TabIndex = 1;
            this.tabPageRecords.Text = "Attendance Records";
            this.tabPageRecords.UseVisualStyleBackColor = true;
            // 
            // btnRecordsEnter
            // 
            this.btnRecordsEnter.Location = new System.Drawing.Point(511, 17);
            this.btnRecordsEnter.Name = "btnRecordsEnter";
            this.btnRecordsEnter.Size = new System.Drawing.Size(122, 23);
            this.btnRecordsEnter.TabIndex = 8;
            this.btnRecordsEnter.Text = "Enter";
            this.btnRecordsEnter.UseVisualStyleBackColor = true;
            this.btnRecordsEnter.Click += new System.EventHandler(this.btnRecordsEnter_Click);
            // 
            // cmbRecordsClass
            // 
            this.cmbRecordsClass.FormattingEnabled = true;
            this.cmbRecordsClass.Location = new System.Drawing.Point(300, 17);
            this.cmbRecordsClass.Name = "cmbRecordsClass";
            this.cmbRecordsClass.Size = new System.Drawing.Size(190, 21);
            this.cmbRecordsClass.TabIndex = 7;
            this.cmbRecordsClass.SelectedIndexChanged += new System.EventHandler(this.cmbRecordsClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Class";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(635, 300);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPageDemo
            // 
            this.tabPageDemo.Controls.Add(this.dataGridView3);
            this.tabPageDemo.Location = new System.Drawing.Point(4, 22);
            this.tabPageDemo.Name = "tabPageDemo";
            this.tabPageDemo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDemo.Size = new System.Drawing.Size(641, 356);
            this.tabPageDemo.TabIndex = 2;
            this.tabPageDemo.Text = "Demo";
            this.tabPageDemo.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(635, 350);
            this.dataGridView3.TabIndex = 0;
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 428);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Faculty";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.Faculty_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageAttendance.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageRecords.ResumeLayout(false);
            this.tabPageRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageDemo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTakeAttendance;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRecords;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAttendance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageRecords;
        private System.Windows.Forms.ComboBox cmbRecordsClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Presence;
        private System.Windows.Forms.Button btnRecordsEnter;
        private System.Windows.Forms.TabPage tabPageDemo;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}