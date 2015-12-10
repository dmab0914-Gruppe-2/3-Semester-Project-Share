namespace ClientApp
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
            this.listView_Projects = new System.Windows.Forms.ListView();
            this.button_ProjectAdministration = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.Label();
            this.panelCenterBottom = new System.Windows.Forms.Panel();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnRefreshFiles = new System.Windows.Forms.Button();
            this.lblFIles = new System.Windows.Forms.Label();
            this.lwFiles = new System.Windows.Forms.ListView();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.button_SendFilechat = new System.Windows.Forms.Button();
            this.listBox_Filechat = new System.Windows.Forms.ListBox();
            this.richTextBox_Filechat = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtFileDesc = new System.Windows.Forms.TextBox();
            this.lblFIleInfo = new System.Windows.Forms.Label();
            this.panelCenterTop = new System.Windows.Forms.Panel();
            this.lblNotImplementedWarning = new System.Windows.Forms.Label();
            this.button_Chat_send = new System.Windows.Forms.Button();
            this.richTextBoxChatmessage = new System.Windows.Forms.RichTextBox();
            this.listChatMessages = new System.Windows.Forms.ListBox();
            this.lblChat = new System.Windows.Forms.Label();
            this.ChatFileDivider = new System.Windows.Forms.Label();
            this.ProjectsChatFileDevider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Users = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelCenterBottom.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelCenterTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.Controls.Add(this.listView_Projects);
            this.panelLeft.Controls.Add(this.button_ProjectAdministration);
            this.panelLeft.Controls.Add(this.lblProject);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(227, 561);
            this.panelLeft.TabIndex = 0;
            // 
            // listView_Projects
            // 
            this.listView_Projects.Location = new System.Drawing.Point(12, 49);
            this.listView_Projects.Name = "listView_Projects";
            this.listView_Projects.Size = new System.Drawing.Size(212, 205);
            this.listView_Projects.TabIndex = 2;
            this.listView_Projects.UseCompatibleStateImageBehavior = false;
            this.listView_Projects.ItemActivate += new System.EventHandler(this.listView_Projects_ItemActivate);
            // 
            // button_ProjectAdministration
            // 
            this.button_ProjectAdministration.Location = new System.Drawing.Point(12, 268);
            this.button_ProjectAdministration.Name = "button_ProjectAdministration";
            this.button_ProjectAdministration.Size = new System.Drawing.Size(212, 23);
            this.button_ProjectAdministration.TabIndex = 1;
            this.button_ProjectAdministration.Text = "Project Administration";
            this.button_ProjectAdministration.UseVisualStyleBackColor = true;
            this.button_ProjectAdministration.Click += new System.EventHandler(this.button_ProjectAdministration_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(46, 9);
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
            this.panelCenterBottom.Controls.Add(this.btnMulti);
            this.panelCenterBottom.Controls.Add(this.btnRefreshFiles);
            this.panelCenterBottom.Controls.Add(this.lblFIles);
            this.panelCenterBottom.Controls.Add(this.lwFiles);
            this.panelCenterBottom.Controls.Add(this.btnUpload);
            this.panelCenterBottom.Location = new System.Drawing.Point(241, 209);
            this.panelCenterBottom.Name = "panelCenterBottom";
            this.panelCenterBottom.Size = new System.Drawing.Size(373, 352);
            this.panelCenterBottom.TabIndex = 1;
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(250, 30);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(120, 23);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "Upload multi";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnRefreshFiles
            // 
            this.btnRefreshFiles.Location = new System.Drawing.Point(3, 30);
            this.btnRefreshFiles.Name = "btnRefreshFiles";
            this.btnRefreshFiles.Size = new System.Drawing.Size(120, 23);
            this.btnRefreshFiles.TabIndex = 2;
            this.btnRefreshFiles.Text = "Refresh Files";
            this.btnRefreshFiles.UseVisualStyleBackColor = true;
            this.btnRefreshFiles.Click += new System.EventHandler(this.btnRefreshFiles_Click);
            // 
            // lblFIles
            // 
            this.lblFIles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFIles.AutoSize = true;
            this.lblFIles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFIles.Location = new System.Drawing.Point(52, 2);
            this.lblFIles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblFIles.MaximumSize = new System.Drawing.Size(270, 0);
            this.lblFIles.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblFIles.Name = "lblFIles";
            this.lblFIles.Size = new System.Drawing.Size(270, 25);
            this.lblFIles.TabIndex = 4;
            this.lblFIles.Text = "Select project to see files";
            this.lblFIles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lwFiles
            // 
            this.lwFiles.Location = new System.Drawing.Point(3, 59);
            this.lwFiles.Name = "lwFiles";
            this.lwFiles.Size = new System.Drawing.Size(367, 290);
            this.lwFiles.TabIndex = 3;
            this.lwFiles.UseCompatibleStateImageBehavior = false;
            this.lwFiles.ItemActivate += new System.EventHandler(this.lwFiles_ItemActivate);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(129, 30);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload file";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.comboBox_Users);
            this.panelRight.Controls.Add(this.button_SendFilechat);
            this.panelRight.Controls.Add(this.listBox_Filechat);
            this.panelRight.Controls.Add(this.richTextBox_Filechat);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.btnDownload);
            this.panelRight.Controls.Add(this.txtFileDesc);
            this.panelRight.Controls.Add(this.lblFIleInfo);
            this.panelRight.Location = new System.Drawing.Point(628, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(353, 561);
            this.panelRight.TabIndex = 0;
            // 
            // button_SendFilechat
            // 
            this.button_SendFilechat.Location = new System.Drawing.Point(267, 526);
            this.button_SendFilechat.Name = "button_SendFilechat";
            this.button_SendFilechat.Size = new System.Drawing.Size(75, 23);
            this.button_SendFilechat.TabIndex = 7;
            this.button_SendFilechat.Text = "Send";
            this.button_SendFilechat.UseVisualStyleBackColor = true;
            this.button_SendFilechat.Click += new System.EventHandler(this.button_SendFilechat_Click);
            // 
            // listBox_Filechat
            // 
            this.listBox_Filechat.FormattingEnabled = true;
            this.listBox_Filechat.Location = new System.Drawing.Point(3, 168);
            this.listBox_Filechat.Name = "listBox_Filechat";
            this.listBox_Filechat.Size = new System.Drawing.Size(339, 277);
            this.listBox_Filechat.TabIndex = 6;
            // 
            // richTextBox_Filechat
            // 
            this.richTextBox_Filechat.Location = new System.Drawing.Point(3, 481);
            this.richTextBox_Filechat.Name = "richTextBox_Filechat";
            this.richTextBox_Filechat.Size = new System.Drawing.Size(258, 68);
            this.richTextBox_Filechat.TabIndex = 6;
            this.richTextBox_Filechat.Text = "";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 2);
            this.label2.TabIndex = 4;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(3, 137);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(112, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download file";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtFileDesc
            // 
            this.txtFileDesc.Location = new System.Drawing.Point(3, 49);
            this.txtFileDesc.Multiline = true;
            this.txtFileDesc.Name = "txtFileDesc";
            this.txtFileDesc.ReadOnly = true;
            this.txtFileDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileDesc.Size = new System.Drawing.Size(339, 82);
            this.txtFileDesc.TabIndex = 2;
            // 
            // lblFIleInfo
            // 
            this.lblFIleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFIleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFIleInfo.Location = new System.Drawing.Point(3, 9);
            this.lblFIleInfo.Name = "lblFIleInfo";
            this.lblFIleInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFIleInfo.Size = new System.Drawing.Size(339, 37);
            this.lblFIleInfo.TabIndex = 1;
            this.lblFIleInfo.Text = "File info";
            this.lblFIleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCenterTop
            // 
            this.panelCenterTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCenterTop.Controls.Add(this.lblNotImplementedWarning);
            this.panelCenterTop.Controls.Add(this.button_Chat_send);
            this.panelCenterTop.Controls.Add(this.richTextBoxChatmessage);
            this.panelCenterTop.Controls.Add(this.listChatMessages);
            this.panelCenterTop.Controls.Add(this.lblChat);
            this.panelCenterTop.Location = new System.Drawing.Point(241, 0);
            this.panelCenterTop.Name = "panelCenterTop";
            this.panelCenterTop.Size = new System.Drawing.Size(373, 203);
            this.panelCenterTop.TabIndex = 0;
            // 
            // lblNotImplementedWarning
            // 
            this.lblNotImplementedWarning.AutoSize = true;
            this.lblNotImplementedWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotImplementedWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotImplementedWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNotImplementedWarning.Location = new System.Drawing.Point(42, 112);
            this.lblNotImplementedWarning.Name = "lblNotImplementedWarning";
            this.lblNotImplementedWarning.Size = new System.Drawing.Size(293, 41);
            this.lblNotImplementedWarning.TabIndex = 5;
            this.lblNotImplementedWarning.Text = "Not Implemented";
            this.lblNotImplementedWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Chat_send
            // 
            this.button_Chat_send.Location = new System.Drawing.Point(295, 156);
            this.button_Chat_send.Name = "button_Chat_send";
            this.button_Chat_send.Size = new System.Drawing.Size(75, 23);
            this.button_Chat_send.TabIndex = 3;
            this.button_Chat_send.Text = "Send";
            this.button_Chat_send.UseVisualStyleBackColor = true;
            this.button_Chat_send.Click += new System.EventHandler(this.button_Chat_send_Click);
            // 
            // richTextBoxChatmessage
            // 
            this.richTextBoxChatmessage.Location = new System.Drawing.Point(3, 137);
            this.richTextBoxChatmessage.Name = "richTextBoxChatmessage";
            this.richTextBoxChatmessage.Size = new System.Drawing.Size(286, 63);
            this.richTextBoxChatmessage.TabIndex = 2;
            this.richTextBoxChatmessage.Text = "";
            // 
            // listChatMessages
            // 
            this.listChatMessages.FormattingEnabled = true;
            this.listChatMessages.Location = new System.Drawing.Point(3, 49);
            this.listChatMessages.Name = "listChatMessages";
            this.listChatMessages.Size = new System.Drawing.Size(367, 82);
            this.listChatMessages.TabIndex = 1;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(143, 9);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(89, 37);
            this.lblChat.TabIndex = 0;
            this.lblChat.Text = "Chat";
            this.lblChat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChatFileDivider
            // 
            this.ChatFileDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChatFileDivider.Location = new System.Drawing.Point(241, 206);
            this.ChatFileDivider.Name = "ChatFileDivider";
            this.ChatFileDivider.Size = new System.Drawing.Size(373, 2);
            this.ChatFileDivider.TabIndex = 2;
            // 
            // ProjectsChatFileDevider
            // 
            this.ProjectsChatFileDevider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProjectsChatFileDevider.Location = new System.Drawing.Point(233, 0);
            this.ProjectsChatFileDevider.Name = "ProjectsChatFileDevider";
            this.ProjectsChatFileDevider.Size = new System.Drawing.Size(2, 560);
            this.ProjectsChatFileDevider.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(620, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 560);
            this.label1.TabIndex = 4;
            // 
            // comboBox_Users
            // 
            this.comboBox_Users.FormattingEnabled = true;
            this.comboBox_Users.Location = new System.Drawing.Point(145, 451);
            this.comboBox_Users.Name = "comboBox_Users";
            this.comboBox_Users.Size = new System.Drawing.Size(197, 21);
            this.comboBox_Users.TabIndex = 8;
            this.comboBox_Users.SelectedIndexChanged += new System.EventHandler(this.comboBox_Users_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vælg en midlertidig bruger";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectsChatFileDevider);
            this.Controls.Add(this.ChatFileDivider);
            this.Controls.Add(this.panelCenterTop);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelCenterBottom);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectShare";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelCenterBottom.ResumeLayout(false);
            this.panelCenterBottom.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
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
        private System.Windows.Forms.Button button_ProjectAdministration;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListView lwFiles;
        private System.Windows.Forms.Label lblFIles;
        private System.Windows.Forms.Label lblFIleInfo;
        private System.Windows.Forms.TextBox txtFileDesc;
        private System.Windows.Forms.ListView listView_Projects;
        private System.Windows.Forms.Button btnRefreshFiles;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button button_Chat_send;
        private System.Windows.Forms.RichTextBox richTextBoxChatmessage;
        private System.Windows.Forms.ListBox listChatMessages;
        private System.Windows.Forms.Label ChatFileDivider;
        private System.Windows.Forms.Label ProjectsChatFileDevider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNotImplementedWarning;
        private System.Windows.Forms.Button button_SendFilechat;
        private System.Windows.Forms.ListBox listBox_Filechat;
        private System.Windows.Forms.RichTextBox richTextBox_Filechat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Users;
    }
}

