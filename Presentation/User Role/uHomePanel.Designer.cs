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
            NextBtn = new Button();
            previousBtn = new Button();
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
            ProductsDGV.Location = new Point(32, 57);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 51;
            ProductsDGV.Size = new Size(1087, 293);
            ProductsDGV.TabIndex = 1;
            ProductsDGV.CellClick += ProductsDGV_CellClick;
            ProductsDGV.CellContentClick += ProductsDGV_CellContentClick;
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
            // NextBtn
            // 
            NextBtn.Location = new Point(288, 389);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(147, 54);
            NextBtn.TabIndex = 3;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(563, 389);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(138, 54);
            previousBtn.TabIndex = 4;
            previousBtn.Text = "Previou";
            previousBtn.UseVisualStyleBackColor = true;
            previousBtn.Click += previousBtn_Click;
            // 
            // uHomePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 736);
            Controls.Add(previousBtn);
            Controls.Add(NextBtn);
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
        private Button NextBtn;
        private Button previousBtn;
    }
}