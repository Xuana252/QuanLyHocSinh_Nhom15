﻿namespace QuanLyHocSinh_Nhom15
{
    partial class ThongBaoForm
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
            this.ErrorOKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorOKButton
            // 
            this.ErrorOKButton.BackColor = System.Drawing.Color.Teal;
            this.ErrorOKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ErrorOKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorOKButton.FlatAppearance.BorderSize = 0;
            this.ErrorOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorOKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorOKButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ErrorOKButton.Location = new System.Drawing.Point(20, 250);
            this.ErrorOKButton.Name = "ErrorOKButton";
            this.ErrorOKButton.Size = new System.Drawing.Size(360, 30);
            this.ErrorOKButton.TabIndex = 0;
            this.ErrorOKButton.TabStop = false;
            this.ErrorOKButton.Text = "OK";
            this.ErrorOKButton.UseVisualStyleBackColor = false;
            this.ErrorOKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.MaximumSize = new System.Drawing.Size(360, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "text will change depends on bugs ";
            // 
            // FormLabel
            // 
            this.FormLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormLabel.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.SuccessIcon;
            this.FormLabel.Location = new System.Drawing.Point(136, 8);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(134, 40);
            this.FormLabel.TabIndex = 1;
            this.FormLabel.Text = "!!!      !!!";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongBaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.ErrorOKButton);
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "ThongBaoForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "!!!Error!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ErrorOKButton;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Label label1;
    }
}