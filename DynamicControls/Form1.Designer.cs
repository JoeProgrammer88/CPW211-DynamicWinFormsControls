﻿namespace DynamicControls
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateButtons = new System.Windows.Forms.Button();
            this.flpDynamicControls = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCreateButtons
            // 
            this.btnCreateButtons.Location = new System.Drawing.Point(327, 354);
            this.btnCreateButtons.Name = "btnCreateButtons";
            this.btnCreateButtons.Size = new System.Drawing.Size(133, 64);
            this.btnCreateButtons.TabIndex = 0;
            this.btnCreateButtons.Text = "Add More Buttons";
            this.btnCreateButtons.UseVisualStyleBackColor = true;
            this.btnCreateButtons.Click += new System.EventHandler(this.btnCreateButtons_Click);
            // 
            // flpDynamicControls
            // 
            this.flpDynamicControls.Location = new System.Drawing.Point(12, 12);
            this.flpDynamicControls.Name = "flpDynamicControls";
            this.flpDynamicControls.Size = new System.Drawing.Size(776, 336);
            this.flpDynamicControls.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpDynamicControls);
            this.Controls.Add(this.btnCreateButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateButtons;
        private FlowLayoutPanel flpDynamicControls;
    }
}