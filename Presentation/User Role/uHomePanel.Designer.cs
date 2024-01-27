namespace Presentation.User_Role
{
    partial class uHomePanel
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
            ProductsDGV = new DataGridView();
            Success = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 31);
            label1.TabIndex = 0;
            label1.Text = "Customer Home page";
            // 
            // ProductsDGV
            // 
            ProductsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDGV.Location = new Point(25, 117);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 51;
            ProductsDGV.Size = new Size(1087, 293);
            ProductsDGV.TabIndex = 1;
            ProductsDGV.CellClick += ProductsDGV_CellClick;
            // 
            // Success
            // 
            Success.AutoSize = true;
            Success.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Success.Location = new Point(288, 70);
            Success.Name = "Success";
            Success.Size = new Size(0, 35);
            Success.TabIndex = 2;
            // 
            // uHomePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 736);
            Controls.Add(Success);
            Controls.Add(ProductsDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "uHomePanel";
            Text = "uHomePanel";
            Load += uHomePanel_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ProductsDGV;
        private Label Success;
    }
}