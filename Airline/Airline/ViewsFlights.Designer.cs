﻿namespace Airline
{
    partial class ViewsFlights
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
            this.listViewFlights1 = new System.Windows.Forms.ListView();
            this.labelFlights1 = new System.Windows.Forms.Label();
            this.labelSearch2 = new System.Windows.Forms.Label();
            this.labelRoute3 = new System.Windows.Forms.Label();
            this.textBoxRoute1 = new System.Windows.Forms.TextBox();
            this.buttonSearch1 = new System.Windows.Forms.Button();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFlights1
            // 
            this.listViewFlights1.Location = new System.Drawing.Point(12, 77);
            this.listViewFlights1.Name = "listViewFlights1";
            this.listViewFlights1.Size = new System.Drawing.Size(266, 215);
            this.listViewFlights1.TabIndex = 0;
            this.listViewFlights1.UseCompatibleStateImageBehavior = false;
            // 
            // labelFlights1
            // 
            this.labelFlights1.AutoSize = true;
            this.labelFlights1.Location = new System.Drawing.Point(107, 43);
            this.labelFlights1.Name = "labelFlights1";
            this.labelFlights1.Size = new System.Drawing.Size(39, 13);
            this.labelFlights1.TabIndex = 1;
            this.labelFlights1.Text = "Vuelos";
            // 
            // labelSearch2
            // 
            this.labelSearch2.AutoSize = true;
            this.labelSearch2.Location = new System.Drawing.Point(310, 90);
            this.labelSearch2.Name = "labelSearch2";
            this.labelSearch2.Size = new System.Drawing.Size(121, 13);
            this.labelSearch2.TabIndex = 2;
            this.labelSearch2.Text = "Buscar o eliminar vuelos";
            // 
            // labelRoute3
            // 
            this.labelRoute3.AutoSize = true;
            this.labelRoute3.Location = new System.Drawing.Point(295, 131);
            this.labelRoute3.Name = "labelRoute3";
            this.labelRoute3.Size = new System.Drawing.Size(36, 13);
            this.labelRoute3.TabIndex = 3;
            this.labelRoute3.Text = "Ruta: ";
            // 
            // textBoxRoute1
            // 
            this.textBoxRoute1.Location = new System.Drawing.Point(337, 124);
            this.textBoxRoute1.Name = "textBoxRoute1";
            this.textBoxRoute1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoute1.TabIndex = 4;
            // 
            // buttonSearch1
            // 
            this.buttonSearch1.Location = new System.Drawing.Point(298, 159);
            this.buttonSearch1.Name = "buttonSearch1";
            this.buttonSearch1.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch1.TabIndex = 5;
            this.buttonSearch1.Text = "Buscar";
            this.buttonSearch1.UseVisualStyleBackColor = true;
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.Location = new System.Drawing.Point(380, 158);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete2.TabIndex = 6;
            this.buttonDelete2.Text = "Eliminar";
            this.buttonDelete2.UseVisualStyleBackColor = true;
            // 
            // ViewsFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 355);
            this.Controls.Add(this.buttonDelete2);
            this.Controls.Add(this.buttonSearch1);
            this.Controls.Add(this.textBoxRoute1);
            this.Controls.Add(this.labelRoute3);
            this.Controls.Add(this.labelSearch2);
            this.Controls.Add(this.labelFlights1);
            this.Controls.Add(this.listViewFlights1);
            this.Name = "ViewsFlights";
            this.Text = "ViewsFlights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFlights1;
        private System.Windows.Forms.Label labelFlights1;
        private System.Windows.Forms.Label labelSearch2;
        private System.Windows.Forms.Label labelRoute3;
        private System.Windows.Forms.TextBox textBoxRoute1;
        private System.Windows.Forms.Button buttonSearch1;
        private System.Windows.Forms.Button buttonDelete2;
    }
}