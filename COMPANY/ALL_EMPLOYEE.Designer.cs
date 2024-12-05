namespace COMPANY
{
    partial class ALL_EMPLOYEE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALL_EMPLOYEE));
            this.delbtn = new System.Windows.Forms.Button();
            this.updateEmp = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchEmp = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.addEmp = new System.Windows.Forms.Button();
            this.taskBox = new System.Windows.Forms.ComboBox();
            this.projectBox = new System.Windows.Forms.ComboBox();
            this.deptBox = new System.Windows.Forms.ComboBox();
            this.task = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.lntxt = new System.Windows.Forms.TextBox();
            this.fntxt = new System.Windows.Forms.TextBox();
            this.empIdtxt = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.empId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(919, 210);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(200, 35);
            this.delbtn.TabIndex = 37;
            this.delbtn.Text = "DELETE EMPLOYEE";
            this.delbtn.UseVisualStyleBackColor = false;
            // 
            // updateEmp
            // 
            this.updateEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.updateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmp.Location = new System.Drawing.Point(631, 212);
            this.updateEmp.Name = "updateEmp";
            this.updateEmp.Size = new System.Drawing.Size(204, 35);
            this.updateEmp.TabIndex = 36;
            this.updateEmp.Text = "UPDATE EMPLOYEE";
            this.updateEmp.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(531, 292);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(109, 28);
            this.searchBtn.TabIndex = 35;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // searchEmp
            // 
            this.searchEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmp.Location = new System.Drawing.Point(332, 292);
            this.searchEmp.Name = "searchEmp";
            this.searchEmp.Size = new System.Drawing.Size(156, 28);
            this.searchEmp.TabIndex = 34;
            this.searchEmp.Text = "Employee Id";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(89, 295);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(237, 25);
            this.search.TabIndex = 33;
            this.search.Text = "SEARCH EMPLOYEE :";
            // 
            // addEmp
            // 
            this.addEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.Location = new System.Drawing.Point(356, 211);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(167, 35);
            this.addEmp.TabIndex = 32;
            this.addEmp.Text = "ADD EMPLOYEE";
            this.addEmp.UseVisualStyleBackColor = false;
            // 
            // taskBox
            // 
            this.taskBox.FormattingEnabled = true;
            this.taskBox.Location = new System.Drawing.Point(889, 152);
            this.taskBox.Name = "taskBox";
            this.taskBox.Size = new System.Drawing.Size(196, 24);
            this.taskBox.TabIndex = 31;
            // 
            // projectBox
            // 
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(904, 101);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(196, 24);
            this.projectBox.TabIndex = 30;
            // 
            // deptBox
            // 
            this.deptBox.FormattingEnabled = true;
            this.deptBox.Location = new System.Drawing.Point(936, 57);
            this.deptBox.Name = "deptBox";
            this.deptBox.Size = new System.Drawing.Size(196, 24);
            this.deptBox.TabIndex = 29;
            // 
            // task
            // 
            this.task.AutoSize = true;
            this.task.BackColor = System.Drawing.Color.Transparent;
            this.task.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task.Location = new System.Drawing.Point(772, 152);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(84, 25);
            this.task.TabIndex = 28;
            this.task.Text = "TASK: ";
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.BackColor = System.Drawing.Color.Transparent;
            this.project.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project.Location = new System.Drawing.Point(772, 104);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(126, 25);
            this.project.TabIndex = 27;
            this.project.Text = "PROJECT: ";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.BackColor = System.Drawing.Color.Transparent;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(772, 58);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(158, 25);
            this.department.TabIndex = 26;
            this.department.Text = "DEPARMENT: ";
            // 
            // lntxt
            // 
            this.lntxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lntxt.Location = new System.Drawing.Point(444, 152);
            this.lntxt.Name = "lntxt";
            this.lntxt.Size = new System.Drawing.Size(241, 28);
            this.lntxt.TabIndex = 25;
            // 
            // fntxt
            // 
            this.fntxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fntxt.Location = new System.Drawing.Point(444, 101);
            this.fntxt.Name = "fntxt";
            this.fntxt.Size = new System.Drawing.Size(241, 28);
            this.fntxt.TabIndex = 24;
            // 
            // empIdtxt
            // 
            this.empIdtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdtxt.Location = new System.Drawing.Point(444, 53);
            this.empIdtxt.Name = "empIdtxt";
            this.empIdtxt.Size = new System.Drawing.Size(156, 28);
            this.empIdtxt.TabIndex = 23;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.Color.Transparent;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(269, 155);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(155, 25);
            this.lname.TabIndex = 22;
            this.lname.Text = "LAST NAME : ";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.BackColor = System.Drawing.Color.Transparent;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(269, 101);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(161, 25);
            this.fname.TabIndex = 21;
            this.fname.Text = "FIRST NAME : ";
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.BackColor = System.Drawing.Color.Transparent;
            this.empId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.Location = new System.Drawing.Point(269, 58);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(169, 25);
            this.empId.TabIndex = 20;
            this.empId.Text = "EMPLOYEE ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(18, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 364);
            this.dataGridView1.TabIndex = 19;
            // 
            // ALL_EMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 762);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updateEmp);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchEmp);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addEmp);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.deptBox);
            this.Controls.Add(this.task);
            this.Controls.Add(this.project);
            this.Controls.Add(this.department);
            this.Controls.Add(this.lntxt);
            this.Controls.Add(this.fntxt);
            this.Controls.Add(this.empIdtxt);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ALL_EMPLOYEE";
            this.Text = "ALL_EMPLOYEE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button updateEmp;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchEmp;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.ComboBox taskBox;
        private System.Windows.Forms.ComboBox projectBox;
        private System.Windows.Forms.ComboBox deptBox;
        private System.Windows.Forms.Label task;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.TextBox lntxt;
        private System.Windows.Forms.TextBox fntxt;
        private System.Windows.Forms.TextBox empIdtxt;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}