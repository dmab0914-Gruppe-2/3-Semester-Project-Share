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
            this.listView_Projects.Location = new System.Drawing.Point(12, 77);
            this.listView_Projects.Name = "listView_Projects";
            this.listView_Projects.Size = new System.Drawing.Size(483, 345);
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
            this.columnHeader_Description.Width = 299;
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
            // ProjectAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
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
    }
}