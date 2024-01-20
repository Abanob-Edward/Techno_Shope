
namespace Presentation
{
    partial class LoginAndRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAndRegister));
            button_GoToLogin = new Button();
            button_GoTo_Register = new Button();
            panel_login = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1_close = new PictureBox();
            panel_register = new Panel();
            textBox_8 = new TextBox();
            label8 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            button3 = new Button();
            textBox11 = new TextBox();
            label11 = new Label();
            textBox12 = new TextBox();
            label12 = new Label();
            panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_close).BeginInit();
            panel_register.SuspendLayout();
            SuspendLayout();
            // 
            // button_GoToLogin
            // 
            button_GoToLogin.BackColor = SystemColors.ActiveCaptionText;
            button_GoToLogin.FlatAppearance.BorderColor = Color.Black;
            button_GoToLogin.FlatStyle = FlatStyle.Flat;
            button_GoToLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_GoToLogin.ForeColor = Color.WhiteSmoke;
            button_GoToLogin.Location = new Point(12, 40);
            button_GoToLogin.Name = "button_GoToLogin";
            button_GoToLogin.Size = new Size(220, 66);
            button_GoToLogin.TabIndex = 0;
            button_GoToLogin.Text = "Login";
            button_GoToLogin.UseVisualStyleBackColor = false;
            button_GoToLogin.Click += button_GoToLogin_Click;
            // 
            // button_GoTo_Register
            // 
            button_GoTo_Register.BackColor = SystemColors.ActiveCaptionText;
            button_GoTo_Register.FlatAppearance.BorderColor = Color.Black;
            button_GoTo_Register.FlatStyle = FlatStyle.Flat;
            button_GoTo_Register.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_GoTo_Register.ForeColor = Color.WhiteSmoke;
            button_GoTo_Register.Location = new Point(321, 40);
            button_GoTo_Register.Name = "button_GoTo_Register";
            button_GoTo_Register.Size = new Size(220, 69);
            button_GoTo_Register.TabIndex = 1;
            button_GoTo_Register.Text = "Register";
            button_GoTo_Register.UseVisualStyleBackColor = false;
            button_GoTo_Register.Click += button_GoTo_Register_Click;
            // 
            // panel_login
            // 
            panel_login.Controls.Add(button1);
            panel_login.Controls.Add(textBox2);
            panel_login.Controls.Add(label2);
            panel_login.Controls.Add(textBox1);
            panel_login.Controls.Add(label1);
            panel_login.Location = new Point(7, 112);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(534, 528);
            panel_login.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(77, 272);
            button1.Name = "button1";
            button1.Size = new Size(443, 40);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 163);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 101);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            // 
            // pictureBox1_close
            // 
            pictureBox1_close.ErrorImage = (Image)resources.GetObject("pictureBox1_close.ErrorImage");
            pictureBox1_close.ImageLocation = "../ ../images/x.png";
            pictureBox1_close.InitialImage = (Image)resources.GetObject("pictureBox1_close.InitialImage");
            pictureBox1_close.Location = new Point(525, 12);
            pictureBox1_close.Name = "pictureBox1_close";
            pictureBox1_close.Size = new Size(16, 16);
            pictureBox1_close.TabIndex = 3;
            pictureBox1_close.TabStop = false;
            pictureBox1_close.Click += pictureBox1_close_Click;
            // 
            // panel_register
            // 
            panel_register.Controls.Add(textBox_8);
            panel_register.Controls.Add(label8);
            panel_register.Controls.Add(textBox9);
            panel_register.Controls.Add(label9);
            panel_register.Controls.Add(textBox10);
            panel_register.Controls.Add(label10);
            panel_register.Controls.Add(button3);
            panel_register.Controls.Add(textBox11);
            panel_register.Controls.Add(label11);
            panel_register.Controls.Add(textBox12);
            panel_register.Controls.Add(label12);
            panel_register.Location = new Point(7, 112);
            panel_register.Name = "panel_register";
            panel_register.Size = new Size(534, 528);
            panel_register.TabIndex = 6;
            // 
            // textBox_8
            // 
            textBox_8.Location = new Point(165, 60);
            textBox_8.Name = "textBox_8";
            textBox_8.Size = new Size(334, 27);
            textBox_8.TabIndex = 10;
            textBox_8.TextChanged += textBox_8_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(56, 59);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 9;
            label8.Text = "Fist Name:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(165, 268);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(334, 27);
            textBox9.TabIndex = 8;
            textBox9.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(36, 267);
            label9.Name = "label9";
            label9.Size = new Size(127, 28);
            label9.TabIndex = 7;
            label9.Text = "Confirm Pass:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(165, 216);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(334, 27);
            textBox10.TabIndex = 6;
            textBox10.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(56, 215);
            label10.Name = "label10";
            label10.Size = new Size(97, 28);
            label10.TabIndex = 5;
            label10.Text = "Password:";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(56, 370);
            button3.Name = "button3";
            button3.Size = new Size(443, 40);
            button3.TabIndex = 4;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(165, 164);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(334, 27);
            textBox11.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(56, 163);
            label11.Name = "label11";
            label11.Size = new Size(17, 28);
            label11.TabIndex = 2;
            label11.Text = " ";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(165, 112);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(334, 27);
            textBox12.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(56, 111);
            label12.Name = "label12";
            label12.Size = new Size(107, 28);
            label12.TabIndex = 0;
            label12.Text = "Last Name:";
            // 
            // LoginAndRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(568, 663);
            Controls.Add(pictureBox1_close);
            Controls.Add(button_GoTo_Register);
            Controls.Add(button_GoToLogin);
            Controls.Add(panel_register);
            Controls.Add(panel_login);
            Name = "LoginAndRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_close).EndInit();
            panel_register.ResumeLayout(false);
            panel_register.PerformLayout();
            ResumeLayout(false);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button_GoToLogin;
        private Button button_GoTo_Register;
        private Panel panel_login;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1_close;
        private Panel panel_register;
        private TextBox textBox_8;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
        private Button button3;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
    }
}