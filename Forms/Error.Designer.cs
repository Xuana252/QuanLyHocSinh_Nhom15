namespace QuanLyHocSinh_Nhom15
{
    partial class Error
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorOKButton
            // 
            this.ErrorOKButton.BackColor = System.Drawing.Color.Teal;
            this.ErrorOKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorOKButton.FlatAppearance.BorderSize = 0;
            this.ErrorOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorOKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorOKButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ErrorOKButton.Location = new System.Drawing.Point(20, 146);
            this.ErrorOKButton.Name = "ErrorOKButton";
            this.ErrorOKButton.Size = new System.Drawing.Size(251, 30);
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
            this.label1.MaximumSize = new System.Drawing.Size(247, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "text will change depends on bugs ";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Image = global::QuanLyHocSinh_Nhom15.Properties.Resources.ErrorIcon;
            this.ErrorLabel.Location = new System.Drawing.Point(81, 8);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(134, 40);
            this.ErrorLabel.TabIndex = 1;
            this.ErrorLabel.Text = "!!!      !!!";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(291, 196);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ErrorOKButton);
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "Error";
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
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label1;
    }
}