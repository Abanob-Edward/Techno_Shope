using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userProfielPanel));
            Prof_Name = new Label();
            email_prof = new Label();
            Phone_num_prof = new Label();
            label_UserName = new Label();
            UserName = new Label();
            UserN = new Label();
            Emial = new Label();
            Mobile = new Label();
            SuspendLayout();
            // 
            // Prof_Name
            // 
            Prof_Name.AutoSize = true;
            Prof_Name.BackColor = Color.FromArgb(238, 238, 238);
            Prof_Name.FlatStyle = FlatStyle.Flat;
            Prof_Name.Font = new Font("Microsoft Sans Serif", 13.8F);
            Prof_Name.ForeColor = Color.Black;
            Prof_Name.Location = new Point(223, 225);
            Prof_Name.Margin = new Padding(5, 0, 5, 0);
            Prof_Name.Name = "Prof_Name";
            Prof_Name.Size = new Size(96, 29);
            Prof_Name.TabIndex = 0;
            Prof_Name.Text = "Name : ";
            // 
            // email_prof
            // 
            email_prof.AutoSize = true;
            email_prof.BackColor = Color.FromArgb(238, 238, 238);
            email_prof.FlatStyle = FlatStyle.Flat;
            email_prof.Font = new Font("Microsoft Sans Serif", 13.8F);
            email_prof.ForeColor = Color.Black;
            email_prof.Location = new Point(223, 414);
            email_prof.Margin = new Padding(5, 0, 5, 0);
            email_prof.Name = "email_prof";
            email_prof.Size = new Size(86, 29);
            email_prof.TabIndex = 6;
            email_prof.Text = "Email :";
            // 
            // Phone_num_prof
            // 
            Phone_num_prof.AutoSize = true;
            Phone_num_prof.BackColor = Color.FromArgb(238, 238, 238);
            Phone_num_prof.FlatStyle = FlatStyle.Flat;
            Phone_num_prof.Font = new Font("Microsoft Sans Serif", 13.8F);
            Phone_num_prof.ForeColor = Color.Black;
            Phone_num_prof.Location = new Point(223, 509);
            Phone_num_prof.Margin = new Padding(5, 0, 5, 0);
            Phone_num_prof.Name = "Phone_num_prof";
            Phone_num_prof.Size = new Size(192, 29);
            Phone_num_prof.TabIndex = 2;
            Phone_num_prof.Text = "Mobile Number :";
           
            // 
            // label_UserName
            // 
            label_UserName.AutoSize = true;
            label_UserName.BackColor = Color.FromArgb(238, 238, 238);
            label_UserName.FlatStyle = FlatStyle.Flat;
            label_UserName.Font = new Font("Microsoft Sans Serif", 13.8F);
            label_UserName.ForeColor = Color.Black;
            label_UserName.Location = new Point(223, 319);
            label_UserName.Margin = new Padding(5, 0, 5, 0);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(153, 29);
            label_UserName.TabIndex = 9;
            label_UserName.Text = "User Name : ";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(474, 225);
            UserName.Name = "UserName";
            UserName.Size = new Size(19, 29);
            UserName.TabIndex = 11;
            UserName.Text = " ";
            // 
            // UserN
            // 
            UserN.AutoSize = true;
            UserN.Location = new Point(474, 319);
            UserN.Name = "UserN";
            UserN.Size = new Size(25, 29);
            UserN.TabIndex = 12;
            UserN.Text = "  ";
            // 
            // Emial
            // 
            Emial.AutoSize = true;
            Emial.Location = new Point(474, 414);
            Emial.Name = "Emial";
            Emial.Size = new Size(19, 29);
            Emial.TabIndex = 13;
            Emial.Text = " ";
            // 
            // Mobile
            // 
            Mobile.AutoSize = true;
            Mobile.Location = new Point(474, 509);
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(19, 29);
            Mobile.TabIndex = 14;
            Mobile.Text = " ";
            // 
            // userProfielPanel
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1201, 736);
            Controls.Add(Mobile);
            Controls.Add(Emial);
            Controls.Add(UserN);
            Controls.Add(UserName);
            Controls.Add(label_UserName);
            Controls.Add(email_prof);
            Controls.Add(Phone_num_prof);
            Controls.Add(Prof_Name);
            Font = new Font("Microsoft Sans Serif", 13.8F);
            ForeColor = SystemColors.ActiveCaptionText;
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
        private TextBox text_pass_prof;
        private Label pass_prof;
        private Label email_prof;
        private Label Phone_num_prof;
        private TextBox textBox1;
        private Label label1;
        private Label label_UserName;
        private Label UserName;
        private Label UserN;
        private Label Emial;
        private Label Mobile;
    }
}