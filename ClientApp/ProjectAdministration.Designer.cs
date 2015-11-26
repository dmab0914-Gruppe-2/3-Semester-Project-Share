namespace ClientApp
{
    partial class ProjectAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectAdministration));
            this.lblUpload = new System.Windows.Forms.Label();
            this.listView_Projects = new System.Windows.Forms.ListView();
            this.columnHeader_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button_EditParticipants = new System.Windows.Forms.Button();
            this.listView_FilesParticipants = new System.Windows.Forms.ListView();
            this.button_EditFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUpload.Location = new System.Drawing.Point(12, 9);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(200, 25);
            this.lblUpload.TabIndex = 1;
            this.lblUpload.Text = "Projekt Administration";
            // 
            // listView_Projects
            // 
            this.listView_Projects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Id,
            this.columnHeader_Title,
            this.columnHeader_Description});
            this.listView_Projects.GridLines = true;
            this.listView_Projects.Location = new System.Drawing.Point(12, 74);
            this.listView_Projects.Name = "listView_Projects";
            this.listView_Projects.Size = new System.Drawing.Size(440, 345);
            this.listView_Projects.TabIndex = 3;
            this.listView_Projects.UseCompatibleStateImageBehavior = false;
            this.listView_Projects.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Id
            // 
            this.columnHeader_Id.Text = "Id";
            this.columnHeader_Id.Width = 30;
            // 
            // columnHeader_Title
            // 
            this.columnHeader_Title.Text = "Title";
            this.columnHeader_Title.Width = 150;
            // 
            // columnHeader_Description
            // 
            this.columnHeader_Description.Text = "Description";
            this.columnHeader_Description.Width = 256;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projekter";
            // 
            // button_EditParticipants
            // 
            this.button_EditParticipants.Location = new System.Drawing.Point(12, 497);
            this.button_EditParticipants.Name = "button_EditParticipants";
            this.button_EditParticipants.Size = new System.Drawing.Size(108, 23);
            this.button_EditParticipants.TabIndex = 5;
            this.button_EditParticipants.Text = "Rediger Deltagere";
            this.button_EditParticipants.UseVisualStyleBackColor = true;
            this.button_EditParticipants.Click += new System.EventHandler(this.button_EditParticipants_Click);
            // 
            // listView_FilesParticipants
            // 
            this.listView_FilesParticipants.Location = new System.Drawing.Point(596, 74);
            this.listView_FilesParticipants.Name = "listView_FilesParticipants";
            this.listView_FilesParticipants.Size = new System.Drawing.Size(376, 345);
            this.listView_FilesParticipants.TabIndex = 6;
            this.listView_FilesParticipants.UseCompatibleStateImageBehavior = false;
            // 
            // button_EditFiles
            // 
            this.button_EditFiles.Location = new System.Drawing.Point(12, 526);
            this.button_EditFiles.Name = "button_EditFiles";
            this.button_EditFiles.Size = new System.Drawing.Size(108, 23);
            this.button_EditFiles.TabIndex = 7;
            this.button_EditFiles.Text = "Rediger Filer";
            this.button_EditFiles.UseVisualStyleBackColor = true;
            this.button_EditFiles.Click += new System.EventHandler(this.button_EditFiles_Click);
            // 
            // ProjectAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button_EditFiles);
            this.Controls.Add(this.listView_FilesParticipants);
            this.Controls.Add(this.button_EditParticipants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Projects);
            this.Controls.Add(this.lblUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ProjectAdministration";
            this.Text = "Project Share: Projekt Administration";
            this.Load += new System.EventHandler(this.ProjectAdministration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.ListView listView_Projects;
        private System.Windows.Forms.ColumnHeader columnHeader_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_Title;
        private System.Windows.Forms.ColumnHeader columnHeader_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_EditParticipants;
        private System.Windows.Forms.ListView listView_FilesParticipants;
        private System.Windows.Forms.Button button_EditFiles;
    }
}