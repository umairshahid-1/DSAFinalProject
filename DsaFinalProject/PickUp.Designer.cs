﻿namespace DsaFinalProject
{
    partial class PickUp
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
            this.SuspendLayout();
            // 
            // PickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DsaFinalProject.Properties.Resources.kumiko_shimizu_GfXyyrvGqzs_unsplash;
            this.ClientSize = new System.Drawing.Size(695, 352);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PickUp";
            this.Text = "PickUp";
            this.Load += new System.EventHandler(this.PickUp_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}