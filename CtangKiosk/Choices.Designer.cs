namespace CtangKiosk
{
    partial class Choices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choices));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewObtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TPriceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Takebtn = new System.Windows.Forms.Button();
            this.Dinebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ViewObtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 164);
            this.panel1.TabIndex = 2;
            // 
            // ViewObtn
            // 
            this.ViewObtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ViewObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.ViewObtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewObtn.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewObtn.ForeColor = System.Drawing.Color.Maroon;
            this.ViewObtn.Location = new System.Drawing.Point(69, 50);
            this.ViewObtn.Name = "ViewObtn";
            this.ViewObtn.Size = new System.Drawing.Size(264, 75);
            this.ViewObtn.TabIndex = 2;
            this.ViewObtn.Text = "Back";
            this.ViewObtn.UseVisualStyleBackColor = false;
            this.ViewObtn.Click += new System.EventHandler(this.ViewObtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TPriceTB);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.groupBox1.Location = new System.Drawing.Point(415, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Price";
            // 
            // TPriceTB
            // 
            this.TPriceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPriceTB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPriceTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.TPriceTB.Location = new System.Drawing.Point(16, 34);
            this.TPriceTB.Name = "TPriceTB";
            this.TPriceTB.Size = new System.Drawing.Size(234, 21);
            this.TPriceTB.TabIndex = 3;
            this.TPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TPriceTB.TextChanged += new System.EventHandler(this.TPriceTB_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(266, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where to Eat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Takebtn
            // 
            this.Takebtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Takebtn.BackColor = System.Drawing.Color.Maroon;
            this.Takebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Takebtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Takebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.Takebtn.Location = new System.Drawing.Point(416, 238);
            this.Takebtn.Name = "Takebtn";
            this.Takebtn.Size = new System.Drawing.Size(264, 75);
            this.Takebtn.TabIndex = 6;
            this.Takebtn.Text = "Take Out";
            this.Takebtn.UseVisualStyleBackColor = false;
            this.Takebtn.Click += new System.EventHandler(this.Takebtn_Click);
            // 
            // Dinebtn
            // 
            this.Dinebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Dinebtn.BackColor = System.Drawing.Color.Maroon;
            this.Dinebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dinebtn.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dinebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.Dinebtn.Location = new System.Drawing.Point(70, 238);
            this.Dinebtn.Name = "Dinebtn";
            this.Dinebtn.Size = new System.Drawing.Size(264, 75);
            this.Dinebtn.TabIndex = 5;
            this.Dinebtn.Text = "Dine In";
            this.Dinebtn.UseVisualStyleBackColor = false;
            this.Dinebtn.Click += new System.EventHandler(this.Dinebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CtangKiosk.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(310, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Choices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.Takebtn);
            this.Controls.Add(this.Dinebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Choices";
            this.Text = "Choices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewObtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Takebtn;
        private System.Windows.Forms.Button Dinebtn;
        private System.Windows.Forms.TextBox TPriceTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}