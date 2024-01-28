namespace Presentation.User_Role
{
    partial class userProfielPanel
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
        /// 



        private void InitializeComponent()
        {
            Prof_Name = new Label();
            text_prof_name = new TextBox();
            text_Number = new TextBox();
            text_email_prof = new TextBox();
            email_prof = new Label();
            Phone_num_prof = new Label();
            Text_UserName = new TextBox();
            label_UserName = new Label();
            SuspendLayout();
            // 
            // Prof_Name
            // 
            Prof_Name.AutoSize = true;
            Prof_Name.BackColor = Color.OrangeRed;
            Prof_Name.FlatStyle = FlatStyle.Flat;
            Prof_Name.Font = new Font("Microsoft Sans Serif", 13.8F);
            Prof_Name.ForeColor = Color.Black;
            Prof_Name.Location = new Point(544, 219);
            Prof_Name.Margin = new Padding(5, 0, 5, 0);
            Prof_Name.Name = "Prof_Name";
            Prof_Name.Size = new Size(78, 29);
            Prof_Name.TabIndex = 0;
            Prof_Name.Text = "Name";
            Prof_Name.Click += Prof_Name_Click;
            // 
            // text_prof_name
            // 
            text_prof_name.Font = new Font("Segoe UI", 12F);
            text_prof_name.Location = new Point(734, 219);
            text_prof_name.Margin = new Padding(5);
            text_prof_name.Name = "text_prof_name";
            text_prof_name.Size = new Size(522, 34);
            text_prof_name.TabIndex = 1;
            text_prof_name.TextChanged += text_prof_name_TextChanged;
            // 
            // text_Number
            // 
            text_Number.Font = new Font("Segoe UI", 12F);
            text_Number.Location = new Point(734, 500);
            text_Number.Margin = new Padding(5);
            text_Number.Name = "text_Number";
            text_Number.Size = new Size(522, 34);
            text_Number.TabIndex = 3;
            text_Number.TextChanged += text_Number_TextChanged;
            // 
            // text_email_prof
            // 
            text_email_prof.Font = new Font("Segoe UI", 12F);
            text_email_prof.Location = new Point(734, 403);
            text_email_prof.Margin = new Padding(5);
            text_email_prof.Name = "text_email_prof";
            text_email_prof.Size = new Size(522, 34);
            text_email_prof.TabIndex = 7;
            text_email_prof.TextChanged += text_email_prof_TextChanged;
            // 
            // email_prof
            // 
            email_prof.AutoSize = true;
            email_prof.BackColor = Color.OrangeRed;
            email_prof.FlatStyle = FlatStyle.Flat;
            email_prof.Font = new Font("Microsoft Sans Serif", 13.8F);
            email_prof.ForeColor = Color.Black;
            email_prof.Location = new Point(544, 408);
            email_prof.Margin = new Padding(5, 0, 5, 0);
            email_prof.Name = "email_prof";
            email_prof.Size = new Size(74, 29);
            email_prof.TabIndex = 6;
            email_prof.Text = "Email";
            email_prof.Click += email_prof_Click;
            // 
            // Phone_num_prof
            // 
            Phone_num_prof.AutoSize = true;
            Phone_num_prof.BackColor = Color.OrangeRed;
            Phone_num_prof.FlatStyle = FlatStyle.Flat;
            Phone_num_prof.Font = new Font("Microsoft Sans Serif", 13.8F);
            Phone_num_prof.ForeColor = Color.Black;
            Phone_num_prof.Location = new Point(544, 503);
            Phone_num_prof.Margin = new Padding(5, 0, 5, 0);
            Phone_num_prof.Name = "Phone_num_prof";
            Phone_num_prof.Size = new Size(180, 29);
            Phone_num_prof.TabIndex = 2;
            Phone_num_prof.Text = "Mobile Number";
            Phone_num_prof.FontChanged += text_Number_TextChanged;
            Phone_num_prof.Click += Phone_num_prof_Click;
            // 
            // Text_UserName
            // 
            Text_UserName.Font = new Font("Segoe UI", 12F);
            Text_UserName.Location = new Point(733, 308);
            Text_UserName.Margin = new Padding(5);
            Text_UserName.Name = "Text_UserName";
            Text_UserName.Size = new Size(522, 34);
            Text_UserName.TabIndex = 10;
            Text_UserName.TextChanged += Text_UserName_TextChanged;
            // 
            // label_UserName
            // 
            label_UserName.AutoSize = true;
            label_UserName.BackColor = Color.OrangeRed;
            label_UserName.FlatStyle = FlatStyle.Flat;
            label_UserName.Font = new Font("Microsoft Sans Serif", 13.8F);
            label_UserName.ForeColor = Color.Black;
            label_UserName.Location = new Point(544, 313);
            label_UserName.Margin = new Padding(5, 0, 5, 0);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(139, 29);
            label_UserName.TabIndex = 9;
            label_UserName.Text = "User Namw";
            label_UserName.Click += label_UserName_Click;
            // 
            // userProfielPanel
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.preview16;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1201, 736);
            Controls.Add(Text_UserName);
            Controls.Add(label_UserName);
            Controls.Add(text_email_prof);
            Controls.Add(email_prof);
            Controls.Add(text_Number);
            Controls.Add(Phone_num_prof);
            Controls.Add(text_prof_name);
            Controls.Add(Prof_Name);
            Font = new Font("Microsoft Sans Serif", 13.8F);
            ForeColor = Color.OrangeRed;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "userProfielPanel";
            Text = "userPrfielPanel";
            Load += userProfielPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Prof_Name;
        private TextBox text_prof_name;
        private TextBox text_Number;
        private TextBox text_pass_prof;
        private Label pass_prof;
        private TextBox text_email_prof;
        private Label email_prof;
        private Label Phone_num_prof;
        private TextBox textBox1;
        private Label label1;
        private TextBox Text_UserName;
        private Label label_UserName;
    }
}