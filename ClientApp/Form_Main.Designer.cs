namespace ClientApp
{
    partial class Form_Main
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
            this.button_EditFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_EditFile
            // 
            this.button_EditFile.Location = new System.Drawing.Point(12, 12);
            this.button_EditFile.Name = "button_EditFile";
            this.button_EditFile.Size = new System.Drawing.Size(75, 23);
            this.button_EditFile.TabIndex = 0;
            this.button_EditFile.Text = "Edit File";
            this.button_EditFile.UseVisualStyleBackColor = true;
            this.button_EditFile.Click += new System.EventHandler(this.button_EditFile_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_EditFile);
            this.Name = "Form_Main";
            this.Text = "ProjectShare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_EditFile;

    }
}

