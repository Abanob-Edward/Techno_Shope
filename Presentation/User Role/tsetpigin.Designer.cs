namespace Presentation.User_Role
{
    partial class tsetpigin
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
            next = new Button();
            previou = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 251);
            dataGridView1.TabIndex = 0;
            // 
            // next
            // 
            next.Location = new Point(202, 390);
            next.Name = "next";
            next.Size = new Size(94, 29);
            next.TabIndex = 1;
            next.Text = "next";
            next.UseVisualStyleBackColor = true;
            next.Click += Next_Click;
            // 
            // previou
            // 
            previou.Location = new Point(450, 390);
            previou.Name = "previou";
            previou.Size = new Size(94, 29);
            previou.TabIndex = 2;
            previou.Text = "previous";
            previou.UseVisualStyleBackColor = true;
            previou.Click += previous_Click;
            // 
            // tsetpigin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(previou);
            Controls.Add(next);
            Controls.Add(dataGridView1);
            Name = "tsetpigin";
            Text = "tsetpigin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button next;
        private Button previou;
    }
}