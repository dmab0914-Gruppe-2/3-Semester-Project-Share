﻿namespace ClientApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblProject = new System.Windows.Forms.Label();
            this.panelCenterBottom = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelCenterTop = new System.Windows.Forms.Panel();
            this.lblChat = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelCenterBottom.SuspendLayout();
            this.panelCenterTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.Controls.Add(this.lblProject);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(235, 561);
            this.panelLeft.TabIndex = 0;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(43, 9);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(140, 37);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "Projects";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCenterBottom
            // 
            this.panelCenterBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCenterBottom.Controls.Add(this.btnUpload);
            this.panelCenterBottom.Location = new System.Drawing.Point(241, 209);
            this.panelCenterBottom.Name = "panelCenterBottom";
            this.panelCenterBottom.Size = new System.Drawing.Size(373, 352);
            this.panelCenterBottom.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Location = new System.Drawing.Point(620, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(361, 561);
            this.panelRight.TabIndex = 0;
            // 
            // panelCenterTop
            // 
            this.panelCenterTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCenterTop.Controls.Add(this.lblChat);
            this.panelCenterTop.Location = new System.Drawing.Point(241, 0);
            this.panelCenterTop.Name = "panelCenterTop";
            this.panelCenterTop.Size = new System.Drawing.Size(373, 203);
            this.panelCenterTop.TabIndex = 0;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(146, 9);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(89, 37);
            this.lblChat.TabIndex = 0;
            this.lblChat.Text = "Chat";
            this.lblChat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(3, 26);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload new file";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelCenterTop);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelCenterBottom);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectShare";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelCenterBottom.ResumeLayout(false);
            this.panelCenterTop.ResumeLayout(false);
            this.panelCenterTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelCenterBottom;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Panel panelCenterTop;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Button btnUpload;
    }
}
