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
            this.button_EditProject = new System.Windows.Forms.Button();
            this.label_MembersProject = new System.Windows.Forms.Label();
            this.label_ProjektId = new System.Windows.Forms.Label();
            this.textBox_ProjektId = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_FindUser = new System.Windows.Forms.Button();
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
            this.listView_Projects.ItemActivate += new System.EventHandler(this.listView_Projects_ItemActivate);
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
            this.button_EditParticipants.Location = new System.Drawing.Point(12, 526);
            this.button_EditParticipants.Name = "button_EditParticipants";
            this.button_EditParticipants.Size = new System.Drawing.Size(108, 23);
            this.button_EditParticipants.TabIndex = 5;
            this.button_EditParticipants.Text = "Rediger Deltagere";
            this.button_EditParticipants.UseVisualStyleBackColor = true;
            this.button_EditParticipants.Click += new System.EventHandler(this.button_EditParticipants_Click);
            // 
            // listView_FilesParticipants
            // 
            this.listView_FilesParticipants.Location = new System.Drawing.Point(532, 74);
            this.listView_FilesParticipants.Name = "listView_FilesParticipants";
            this.listView_FilesParticipants.Size = new System.Drawing.Size(440, 345);
            this.listView_FilesParticipants.TabIndex = 6;
            this.listView_FilesParticipants.UseCompatibleStateImageBehavior = false;
            // 
            // button_EditProject
            // 
            this.button_EditProject.Location = new System.Drawing.Point(12, 497);
            this.button_EditProject.Name = "button_EditProject";
            this.button_EditProject.Size = new System.Drawing.Size(108, 23);
            this.button_EditProject.TabIndex = 7;
            this.button_EditProject.Text = "Rediger Projekt";
            this.button_EditProject.UseVisualStyleBackColor = true;
            this.button_EditProject.Click += new System.EventHandler(this.button_EditProject_Click);
            // 
            // label_MembersProject
            // 
            this.label_MembersProject.AutoSize = true;
            this.label_MembersProject.Location = new System.Drawing.Point(529, 58);
            this.label_MembersProject.Name = "label_MembersProject";
            this.label_MembersProject.Size = new System.Drawing.Size(61, 13);
            this.label_MembersProject.TabIndex = 8;
            this.label_MembersProject.Text = "Medlemmer";
            // 
            // label_ProjektId
            // 
            this.label_ProjektId.AutoSize = true;
            this.label_ProjektId.Location = new System.Drawing.Point(529, 78);
            this.label_ProjektId.Name = "label_ProjektId";
            this.label_ProjektId.Size = new System.Drawing.Size(54, 13);
            this.label_ProjektId.TabIndex = 9;
            this.label_ProjektId.Text = "Projekt ID";
            // 
            // textBox_ProjektId
            // 
            this.textBox_ProjektId.Location = new System.Drawing.Point(593, 75);
            this.textBox_ProjektId.Name = "textBox_ProjektId";
            this.textBox_ProjektId.Size = new System.Drawing.Size(100, 20);
            this.textBox_ProjektId.TabIndex = 10;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(593, 102);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(229, 20);
            this.textBox_Title.TabIndex = 11;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(529, 109);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(27, 13);
            this.label_Title.TabIndex = 12;
            this.label_Title.Text = "Titel";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(593, 129);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(229, 20);
            this.textBox_Description.TabIndex = 13;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(532, 135);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(61, 13);
            this.label_Description.TabIndex = 14;
            this.label_Description.Text = "Beskrivelse";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(897, 526);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Gem";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_FindUser
            // 
            this.button_FindUser.Location = new System.Drawing.Point(897, 497);
            this.button_FindUser.Name = "button_FindUser";
            this.button_FindUser.Size = new System.Drawing.Size(75, 23);
            this.button_FindUser.TabIndex = 16;
            this.button_FindUser.Text = "Find bruger";
            this.button_FindUser.UseVisualStyleBackColor = true;
            this.button_FindUser.Click += new System.EventHandler(this.button_FindUser_Click);
            // 
            // ProjectAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button_FindUser);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.textBox_ProjektId);
            this.Controls.Add(this.label_ProjektId);
            this.Controls.Add(this.label_MembersProject);
            this.Controls.Add(this.button_EditProject);
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
        private System.Windows.Forms.Button button_EditProject;
        private System.Windows.Forms.Label label_MembersProject;
        private System.Windows.Forms.Label label_ProjektId;
        private System.Windows.Forms.TextBox textBox_ProjektId;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_FindUser;
    }
}