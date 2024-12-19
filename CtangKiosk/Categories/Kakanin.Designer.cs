namespace CtangKiosk.Categories
{
    partial class Kakanin
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
            this.kakaninflow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // kakaninflow
            // 
            this.kakaninflow.AutoScroll = true;
            this.kakaninflow.BackColor = System.Drawing.Color.Transparent;
            this.kakaninflow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kakaninflow.Location = new System.Drawing.Point(0, 0);
            this.kakaninflow.Name = "kakaninflow";
            this.kakaninflow.Size = new System.Drawing.Size(487, 389);
            this.kakaninflow.TabIndex = 0;
            this.kakaninflow.Paint += new System.Windows.Forms.PaintEventHandler(this.kakaninflow_Paint);
            // 
            // Kakanin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kakaninflow);
            this.Name = "Kakanin";
            this.Size = new System.Drawing.Size(487, 389);
            this.Load += new System.EventHandler(this.Kakanin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel kakaninflow;
    }
}
