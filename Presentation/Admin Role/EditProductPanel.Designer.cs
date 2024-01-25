namespace Presentation
{
    partial class EditProductPanel
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            Error = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(903, 290);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += ProdactDGV_RowHeaderMouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(214, 90, 49);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(238, 238, 238);
            button1.Location = new Point(367, 581);
            button1.Name = "button1";
            button1.Size = new Size(120, 49);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Proudect_delet;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(214, 90, 49);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(238, 238, 238);
            button2.Location = new Point(616, 581);
            button2.Name = "button2";
            button2.Size = new Size(128, 49);
            button2.TabIndex = 2;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += proudect_Edite;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 374);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(214, 90, 49);
            label2.Location = new Point(25, 377);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(417, 374);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(417, 470);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(741, 377);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(750, 473);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 27);
            textBox6.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(214, 90, 49);
            label3.Location = new Point(333, 374);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 11;
            label3.Text = "Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(214, 90, 49);
            label4.Location = new Point(333, 466);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 12;
            label4.Text = "Title :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(214, 90, 49);
            label5.Location = new Point(660, 380);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 13;
            label5.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(214, 90, 49);
            label6.Location = new Point(650, 473);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 14;
            label6.Text = "image :";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(122, 464);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(194, 27);
            textBox7.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(214, 90, 49);
            label7.Location = new Point(0, 466);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 16;
            label7.Text = "Descraption:";
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Error.ForeColor = Color.FromArgb(192, 0, 0);
            Error.Location = new Point(432, 318);
            Error.Name = "Error";
            Error.Size = new Size(25, 38);
            Error.TabIndex = 17;
            Error.Text = " ";
            // 
            // EditProductPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1102, 690);
            Controls.Add(Error);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProductPanel";
            Text = "ProductOutOfStocK";
            Load += Product_load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label Error;
    }
}