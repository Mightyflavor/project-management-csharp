﻿namespace Productivity_Nexus.Components
{
    partial class Projects_in_progress_parent
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.projects_in_progress1 = new Productivity_Nexus.Components.Projects_in_progress();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.projects_in_progress1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(737, 453);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // projects_in_progress1
            // 
            this.projects_in_progress1.ItemDescription = "label1";
            this.projects_in_progress1.ItemName = "label1";
            this.projects_in_progress1.Location = new System.Drawing.Point(3, 3);
            this.projects_in_progress1.Name = "projects_in_progress1";
            this.projects_in_progress1.Size = new System.Drawing.Size(260, 144);
            this.projects_in_progress1.TabIndex = 0;
            this.projects_in_progress1.Load += new System.EventHandler(this.projects_in_progress1_Load);
            // 
            // Projects_in_progress_parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Projects_in_progress_parent";
            this.Size = new System.Drawing.Size(737, 453);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Projects_in_progress projects_in_progress1;
    }
}
