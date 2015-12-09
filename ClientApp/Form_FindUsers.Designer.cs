namespace ClientApp
{
    partial class Form_FindUsers
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
            this.lblUpload = new System.Windows.Forms.Label();
            this.listView_Users = new System.Windows.Forms.ListView();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUpload.Location = new System.Drawing.Point(12, 9);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(113, 25);
            this.lblUpload.TabIndex = 2;
            this.lblUpload.Text = "Find Bruger";
            // 
            // listView_Users
            // 
            this.listView_Users.Location = new System.Drawing.Point(17, 37);
            this.listView_Users.Name = "listView_Users";
            this.listView_Users.Size = new System.Drawing.Size(316, 237);
            this.listView_Users.TabIndex = 10;
            this.listView_Users.UseCompatibleStateImageBehavior = false;
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(167, 280);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(75, 23);
            this.button_AddUser.TabIndex = 11;
            this.button_AddUser.Text = "Tilføj bruger";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(257, 281);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form_FindUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 313);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.listView_Users);
            this.Controls.Add(this.lblUpload);
            this.Name = "Form_FindUsers";
            this.Text = "Form_Users";
            this.Load += new System.EventHandler(this.Form_FindUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.ListView listView_Users;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Button buttonClose;

    }
}