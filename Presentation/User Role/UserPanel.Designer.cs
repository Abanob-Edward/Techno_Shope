namespace Presentation.User_Role
{
    partial class Castumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Castumer));
            panel1 = new Panel();
            AdminName = new Label();
            label1 = new Label();
            BtnSideBar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AdminName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnSideBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1531, 60);
            panel1.TabIndex = 1;
            // 
            // AdminName
            // 
            AdminName.AutoSize = true;
            AdminName.BackColor = Color.White;
            AdminName.Font = new Font("Stencil", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AdminName.ForeColor = Color.Navy;
            AdminName.Location = new Point(1002, 9);
            AdminName.Name = "AdminName";
            AdminName.Size = new Size(0, 40);
            AdminName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
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
            // 
            // Castumer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 743);
            Controls.Add(panel1);
            Name = "Castumer";
            Text = "UserPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSideBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AdminName;
        private Label label1;
        private PictureBox BtnSideBar;
    }
}