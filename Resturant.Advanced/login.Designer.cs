namespace Resturant.Advanced
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sigin = new System.Windows.Forms.Button();
            this.exite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 187);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Resturant.Advanced.Properties.Resources.download3;
            this.pictureBox1.Location = new System.Drawing.Point(115, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 115);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please Enter Your Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(66, 262);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(212, 30);
            this.user.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(66, 358);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(212, 30);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // sigin
            // 
            this.sigin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sigin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sigin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sigin.Location = new System.Drawing.Point(67, 423);
            this.sigin.Name = "sigin";
            this.sigin.Size = new System.Drawing.Size(75, 34);
            this.sigin.TabIndex = 5;
            this.sigin.Text = "Login";
            this.sigin.UseVisualStyleBackColor = false;
            this.sigin.Click += new System.EventHandler(this.sigin_Click);
            // 
            // exite
            // 
            this.exite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exite.Location = new System.Drawing.Point(203, 423);
            this.exite.Name = "exite";
            this.exite.Size = new System.Drawing.Size(75, 34);
            this.exite.TabIndex = 6;
            this.exite.Text = "Back";
            this.exite.UseVisualStyleBackColor = false;
            this.exite.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(368, 534);
            this.Controls.Add(this.exite);
            this.Controls.Add(this.sigin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sigin;
        private System.Windows.Forms.Button exite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

