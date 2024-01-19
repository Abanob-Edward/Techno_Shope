namespace Presentation
{
    partial class AdminPanal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanal));
            panel1 = new Panel();
            label1 = new Label();
            BtnSideBar = new PictureBox();
            sideBar = new FlowLayoutPanel();
            panel4 = new Panel();
            button3 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            CategoryMenu = new FlowLayoutPanel();
            panel5 = new Panel();
            CatMenuBtn = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel8 = new Panel();
            button7 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            CategoryTransition = new System.Windows.Forms.Timer(components);
            SideBarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).BeginInit();
            sideBar.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            CategoryMenu.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnSideBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1443, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 3);
            label1.Name = "label1";
            label1.Size = new Size(329, 54);
            label1.TabIndex = 1;
            label1.Text = "TECHNO SHOP";
            // 
            // BtnSideBar
            // 
            BtnSideBar.Image = (Image)resources.GetObject("BtnSideBar.Image");
            BtnSideBar.Location = new Point(5, 9);
            BtnSideBar.Name = "BtnSideBar";
            BtnSideBar.Size = new Size(54, 44);
            BtnSideBar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSideBar.TabIndex = 1;
            BtnSideBar.TabStop = false;
            BtnSideBar.Click += BtnSideBar_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.Black;
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel6);
            sideBar.Controls.Add(CategoryMenu);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel3);
            sideBar.Dock = DockStyle.Left;
            sideBar.FlowDirection = FlowDirection.TopDown;
            sideBar.Location = new Point(0, 60);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(280, 665);
            sideBar.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 20);
            panel4.Margin = new Padding(3, 20, 3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 25, 0, 0);
            panel4.Size = new Size(280, 70);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-8, -18);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(321, 100);
            button3.TabIndex = 2;
            button3.Text = "        Home";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 96);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 25, 0, 0);
            panel6.Size = new Size(280, 67);
            panel6.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-11, -18);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(321, 100);
            button5.TabIndex = 2;
            button5.Text = "        Orders";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // CategoryMenu
            // 
            CategoryMenu.BackColor = Color.Black;
            CategoryMenu.Controls.Add(panel5);
            CategoryMenu.Controls.Add(panel7);
            CategoryMenu.Controls.Add(panel8);
            CategoryMenu.Location = new Point(3, 169);
            CategoryMenu.Name = "CategoryMenu";
            CategoryMenu.Size = new Size(280, 67);
            CategoryMenu.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(CatMenuBtn);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 25, 0, 0);
            panel5.Size = new Size(280, 70);
            panel5.TabIndex = 6;
            // 
            // CatMenuBtn
            // 
            CatMenuBtn.BackColor = SystemColors.ActiveCaptionText;
            CatMenuBtn.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CatMenuBtn.ForeColor = SystemColors.ControlLightLight;
            CatMenuBtn.Image = (Image)resources.GetObject("CatMenuBtn.Image");
            CatMenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CatMenuBtn.Location = new Point(-15, -16);
            CatMenuBtn.Name = "CatMenuBtn";
            CatMenuBtn.Padding = new Padding(10, 0, 0, 0);
            CatMenuBtn.Size = new Size(321, 100);
            CatMenuBtn.TabIndex = 2;
            CatMenuBtn.Text = "        Category";
            CatMenuBtn.TextAlign = ContentAlignment.MiddleLeft;
            CatMenuBtn.UseVisualStyleBackColor = false;
            CatMenuBtn.Click += CatMenuBtn_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 79);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 25, 0, 0);
            panel7.Size = new Size(280, 55);
            panel7.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-8, -18);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(321, 100);
            button6.TabIndex = 2;
            button6.Text = "             Show All Category";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Controls.Add(button7);
            panel8.Location = new Point(3, 140);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 25, 0, 0);
            panel8.Size = new Size(280, 55);
            panel8.TabIndex = 9;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-8, -18);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(321, 100);
            button7.TabIndex = 2;
            button7.Text = "            Add New Category";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 242);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 25, 0, 0);
            panel2.Size = new Size(280, 67);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-8, -18);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(321, 100);
            button1.TabIndex = 2;
            button1.Text = "        Product";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 315);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 25, 0, 0);
            panel3.Size = new Size(280, 67);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Snap ITC", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-8, -18);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(321, 100);
            button2.TabIndex = 2;
            button2.Text = "        Logout";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // CategoryTransition
            // 
            CategoryTransition.Interval = 10;
            CategoryTransition.Tick += CategoryTransition_Tick;
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 10;
            SideBarTransition.Tick += SideBarTransition_Tick;
            // 
            // AdminPanal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1443, 725);
            Controls.Add(sideBar);
            Controls.Add(panel1);
            Name = "AdminPanal";
            Text = "Admin";
            Load += AdminPanal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).EndInit();
            sideBar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            CategoryMenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox BtnSideBar;
        private FlowLayoutPanel sideBar;
        private Panel panel4;
        private Button button3;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel5;
        private Button CatMenuBtn;
        private FlowLayoutPanel CategoryMenu;
        private Panel panel7;
        private Button button6;
        private Panel panel8;
        private Button button7;
        private Button button5;
        private Panel panel6;
        private System.Windows.Forms.Timer CategoryTransition;
        private System.Windows.Forms.Timer SideBarTransition;
    }
}
