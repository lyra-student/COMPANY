﻿namespace COMPANY
{
    partial class ADMIN
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
            System.Windows.Forms.Button departmentbtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            this.taskbtn = new System.Windows.Forms.Button();
            this.projectbtn = new System.Windows.Forms.Button();
            this.empbtn = new System.Windows.Forms.Button();
            departmentbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskbtn
            // 
            this.taskbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.taskbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskbtn.Location = new System.Drawing.Point(323, 341);
            this.taskbtn.Name = "taskbtn";
            this.taskbtn.Size = new System.Drawing.Size(154, 63);
            this.taskbtn.TabIndex = 19;
            this.taskbtn.Text = "TASK";
            this.taskbtn.UseVisualStyleBackColor = false;
            // 
            // projectbtn
            // 
            this.projectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.projectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectbtn.Location = new System.Drawing.Point(323, 245);
            this.projectbtn.Name = "projectbtn";
            this.projectbtn.Size = new System.Drawing.Size(154, 63);
            this.projectbtn.TabIndex = 18;
            this.projectbtn.Text = "PROJECT";
            this.projectbtn.UseVisualStyleBackColor = false;
            // 
            // departmentbtn
            // 
            departmentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            departmentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            departmentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentbtn.Location = new System.Drawing.Point(323, 144);
            departmentbtn.Name = "departmentbtn";
            departmentbtn.Size = new System.Drawing.Size(154, 63);
            departmentbtn.TabIndex = 17;
            departmentbtn.Text = "DEPARTMENT";
            departmentbtn.UseVisualStyleBackColor = false;
            // 
            // empbtn
            // 
            this.empbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.empbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empbtn.Location = new System.Drawing.Point(323, 47);
            this.empbtn.Name = "empbtn";
            this.empbtn.Size = new System.Drawing.Size(154, 63);
            this.empbtn.TabIndex = 16;
            this.empbtn.Text = "EMPLOYEE";
            this.empbtn.UseVisualStyleBackColor = false;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskbtn);
            this.Controls.Add(this.projectbtn);
            this.Controls.Add(departmentbtn);
            this.Controls.Add(this.empbtn);
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskbtn;
        private System.Windows.Forms.Button projectbtn;
        private System.Windows.Forms.Button empbtn;
    }
}