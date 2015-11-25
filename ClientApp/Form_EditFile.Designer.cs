namespace ClientApp
{
    partial class Form_EditFile
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
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_CurrentDirectory = new System.Windows.Forms.Label();
            this.label_workingDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.Location = new System.Drawing.Point(12, 29);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(120, 95);
            this.listBox_Files.TabIndex = 0;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(12, 130);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 1;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(13, 13);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(35, 13);
            this.label_Username.TabIndex = 2;
            this.label_Username.Text = "label1";
            // 
            // label_CurrentDirectory
            // 
            this.label_CurrentDirectory.AutoSize = true;
            this.label_CurrentDirectory.Location = new System.Drawing.Point(12, 223);
            this.label_CurrentDirectory.Name = "label_CurrentDirectory";
            this.label_CurrentDirectory.Size = new System.Drawing.Size(35, 13);
            this.label_CurrentDirectory.TabIndex = 3;
            this.label_CurrentDirectory.Text = "label1";
            // 
            // label_workingDirectory
            // 
            this.label_workingDirectory.AutoSize = true;
            this.label_workingDirectory.Location = new System.Drawing.Point(13, 236);
            this.label_workingDirectory.Name = "label_workingDirectory";
            this.label_workingDirectory.Size = new System.Drawing.Size(35, 13);
            this.label_workingDirectory.TabIndex = 4;
            this.label_workingDirectory.Text = "label1";
            // 
            // Form_EditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_workingDirectory);
            this.Controls.Add(this.label_CurrentDirectory);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.listBox_Files);
            this.Name = "Form_EditFile";
            this.Text = "EditFile";
            this.Load += new System.EventHandler(this.Form_EditFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_CurrentDirectory;
        private System.Windows.Forms.Label label_workingDirectory;
    }
}