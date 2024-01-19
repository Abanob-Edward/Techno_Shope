namespace Presentation
{
    partial class Category
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
            label2 = new Label();
            textBox1 = new TextBox();
            textbox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox3 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 0;
            label1.Text = "Catagory Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 1;
            label2.Text = "Category Type";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 25);
            textBox1.TabIndex = 3;
            // 
            // textbox2
            // 
            textbox2.Location = new Point(185, 85);
            textbox2.Name = "textbox2";
            textbox2.Size = new Size(105, 25);
            textbox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(51, 306);
            button1.Name = "button1";
            button1.Size = new Size(79, 24);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 308);
            button2.Name = "button2";
            button2.Size = new Size(79, 24);
            button2.TabIndex = 7;
            button2.Text = "Delet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(346, 306);
            button3.Name = "button3";
            button3.Size = new Size(79, 24);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(478, 308);
            button4.Name = "button4";
            button4.Size = new Size(79, 24);
            button4.TabIndex = 9;
            button4.Text = "Get All";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(423, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 43;
            dataGridView1.Size = new Size(252, 158);
            dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 160);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 11;
            label3.Text = "Category id";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(105, 25);
            textBox3.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(626, 306);
            button5.Name = "button5";
            button5.Size = new Size(79, 24);
            button5.TabIndex = 13;
            button5.Text = "GitById";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textbox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Category";
            Text = "Catgory";
            Load += Category_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textbox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox3;
        private Button button5;
    }
}