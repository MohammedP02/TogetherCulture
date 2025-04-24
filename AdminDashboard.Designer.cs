namespace TogetherCulture
{
    partial class AdminDashboard
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
            btnUpdate = new Button();
            chkWorking = new CheckBox();
            chkExperiencing = new CheckBox();
            chkCreating = new CheckBox();
            chkSharing = new CheckBox();
            chkCaring = new CheckBox();
            btnExit = new Button();
            btnCreate = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtNumber = new TextBox();
            label7 = new Label();
            txtLocation = new TextBox();
            label6 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            comboUsers = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAuthorize = new Button();
            comboStatus = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(266, 474);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 34);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // chkWorking
            // 
            chkWorking.AutoSize = true;
            chkWorking.Location = new Point(146, 94);
            chkWorking.Name = "chkWorking";
            chkWorking.Size = new Size(83, 24);
            chkWorking.TabIndex = 4;
            chkWorking.Text = "Working";
            chkWorking.UseVisualStyleBackColor = true;
            // 
            // chkExperiencing
            // 
            chkExperiencing.AutoSize = true;
            chkExperiencing.Location = new Point(27, 94);
            chkExperiencing.Name = "chkExperiencing";
            chkExperiencing.Size = new Size(113, 24);
            chkExperiencing.TabIndex = 3;
            chkExperiencing.Text = "Experiencing";
            chkExperiencing.UseVisualStyleBackColor = true;
            // 
            // chkCreating
            // 
            chkCreating.AutoSize = true;
            chkCreating.Location = new Point(243, 39);
            chkCreating.Name = "chkCreating";
            chkCreating.Size = new Size(84, 24);
            chkCreating.TabIndex = 2;
            chkCreating.Text = "Creating";
            chkCreating.UseVisualStyleBackColor = true;
            // 
            // chkSharing
            // 
            chkSharing.AutoSize = true;
            chkSharing.Location = new Point(146, 39);
            chkSharing.Name = "chkSharing";
            chkSharing.Size = new Size(78, 24);
            chkSharing.TabIndex = 1;
            chkSharing.Text = "Sharing";
            chkSharing.UseVisualStyleBackColor = true;
            // 
            // chkCaring
            // 
            chkCaring.AutoSize = true;
            chkCaring.Location = new Point(27, 39);
            chkCaring.Name = "chkCaring";
            chkCaring.Size = new Size(71, 24);
            chkCaring.TabIndex = 0;
            chkCaring.Text = "Caring";
            chkCaring.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(662, 474);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(189, 34);
            btnExit.TabIndex = 33;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(48, 474);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(198, 34);
            btnCreate.TabIndex = 32;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkWorking);
            groupBox1.Controls.Add(chkExperiencing);
            groupBox1.Controls.Add(chkCreating);
            groupBox1.Controls.Add(chkSharing);
            groupBox1.Controls.Add(chkCaring);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(48, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 132);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interests";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 287);
            label8.Name = "label8";
            label8.Size = new Size(171, 21);
            label8.TabIndex = 30;
            label8.Text = "Select Your Interests *";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(177, 252);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 23);
            txtNumber.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 252);
            label7.Name = "label7";
            label7.Size = new Size(127, 21);
            label7.TabIndex = 28;
            label7.Text = "Phone Number *";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(393, 256);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(128, 23);
            txtLocation.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(310, 254);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 26;
            label6.Text = "Location *";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(177, 207);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 23);
            txtAge.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 205);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 24;
            label5.Text = "Age *";
            // 
            // txtName
            // 
            txtName.Location = new Point(393, 207);
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 23);
            txtName.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(310, 205);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 22;
            label4.Text = "Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 156);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 20;
            label3.Text = "User ID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 120);
            label2.Name = "label2";
            label2.Size = new Size(325, 25);
            label2.TabIndex = 19;
            label2.Text = "Create, Update or Authorize Profile";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, -1);
            label1.Name = "label1";
            label1.Size = new Size(335, 32);
            label1.TabIndex = 18;
            label1.Text = "Welcome to Together Culture";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(310, 158);
            label11.Name = "label11";
            label11.Size = new Size(52, 21);
            label11.TabIndex = 39;
            label11.Text = "Status";
            // 
            // comboUsers
            // 
            comboUsers.FormattingEnabled = true;
            comboUsers.Location = new Point(177, 158);
            comboUsers.Name = "comboUsers";
            comboUsers.Size = new Size(121, 23);
            comboUsers.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 43);
            label12.Name = "label12";
            label12.Size = new Size(200, 25);
            label12.TabIndex = 42;
            label12.Text = "Search User By Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(27, 80);
            label13.Name = "label13";
            label13.Size = new Size(92, 21);
            label13.TabIndex = 43;
            label13.Text = "Enter Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(120, 82);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 23);
            txtSearch.TabIndex = 44;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(295, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 27);
            btnSearch.TabIndex = 45;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAuthorize
            // 
            btnAuthorize.Enabled = false;
            btnAuthorize.Location = new Point(470, 474);
            btnAuthorize.Name = "btnAuthorize";
            btnAuthorize.Size = new Size(152, 34);
            btnAuthorize.TabIndex = 46;
            btnAuthorize.Text = "Authorize";
            btnAuthorize.UseVisualStyleBackColor = true;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Authorized", "Not Authorized" });
            comboStatus.Location = new Point(395, 157);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(121, 23);
            comboStatus.TabIndex = 47;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 538);
            Controls.Add(comboStatus);
            Controls.Add(btnAuthorize);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboUsers);
            Controls.Add(label11);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(txtNumber);
            Controls.Add(label7);
            Controls.Add(txtLocation);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private CheckBox chkWorking;
        private CheckBox chkExperiencing;
        private CheckBox chkCreating;
        private CheckBox chkSharing;
        private CheckBox chkCaring;
        private Button btnExit;
        private Button btnCreate;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtNumber;
        private Label label7;
        private TextBox txtLocation;
        private Label label6;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private ComboBox comboUsers;
        private Label label12;
        private Label label13;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAuthorize;
        private ComboBox comboStatus;
    }
}