namespace Presentation.User_Role
{
    partial class CartItemPanel
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
            CartItemDGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)CartItemDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(487, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 31);
            label1.TabIndex = 0;
            label1.Text = "product In cart item";
            // 
            // CartItemDGV
            // 
            CartItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartItemDGV.Location = new Point(12, 55);
            CartItemDGV.Name = "CartItemDGV";
            CartItemDGV.RowHeadersWidth = 51;
            CartItemDGV.Size = new Size(1038, 480);
            CartItemDGV.TabIndex = 1;
           
            // 
            // button1
            // 
            button1.Location = new Point(330, 650);
            button1.Name = "button1";
            button1.Size = new Size(112, 53);
            button1.TabIndex = 2;
            button1.Text = "NextBtn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(531, 650);
            button2.Name = "button2";
            button2.Size = new Size(115, 53);
            button2.TabIndex = 3;
            button2.Text = "previousBtn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CartItemPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 736);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CartItemDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CartItemPanel";
            Text = "CartItemPanel";
            Load += CartItemPanel_Load;
            ((System.ComponentModel.ISupportInitialize)CartItemDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView CartItemDGV;
        private Button button1;
        private Button button2;
    }
}