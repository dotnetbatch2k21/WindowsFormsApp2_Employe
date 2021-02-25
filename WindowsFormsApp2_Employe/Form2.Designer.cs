
namespace WindowsFormsApp2_Employe
{
    partial class Form2
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_deptid = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_Designation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "deptid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Age";
            // 
            // txt_deptid
            // 
            this.txt_deptid.Location = new System.Drawing.Point(323, 289);
            this.txt_deptid.Name = "txt_deptid";
            this.txt_deptid.Size = new System.Drawing.Size(100, 20);
            this.txt_deptid.TabIndex = 24;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(323, 248);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 23;
            // 
            // txt_Designation
            // 
            this.txt_Designation.Location = new System.Drawing.Point(323, 207);
            this.txt_Designation.Name = "txt_Designation";
            this.txt_Designation.Size = new System.Drawing.Size(100, 20);
            this.txt_Designation.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "salary";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(323, 160);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "EmployeeName";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(323, 116);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "EmployeeID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(530, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 251);
            this.listBox1.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_deptid);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_Designation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_deptid;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_Designation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}