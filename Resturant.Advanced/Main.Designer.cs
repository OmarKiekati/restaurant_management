namespace Resturant.Advanced
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Button();
            this.Tables = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 65);
            this.panel1.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(0, 65);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1251, 679);
            this.ControlPanel.TabIndex = 1;
            this.ControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.Settings);
            this.panel3.Controls.Add(this.Tables);
            this.panel3.Controls.Add(this.Products);
            this.panel3.Controls.Add(this.Categories);
            this.panel3.Controls.Add(this.Home);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 679);
            this.panel3.TabIndex = 3;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings.Location = new System.Drawing.Point(38, 433);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(202, 46);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // Tables
            // 
            this.Tables.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Tables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tables.Location = new System.Drawing.Point(38, 367);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(202, 46);
            this.Tables.TabIndex = 5;
            this.Tables.Text = "Tables";
            this.Tables.UseVisualStyleBackColor = false;
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Products.Location = new System.Drawing.Point(38, 296);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(202, 46);
            this.Products.TabIndex = 4;
            this.Products.Text = "Prosucts";
            this.Products.UseVisualStyleBackColor = false;
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Categories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Categories.Location = new System.Drawing.Point(38, 230);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(202, 46);
            this.Categories.TabIndex = 3;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Location = new System.Drawing.Point(38, 161);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(202, 46);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resturant\r\n Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Resturant.Advanced.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(91, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "v";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel ControlPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Tables;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Categories;
    }
}