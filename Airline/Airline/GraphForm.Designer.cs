﻿namespace Airline
{
    partial class GraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.panelMap = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMap.BackgroundImage")));
            this.panelMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMap.Location = new System.Drawing.Point(12, 23);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(938, 540);
            this.panelMap.TabIndex = 0;
            this.panelMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMap_MouseClick);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 592);
            this.Controls.Add(this.panelMap);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
    }
}