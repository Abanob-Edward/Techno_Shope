namespace Presentation
{
    partial class AllOrdersPanal
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
            AllOrdersDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AllOrdersDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(516, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 45);
            label1.TabIndex = 0;
            label1.Text = "View All orders";
            // 
            // AllOrdersDGV
            // 
            AllOrdersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllOrdersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllOrdersDGV.Location = new Point(44, 104);
            AllOrdersDGV.Margin = new Padding(4, 4, 4, 4);
            AllOrdersDGV.Name = "AllOrdersDGV";
            AllOrdersDGV.RowHeadersWidth = 51;
            AllOrdersDGV.Size = new Size(1274, 704);
            AllOrdersDGV.TabIndex = 1;
            // 
            // AllOrdersPanal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 862);
            Controls.Add(AllOrdersDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "AllOrdersPanal";
            Text = "AllOrdersPanal";
            ((System.ComponentModel.ISupportInitialize)AllOrdersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView AllOrdersDGV;
    }
}