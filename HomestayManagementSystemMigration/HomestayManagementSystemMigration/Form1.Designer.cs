namespace HomestayManagementSystemMigration
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenExcelStudent = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonOpenExcelHomestay = new System.Windows.Forms.Button();
            this.buttonOpenExcelHomestayStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // openFileDialog1
            //
            this.openFileDialog1.FileName = "openFileDialog1";
            //
            // buttonOpenExcelStudent
            //
            this.buttonOpenExcelStudent.Location = new System.Drawing.Point(315, 12);
            this.buttonOpenExcelStudent.Name = "buttonOpenExcelStudent";
            this.buttonOpenExcelStudent.Size = new System.Drawing.Size(199, 23);
            this.buttonOpenExcelStudent.TabIndex = 0;
            this.buttonOpenExcelStudent.Text = "Open Excel Student";
            this.buttonOpenExcelStudent.UseVisualStyleBackColor = true;
            this.buttonOpenExcelStudent.Click += new System.EventHandler(this.buttonOpenExcelStudent_Click);
            //
            // richTextBoxResult
            //
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 41);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(789, 428);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            //
            // buttonOpenExcelHomestay
            //
            this.buttonOpenExcelHomestay.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenExcelHomestay.Name = "buttonOpenExcelHomestay";
            this.buttonOpenExcelHomestay.Size = new System.Drawing.Size(177, 23);
            this.buttonOpenExcelHomestay.TabIndex = 2;
            this.buttonOpenExcelHomestay.Text = "Open Excel Homestay";
            this.buttonOpenExcelHomestay.UseVisualStyleBackColor = true;
            this.buttonOpenExcelHomestay.Click += new System.EventHandler(this.buttonOpenExcelHomestay_Click);
            //
            // buttonOpenExcelHomestayStudent
            //
            this.buttonOpenExcelHomestayStudent.Location = new System.Drawing.Point(602, 12);
            this.buttonOpenExcelHomestayStudent.Name = "buttonOpenExcelHomestayStudent";
            this.buttonOpenExcelHomestayStudent.Size = new System.Drawing.Size(199, 23);
            this.buttonOpenExcelHomestayStudent.TabIndex = 3;
            this.buttonOpenExcelHomestayStudent.Text = "Open Excel Homestay Student";
            this.buttonOpenExcelHomestayStudent.UseVisualStyleBackColor = true;
            this.buttonOpenExcelHomestayStudent.Click += new System.EventHandler(this.buttonOpenExcelHomestayStudent_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 481);
            this.Controls.Add(this.buttonOpenExcelHomestayStudent);
            this.Controls.Add(this.buttonOpenExcelHomestay);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonOpenExcelStudent);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HomestayManagementSystem Migration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenExcelStudent;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonOpenExcelHomestay;
        private System.Windows.Forms.Button buttonOpenExcelHomestayStudent;
    }
}

