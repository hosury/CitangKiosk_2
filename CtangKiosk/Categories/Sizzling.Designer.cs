namespace CtangKiosk.Categories
{
    partial class Sizzling
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sizzlingflow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // sizzlingflow
            // 
            this.sizzlingflow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizzlingflow.Location = new System.Drawing.Point(0, 0);
            this.sizzlingflow.Name = "sizzlingflow";
            this.sizzlingflow.Size = new System.Drawing.Size(487, 389);
            this.sizzlingflow.TabIndex = 2;
            this.sizzlingflow.Paint += new System.Windows.Forms.PaintEventHandler(this.sizzlingflow_Paint);
            // 
            // Sizzling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sizzlingflow);
            this.Controls.Add(this.label1);
            this.Name = "Sizzling";
            this.Size = new System.Drawing.Size(487, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sizzlingflow;
    }
}
