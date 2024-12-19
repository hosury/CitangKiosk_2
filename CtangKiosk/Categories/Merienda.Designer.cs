namespace CtangKiosk.Categories
{
    partial class Merienda
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
            this.meriendaflow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // meriendaflow
            // 
            this.meriendaflow.AutoScroll = true;
            this.meriendaflow.BackColor = System.Drawing.Color.Transparent;
            this.meriendaflow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meriendaflow.Location = new System.Drawing.Point(0, 0);
            this.meriendaflow.Name = "meriendaflow";
            this.meriendaflow.Size = new System.Drawing.Size(487, 389);
            this.meriendaflow.TabIndex = 1;
            this.meriendaflow.Paint += new System.Windows.Forms.PaintEventHandler(this.meriendaflow_Paint);
            // 
            // Merienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.meriendaflow);
            this.Name = "Merienda";
            this.Size = new System.Drawing.Size(487, 389);
            this.Load += new System.EventHandler(this.Merienda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel meriendaflow;
    }
}
