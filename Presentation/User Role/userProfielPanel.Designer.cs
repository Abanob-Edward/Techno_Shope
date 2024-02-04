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
            email_prof = new Label();
            Phone_num_prof = new Label();
            label_UserName = new Label();
            UserN = new Label();
            Emial = new Label();
            Mobile = new Label();
            panel1 = new Panel();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            UserName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // email_prof
            // 
            email_prof.AutoSize = true;
            email_prof.BackColor = Color.Transparent;
            email_prof.BorderStyle = BorderStyle.Fixed3D;
            email_prof.FlatStyle = FlatStyle.Flat;
            email_prof.Font = new Font("Microsoft Sans Serif", 13.8F);
            email_prof.ForeColor = Color.FromArgb(33, 42, 81);
            email_prof.Location = new Point(112, 321);
            email_prof.Margin = new Padding(5, 0, 5, 0);
            email_prof.Name = "email_prof";
            email_prof.Size = new Size(103, 34);
            email_prof.TabIndex = 6;
            email_prof.Text = "Email :";
            // 
            // Phone_num_prof
            // 
            Phone_num_prof.AutoSize = true;
            Phone_num_prof.BackColor = Color.Transparent;
            Phone_num_prof.BorderStyle = BorderStyle.Fixed3D;
            Phone_num_prof.FlatStyle = FlatStyle.Flat;
            Phone_num_prof.Font = new Font("Microsoft Sans Serif", 13.8F);
            Phone_num_prof.ForeColor = Color.FromArgb(33, 42, 81);
            Phone_num_prof.Location = new Point(87, 435);
            Phone_num_prof.Margin = new Padding(5, 0, 5, 0);
            Phone_num_prof.Name = "Phone_num_prof";
            Phone_num_prof.Size = new Size(223, 34);
            Phone_num_prof.TabIndex = 2;
            Phone_num_prof.Text = "Mobile Number :";
            // 
            // label_UserName
            // 
            label_UserName.AutoSize = true;
            label_UserName.BackColor = Color.Transparent;
            label_UserName.BorderStyle = BorderStyle.Fixed3D;
            label_UserName.FlatStyle = FlatStyle.Flat;
            label_UserName.Font = new Font("Microsoft Sans Serif", 13.8F);
            label_UserName.ForeColor = Color.FromArgb(33, 42, 81);
            label_UserName.Location = new Point(89, 236);
            label_UserName.Margin = new Padding(5, 0, 5, 0);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(186, 34);
            label_UserName.TabIndex = 9;
            label_UserName.Text = " User Name : ";
            // 
            // UserN
            // 
            UserN.AutoSize = true;
            UserN.BackColor = Color.Transparent;
            UserN.ForeColor = Color.FromArgb(33, 42, 81);
            UserN.Location = new Point(341, 236);
            UserN.Name = "UserN";
            UserN.Size = new Size(28, 32);
            UserN.TabIndex = 11;
            UserN.Text = "  ";
            // 
            // Emial
            // 
            Emial.AutoSize = true;
            Emial.BackColor = Color.Transparent;
            Emial.ForeColor = Color.FromArgb(33, 42, 81);
            Emial.Location = new Point(289, 323);
            Emial.Name = "Emial";
            Emial.Size = new Size(21, 32);
            Emial.TabIndex = 13;
            Emial.Text = " ";
            // 
            // Mobile
            // 
            Mobile.AutoSize = true;
            Mobile.BackColor = Color.Transparent;
            Mobile.ForeColor = Color.FromArgb(33, 42, 81);
            Mobile.Location = new Point(341, 435);
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(21, 32);
            Mobile.TabIndex = 14;
            Mobile.Text = " ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 172, 148);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 18);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Location = new Point(14, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 3);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Location = new Point(14, 371);
            panel3.Name = "panel3";
            panel3.Size = new Size(465, 3);
            panel3.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.Location = new Point(14, 485);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 3);
            panel4.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = Color.FromArgb(33, 42, 81);
            label1.Location = new Point(14, 533);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 34);
            label1.TabIndex = 22;
            label1.Text = "Remember me";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3443549;
            pictureBox1.Location = new Point(14, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 424);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 321);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(254, 533);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Handwriting", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(33, 42, 81);
            label2.Location = new Point(358, 74);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(299, 38);
            label2.TabIndex = 27;
            label2.Text = "This Are Your Info";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Font = new Font("Lucida Handwriting", 14F);
            UserName.ForeColor = Color.FromArgb(33, 42, 81);
            UserName.Location = new Point(126, 74);
            UserName.Name = "UserName";
            UserName.Size = new Size(33, 36);
            UserName.TabIndex = 28;
            UserName.Text = "  ";
            // 
            // userProfielPanel
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1201, 736);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Mobile);
            Controls.Add(Emial);
            Controls.Add(UserN);
            Controls.Add(label_UserName);
            Controls.Add(email_prof);
            Controls.Add(Phone_num_prof);
            Font = new Font("Microsoft Sans Serif", 13.8F);
            ForeColor = Color.FromArgb(214, 90, 49);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "userProfielPanel";
            Text = "userPrfielPanel";
            Load += userProfielPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Label label_UserName;
       // private Label UserName;
        private Label UserN;
        private Label Emial;
        private Label Mobile;
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label UserName;
    }
}