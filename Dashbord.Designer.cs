
namespace Project
{
    partial class Dashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Movingpanel = new System.Windows.Forms.Panel();
            this.btnCourseRegistration = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCoustomerDetail = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employee1 = new Project.All_User_Control.UC_Employee();
            this.customerDetail1 = new Project.All_User_Control.CustomerDetail();
            this.uc_Customer_CheckOut1 = new Project.All_User_Control.Uc_Customer_CheckOut();
            this.uC_customer1 = new Project.All_User_Control.UC_customer();
            this.uC_AddRoom1 = new Project.All_User_Control.UC_AddRoom();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Movingpanel);
            this.panel1.Controls.Add(this.btnCourseRegistration);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCoustomerDetail);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(72, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 118);
            this.panel1.TabIndex = 0;
            // 
            // Movingpanel
            // 
            this.Movingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Movingpanel.Location = new System.Drawing.Point(15, 105);
            this.Movingpanel.Name = "Movingpanel";
            this.Movingpanel.Size = new System.Drawing.Size(228, 10);
            this.Movingpanel.TabIndex = 5;
            // 
            // btnCourseRegistration
            // 
            this.btnCourseRegistration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseRegistration.Location = new System.Drawing.Point(258, 17);
            this.btnCourseRegistration.Name = "btnCourseRegistration";
            this.btnCourseRegistration.Size = new System.Drawing.Size(232, 85);
            this.btnCourseRegistration.TabIndex = 4;
            this.btnCourseRegistration.Text = "Customer Registration";
            this.btnCourseRegistration.UseVisualStyleBackColor = true;
            this.btnCourseRegistration.Click += new System.EventHandler(this.btnCourseRegistration_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(496, 17);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(232, 85);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCoustomerDetail
            // 
            this.btnCoustomerDetail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoustomerDetail.Location = new System.Drawing.Point(734, 17);
            this.btnCoustomerDetail.Name = "btnCoustomerDetail";
            this.btnCoustomerDetail.Size = new System.Drawing.Size(232, 85);
            this.btnCoustomerDetail.TabIndex = 2;
            this.btnCoustomerDetail.Text = "General Details";
            this.btnCoustomerDetail.UseVisualStyleBackColor = true;
            this.btnCoustomerDetail.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(972, 17);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(232, 85);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoom.Location = new System.Drawing.Point(15, 17);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(232, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(168)))));
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.customerDetail1);
            this.panel2.Controls.Add(this.uc_Customer_CheckOut1);
            this.panel2.Controls.Add(this.uC_customer1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 496);
            this.panel2.TabIndex = 1;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uC_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1267, 496);
            this.uC_Employee1.TabIndex = 4;
            // 
            // customerDetail1
            // 
            this.customerDetail1.BackColor = System.Drawing.Color.Gray;
            this.customerDetail1.Location = new System.Drawing.Point(0, 0);
            this.customerDetail1.Name = "customerDetail1";
            this.customerDetail1.Size = new System.Drawing.Size(1267, 496);
            this.customerDetail1.TabIndex = 3;
            // 
            // uc_Customer_CheckOut1
            // 
            this.uc_Customer_CheckOut1.Location = new System.Drawing.Point(0, 0);
            this.uc_Customer_CheckOut1.Name = "uc_Customer_CheckOut1";
            this.uc_Customer_CheckOut1.Size = new System.Drawing.Size(1264, 496);
            this.uc_Customer_CheckOut1.TabIndex = 2;
            this.uc_Customer_CheckOut1.Load += new System.EventHandler(this.uc_Customer_CheckOut1_Load_1);
            // 
            // uC_customer1
            // 
            this.uC_customer1.BackColor = System.Drawing.Color.White;
            this.uC_customer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_customer1.Location = new System.Drawing.Point(0, -10);
            this.uC_customer1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_customer1.Name = "uC_customer1";
            this.uC_customer1.Size = new System.Drawing.Size(2004, 614);
            this.uC_customer1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 3);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1282, 505);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.Visible = false;
            this.uC_AddRoom1.Load += new System.EventHandler(this.uC_AddRoom1_Load);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Red;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(12, 76);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 38);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(168)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1329, 703);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCourseRegistration;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCoustomerDetail;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel Movingpanel;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private All_User_Control.UC_customer uC_customer1;
        private All_User_Control.Uc_Customer_CheckOut uc_Customer_CheckOut1;
        private All_User_Control.CustomerDetail customerDetail1;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}