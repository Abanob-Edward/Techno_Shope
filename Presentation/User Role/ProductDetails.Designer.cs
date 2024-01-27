namespace Presentation.User_Role
{
    partial class ProductDetails
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
            label1 = new Label();
            Idlabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(443, 25);
            label1.Name = "label1";
            label1.Size = new Size(175, 31);
            label1.TabIndex = 0;
            label1.Text = "Product Detiles";
            // 
            // Idlabel
            // 
            Idlabel.AutoSize = true;
            Idlabel.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Idlabel.ForeColor = Color.IndianRed;
            Idlabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            Idlabel.Location = new Point(463, 271);
            Idlabel.Name = "Idlabel";
            Idlabel.Size = new Size(56, 20);
            Idlabel.TabIndex = 1;
            Idlabel.Text = "label2";
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 736);
            Controls.Add(Idlabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductDetails";
            Text = "userPrfielPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Idlabel;
    }
}