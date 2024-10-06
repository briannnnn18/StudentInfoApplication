
namespace StudentInfoApplication
{
    partial class StudentInfo
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
            TextStudentId = new TextBox();
            TextLastName = new TextBox();
            TextFirstName = new TextBox();
            ListStudentId = new ListBox();
            ListLastName = new ListBox();
            ListFirstName = new ListBox();
            LabelStudentId = new Label();
            LabelLastName = new Label();
            LabelFirstName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // TextStudentId
            // 
            TextStudentId.Location = new Point(12, 45);
            TextStudentId.Name = "TextStudentId";
            TextStudentId.Size = new Size(251, 23);
            TextStudentId.TabIndex = 0;
            // 
            // TextLastName
            // 
            TextLastName.Location = new Point(269, 45);
            TextLastName.Name = "TextLastName";
            TextLastName.Size = new Size(251, 23);
            TextLastName.TabIndex = 1;
            // 
            // TextFirstName
            // 
            TextFirstName.Location = new Point(526, 45);
            TextFirstName.Name = "TextFirstName";
            TextFirstName.Size = new Size(251, 23);
            TextFirstName.TabIndex = 2;
            // 
            // ListStudentId
            // 
            ListStudentId.FormattingEnabled = true;
            ListStudentId.ItemHeight = 15;
            ListStudentId.Location = new Point(35, 149);
            ListStudentId.Name = "ListStudentId";
            ListStudentId.Size = new Size(228, 229);
            ListStudentId.TabIndex = 3;
            // 
            // ListLastName
            // 
            ListLastName.FormattingEnabled = true;
            ListLastName.ItemHeight = 15;
            ListLastName.Location = new Point(283, 149);
            ListLastName.Name = "ListLastName";
            ListLastName.Size = new Size(228, 229);
            ListLastName.TabIndex = 4;
            ListLastName.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ListFirstName
            // 
            ListFirstName.FormattingEnabled = true;
            ListFirstName.ItemHeight = 15;
            ListFirstName.Location = new Point(526, 149);
            ListFirstName.Name = "ListFirstName";
            ListFirstName.Size = new Size(228, 229);
            ListFirstName.TabIndex = 5;
            // 
            // LabelStudentId
            // 
            LabelStudentId.AutoSize = true;
            LabelStudentId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelStudentId.Location = new Point(12, 22);
            LabelStudentId.Name = "LabelStudentId";
            LabelStudentId.Size = new Size(88, 20);
            LabelStudentId.TabIndex = 6;
            LabelStudentId.Text = "Student ID*";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelLastName.Location = new Point(269, 22);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(86, 20);
            LabelLastName.TabIndex = 7;
            LabelLastName.Text = "Last name*";
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelFirstName.Location = new Point(526, 22);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(88, 20);
            LabelFirstName.TabIndex = 8;
            LabelFirstName.Text = "First name*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 126);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 9;
            label1.Text = " Student ID List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(526, 126);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 10;
            label2.Text = "Last Name List";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(283, 126);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 11;
            label3.Text = "First Name List";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(695, 83);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(82, 26);
            SubmitButton.TabIndex = 12;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click_1;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 408);
            Controls.Add(SubmitButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LabelFirstName);
            Controls.Add(LabelLastName);
            Controls.Add(LabelStudentId);
            Controls.Add(ListFirstName);
            Controls.Add(ListLastName);
            Controls.Add(ListStudentId);
            Controls.Add(TextFirstName);
            Controls.Add(TextLastName);
            Controls.Add(TextStudentId);
            Name = "StudentInfo";
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox TextStudentId;
        private TextBox TextLastName;
        private TextBox TextFirstName;
        private ListBox ListStudentId;
        private ListBox ListLastName;
        private ListBox ListFirstName;
        private Label LabelStudentId;
        private Label LabelLastName;
        private Label LabelFirstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SubmitButton;
    }
}
