namespace TogetherCulture
{
    partial class UserProfilePage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            chkCaring = new CheckBox();
            chkSharing = new CheckBox();
            chkCreating = new CheckBox();
            chkExperiencing = new CheckBox();
            chkWorking = new CheckBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 32);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Together Culture";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 51);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 2;
            label2.Text = "Create or Update Profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 86);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 3;
            label3.Text = "User ID ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 90);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 5;
            label4.Text = "Name *";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 135);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 7;
            label5.Text = "Age *";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 23);
            textBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(299, 139);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 9;
            label6.Text = "Location *";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(382, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 23);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 182);
            label7.Name = "label7";
            label7.Size = new Size(127, 21);
            label7.TabIndex = 11;
            label7.Text = "Phone Number *";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(158, 182);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 23);
            textBox5.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 235);
            label8.Name = "label8";
            label8.Size = new Size(171, 21);
            label8.TabIndex = 13;
            label8.Text = "Select Your Interests *";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkWorking);
            groupBox1.Controls.Add(chkExperiencing);
            groupBox1.Controls.Add(chkCreating);
            groupBox1.Controls.Add(chkSharing);
            groupBox1.Controls.Add(chkCaring);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 132);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interests";
            // 
            // chkCaring
            // 
            chkCaring.AutoSize = true;
            chkCaring.Location = new Point(12, 26);
            chkCaring.Name = "chkCaring";
            chkCaring.Size = new Size(71, 24);
            chkCaring.TabIndex = 0;
            chkCaring.Text = "Caring";
            chkCaring.UseVisualStyleBackColor = true;
            // 
            // chkSharing
            // 
            chkSharing.AutoSize = true;
            chkSharing.Location = new Point(131, 26);
            chkSharing.Name = "chkSharing";
            chkSharing.Size = new Size(78, 24);
            chkSharing.TabIndex = 1;
            chkSharing.Text = "Sharing";
            chkSharing.UseVisualStyleBackColor = true;
            // 
            // chkCreating
            // 
            chkCreating.AutoSize = true;
            chkCreating.Location = new Point(228, 26);
            chkCreating.Name = "chkCreating";
            chkCreating.Size = new Size(84, 24);
            chkCreating.TabIndex = 2;
            chkCreating.Text = "Creating";
            chkCreating.UseVisualStyleBackColor = true;
            // 
            // chkExperiencing
            // 
            chkExperiencing.AutoSize = true;
            chkExperiencing.Location = new Point(12, 81);
            chkExperiencing.Name = "chkExperiencing";
            chkExperiencing.Size = new Size(113, 24);
            chkExperiencing.TabIndex = 3;
            chkExperiencing.Text = "Experiencing";
            chkExperiencing.UseVisualStyleBackColor = true;
            // 
            // chkWorking
            // 
            chkWorking.AutoSize = true;
            chkWorking.Location = new Point(131, 81);
            chkWorking.Name = "chkWorking";
            chkWorking.Size = new Size(83, 24);
            chkWorking.TabIndex = 4;
            chkWorking.Text = "Working";
            chkWorking.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(27, 424);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(327, 52);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(642, 424);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 52);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Exit";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(400, 424);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 52);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // UserProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 488);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserProfilePage";
            Text = "UserProfilePage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private GroupBox groupBox1;
        private CheckBox chkCaring;
        private CheckBox chkWorking;
        private CheckBox chkExperiencing;
        private CheckBox chkCreating;
        private CheckBox chkSharing;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
    }
}