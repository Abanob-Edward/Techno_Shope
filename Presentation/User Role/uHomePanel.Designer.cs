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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uHomePanel));
            label1 = new Label();
            ProductsDGV = new DataGridView();
            Success = new Label();
            NextBtn = new Button();
            previousBtn = new Button();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            Search = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 10, 42, 155);
            label1.Font = new Font("Monotype Corsiva", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 42, 81);
            label1.Location = new Point(482, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 39);
            label1.TabIndex = 0;
            label1.Text = "Customer Home page";
            // 
            // ProductsDGV
            // 
            ProductsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDGV.BackgroundColor = Color.Linen;
            ProductsDGV.BorderStyle = BorderStyle.Fixed3D;
            ProductsDGV.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            ProductsDGV.Location = new Point(36, 135);
            ProductsDGV.Margin = new Padding(4);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.RowHeadersWidth = 51;
            ProductsDGV.RowTemplate.Height = 120;
            ProductsDGV.Size = new Size(1450, 685);
            ProductsDGV.TabIndex = 1;
            ProductsDGV.CellClick += ProductsDGV_CellClick;
            // 
            // Success
            // 
            Success.AutoSize = true;
            Success.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Success.ForeColor = Color.Green;
            Success.Location = new Point(1051, 75);
            Success.Margin = new Padding(4, 0, 4, 0);
            Success.Name = "Success";
            Success.Size = new Size(0, 44);
            Success.TabIndex = 2;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(33, 42, 81);
            NextBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(810, 828);
            NextBtn.Margin = new Padding(4);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(200, 74);
            NextBtn.TabIndex = 3;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // previousBtn
            // 
            previousBtn.BackColor = Color.FromArgb(33, 42, 81);
            previousBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousBtn.ForeColor = Color.White;
            previousBtn.Location = new Point(482, 828);
            previousBtn.Margin = new Padding(4);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(179, 78);
            previousBtn.TabIndex = 4;
            previousBtn.Text = "Pervious";
            previousBtn.UseVisualStyleBackColor = false;
            previousBtn.Click += previousBtn_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(969, 9);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(456, 45);
            panel7.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(848, 82);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(194, 82);
            searchBox.Margin = new Padding(4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(646, 31);
            searchBox.TabIndex = 5;
            searchBox.TextChanged += textBox1_TextChanged;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.BackColor = Color.Transparent;
            Search.Font = new Font("Monotype Corsiva", 16F, FontStyle.Bold | FontStyle.Italic);
            Search.ForeColor = Color.Navy;
            Search.Location = new Point(64, 77);
            Search.Margin = new Padding(4, 0, 4, 0);
            Search.Name = "Search";
            Search.Size = new Size(114, 39);
            Search.TabIndex = 3;
            Search.Text = "Search :";
            // 
            // uHomePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 172, 148);
            ClientSize = new Size(1501, 920);
            Controls.Add(Success);
            Controls.Add(pictureBox1);
            Controls.Add(panel7);
            Controls.Add(searchBox);
            Controls.Add(previousBtn);
            Controls.Add(Search);
            Controls.Add(NextBtn);
            Controls.Add(ProductsDGV);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "uHomePanel";
            Text = "uHomePanel";
            Load += uHomePanel_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ProductsDGV;
        private Label Success;
        private Button NextBtn;
        private Button previousBtn;
        private Panel panel7;
        private PictureBox pictureBox1;
        private TextBox searchBox;
        private Label Search;
    }
}