﻿namespace Presentation.User_Role
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
            CartItemDGV.Location = new Point(43, 58);
            CartItemDGV.Name = "CartItemDGV";
            CartItemDGV.RowHeadersWidth = 51;
            CartItemDGV.Size = new Size(1083, 566);
            CartItemDGV.TabIndex = 1;
            // 
            // CartItemPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 736);
            Controls.Add(CartItemDGV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CartItemPanel";
            Text = "CartItemPanel";
            ((System.ComponentModel.ISupportInitialize)CartItemDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView CartItemDGV;
    }
}