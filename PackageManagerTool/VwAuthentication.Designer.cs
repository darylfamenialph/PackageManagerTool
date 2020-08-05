namespace PackageManagerTool
{
    partial class VwAuthentication
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
            this.pboxbtnAuthenticate = new System.Windows.Forms.PictureBox();
            this.lblbtnClose = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxbtnAuthenticate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxbtnAuthenticate
            // 
            this.pboxbtnAuthenticate.BackColor = System.Drawing.Color.Transparent;
            this.pboxbtnAuthenticate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxbtnAuthenticate.Image = global::PackageManagerTool.Properties.Resources.auth_btn;
            this.pboxbtnAuthenticate.Location = new System.Drawing.Point(40, 148);
            this.pboxbtnAuthenticate.Name = "pboxbtnAuthenticate";
            this.pboxbtnAuthenticate.Size = new System.Drawing.Size(321, 31);
            this.pboxbtnAuthenticate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxbtnAuthenticate.TabIndex = 6;
            this.pboxbtnAuthenticate.TabStop = false;
            this.pboxbtnAuthenticate.Click += new System.EventHandler(this.pboxbtnAuthenticate_Click);
            // 
            // lblbtnClose
            // 
            this.lblbtnClose.AutoSize = true;
            this.lblbtnClose.BackColor = System.Drawing.Color.Transparent;
            this.lblbtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblbtnClose.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnClose.ForeColor = System.Drawing.Color.White;
            this.lblbtnClose.Location = new System.Drawing.Point(372, 3);
            this.lblbtnClose.Name = "lblbtnClose";
            this.lblbtnClose.Size = new System.Drawing.Size(22, 22);
            this.lblbtnClose.TabIndex = 7;
            this.lblbtnClose.Text = "x";
            this.lblbtnClose.Click += new System.EventHandler(this.lblbtnClose_Click);
            // 
            // tboxUsername
            // 
            this.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUsername.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUsername.Location = new System.Drawing.Point(72, 71);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(260, 16);
            this.tboxUsername.TabIndex = 8;
            // 
            // tboxPassword
            // 
            this.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPassword.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPassword.Location = new System.Drawing.Point(72, 105);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(260, 16);
            this.tboxPassword.TabIndex = 9;
            this.tboxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxPassword_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 1);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 1);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 210);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox4.Location = new System.Drawing.Point(423, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 210);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // VwAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PackageManagerTool.Properties.Resources.auth_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 205);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.lblbtnClose);
            this.Controls.Add(this.pboxbtnAuthenticate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VwAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VwAuthentication";
            ((System.ComponentModel.ISupportInitialize)(this.pboxbtnAuthenticate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxbtnAuthenticate;
        private System.Windows.Forms.Label lblbtnClose;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}