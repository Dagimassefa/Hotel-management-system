
namespace Project
{
    partial class DashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCourseRegistration = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCoustomerDetail = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutTheHotel1 = new Project.All_User_Control.AboutTheHotel();
            this.availableRooms1 = new Project.All_User_Control.AvailableRooms();
            this.userRegistrationInformation1 = new Project.All_User_Control.UserRegistrationInformation();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnCourseRegistration);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCoustomerDetail);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Location = new System.Drawing.Point(153, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 104);
            this.panel1.TabIndex = 1;
            // 
            // btnCourseRegistration
            // 
            this.btnCourseRegistration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseRegistration.Location = new System.Drawing.Point(12, 9);
            this.btnCourseRegistration.Name = "btnCourseRegistration";
            this.btnCourseRegistration.Size = new System.Drawing.Size(232, 85);
            this.btnCourseRegistration.TabIndex = 4;
            this.btnCourseRegistration.Text = "Information";
            this.btnCourseRegistration.UseVisualStyleBackColor = true;
            this.btnCourseRegistration.Click += new System.EventHandler(this.btnCourseRegistration_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(260, 9);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(232, 85);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Avaliable Rooms";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCoustomerDetail
            // 
            this.btnCoustomerDetail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoustomerDetail.Location = new System.Drawing.Point(498, 9);
            this.btnCoustomerDetail.Name = "btnCoustomerDetail";
            this.btnCoustomerDetail.Size = new System.Drawing.Size(232, 85);
            this.btnCoustomerDetail.TabIndex = 2;
            this.btnCoustomerDetail.Text = "About";
            this.btnCoustomerDetail.UseVisualStyleBackColor = true;
            this.btnCoustomerDetail.Click += new System.EventHandler(this.btnCoustomerDetail_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(736, 9);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(232, 85);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Logout";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Red;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(68, 76);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 38);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(68, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.aboutTheHotel1);
            this.panel2.Controls.Add(this.availableRooms1);
            this.panel2.Controls.Add(this.userRegistrationInformation1);
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 360);
            this.panel2.TabIndex = 13;
            // 
            // aboutTheHotel1
            // 
            this.aboutTheHotel1.Location = new System.Drawing.Point(0, 2);
            this.aboutTheHotel1.Name = "aboutTheHotel1";
            this.aboutTheHotel1.Size = new System.Drawing.Size(1226, 358);
            this.aboutTheHotel1.TabIndex = 2;
            // 
            // availableRooms1
            // 
            this.availableRooms1.Location = new System.Drawing.Point(0, -2);
            this.availableRooms1.Name = "availableRooms1";
            this.availableRooms1.Size = new System.Drawing.Size(1226, 362);
            this.availableRooms1.TabIndex = 1;
            // 
            // userRegistrationInformation1
            // 
            this.userRegistrationInformation1.Location = new System.Drawing.Point(0, 3);
            this.userRegistrationInformation1.Name = "userRegistrationInformation1";
            this.userRegistrationInformation1.Size = new System.Drawing.Size(1226, 357);
            this.userRegistrationInformation1.TabIndex = 0;
            // 
            // DashboardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardUser";
            this.Text = "DashboardUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCourseRegistration;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCoustomerDetail;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private All_User_Control.UserRegistrationInformation userRegistrationInformation1;
        private All_User_Control.AvailableRooms availableRooms1;
        private All_User_Control.AboutTheHotel aboutTheHotel1;
    }
}