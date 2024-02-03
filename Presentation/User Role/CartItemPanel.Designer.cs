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
            OrderAll = new Button();
            label2 = new Label();
            OrderTotalprice = new Label();
            Reload = new Button();
            ((System.ComponentModel.ISupportInitialize)CartItemDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 42, 81);
            label1.Location = new Point(609, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 32);
            label1.TabIndex = 0;
            label1.Text = "product In cart item";
            // 
            // CartItemDGV
            // 
            CartItemDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CartItemDGV.BackgroundColor = Color.Linen;
            CartItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartItemDGV.Location = new Point(42, 72);
            CartItemDGV.Margin = new Padding(4);
            CartItemDGV.Name = "CartItemDGV";
            CartItemDGV.RowHeadersWidth = 51;
            CartItemDGV.Size = new Size(1409, 600);
            CartItemDGV.TabIndex = 1;
            CartItemDGV.CellContentClick += CartItemDGV_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 42, 81);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(852, 694);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(189, 72);
            button1.TabIndex = 2;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 42, 81);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(439, 694);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(191, 72);
            button2.TabIndex = 3;
            button2.Text = "previous";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // OrderAll
            // 
            OrderAll.BackColor = Color.FromArgb(33, 42, 81);
            OrderAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderAll.ForeColor = SystemColors.ControlLight;
            OrderAll.Location = new Point(15, 792);
            OrderAll.Margin = new Padding(4);
            OrderAll.Name = "OrderAll";
            OrderAll.Size = new Size(194, 66);
            OrderAll.TabIndex = 4;
            OrderAll.Text = "Order now";
            OrderAll.UseVisualStyleBackColor = false;
            OrderAll.Click += OrderAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(33, 42, 81);
            label2.Location = new Point(266, 818);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(260, 38);
            label2.TabIndex = 5;
            label2.Text = "Order Total price :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderTotalprice
            // 
            OrderTotalprice.AutoSize = true;
            OrderTotalprice.Location = new Point(490, 831);
            OrderTotalprice.Margin = new Padding(4, 0, 4, 0);
            OrderTotalprice.Name = "OrderTotalprice";
            OrderTotalprice.Size = new Size(0, 25);
            OrderTotalprice.TabIndex = 6;
            // 
            // Reload
            // 
            Reload.Location = new Point(967, 586);
            Reload.Name = "Reload";
            Reload.Size = new Size(94, 29);
            Reload.TabIndex = 7;
            Reload.Text = "R";
            Reload.UseVisualStyleBackColor = true;
            Reload.Click += Reload_Click;
            // 
            // CartItemPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 172, 148);
            ClientSize = new Size(1201, 736);
            Controls.Add(Reload);
            Controls.Add(OrderTotalprice);
            Controls.Add(label2);
            Controls.Add(OrderAll);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CartItemDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
        private Button OrderAll;
        private Label label2;
        private Label OrderTotalprice;
        private Button Reload;
    }
}