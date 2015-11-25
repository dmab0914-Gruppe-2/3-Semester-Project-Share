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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectAdministration));
            this.lblUpload = new System.Windows.Forms.Label();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView_Projects = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
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
            this.lblUpload.Text = "Project Administration";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(ClientApp.ProjectServiceReference.Project);
            // 
            // listView_Projects
            // 
            this.listView_Projects.GridLines = true;
            this.listView_Projects.Location = new System.Drawing.Point(12, 37);
            this.listView_Projects.Name = "listView_Projects";
            this.listView_Projects.Size = new System.Drawing.Size(498, 512);
            this.listView_Projects.TabIndex = 3;
            this.listView_Projects.UseCompatibleStateImageBehavior = false;
            this.listView_Projects.View = System.Windows.Forms.View.Details;
            // 
            // ProjectAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.listView_Projects);
            this.Controls.Add(this.lblUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ProjectAdministration";
            this.Text = "Project Administration";
            this.Load += new System.EventHandler(this.ProjectAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.ListView listView_Projects;
    }
}