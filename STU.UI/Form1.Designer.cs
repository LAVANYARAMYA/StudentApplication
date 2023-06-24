namespace STU.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblAge = new Label();
            txtStudentId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtAge = new TextBox();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnUpdateSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(128, 85);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(73, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "StudentId";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(128, 141);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "FirstName";
            lblFirstName.Click += label2_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(128, 202);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "LastName";
            lblLastName.Click += label3_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(128, 252);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(128, 296);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(257, 82);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(257, 141);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(257, 202);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(257, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(257, 293);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(289, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(488, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(449, 321);
            dataGridView1.TabIndex = 11;
            // 
            // btnView
            // 
            btnView.Location = new Point(106, 361);
            btnView.Name = "btnView";
            btnView.Size = new Size(142, 29);
            btnView.TabIndex = 12;
            btnView.Text = "ViewDetails";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(197, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(106, 421);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnUpdateSave
            // 
            btnUpdateSave.Location = new Point(289, 421);
            btnUpdateSave.Name = "btnUpdateSave";
            btnUpdateSave.Size = new Size(142, 29);
            btnUpdateSave.TabIndex = 15;
            btnUpdateSave.Text = "UpdateSave";
            btnUpdateSave.UseVisualStyleBackColor = true;
            btnUpdateSave.Click += btnUpdateSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 599);
            Controls.Add(btnUpdateSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentId);
            Controls.Add(lblAge);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblAge;
        private TextBox txtStudentId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtAge;
        private Button btnSave;
        private DataGridView dataGridView1;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnUpdateSave;
    }
}