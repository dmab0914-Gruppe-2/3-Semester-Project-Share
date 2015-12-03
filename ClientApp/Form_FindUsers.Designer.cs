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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.button_FindUser = new System.Windows.Forms.Button();
            this.listView_Users = new System.Windows.Forms.ListView();
            this.button_AddUser = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brugernavn";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(12, 110);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bruger Id";
            // 
            // textBox_UserId
            // 
            this.textBox_UserId.Location = new System.Drawing.Point(12, 61);
            this.textBox_UserId.Name = "textBox_UserId";
            this.textBox_UserId.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(12, 155);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 8;
            // 
            // button_FindUser
            // 
            this.button_FindUser.Location = new System.Drawing.Point(12, 226);
            this.button_FindUser.Name = "button_FindUser";
            this.button_FindUser.Size = new System.Drawing.Size(75, 23);
            this.button_FindUser.TabIndex = 9;
            this.button_FindUser.Text = "Find bruger";
            this.button_FindUser.UseVisualStyleBackColor = true;
            this.button_FindUser.Click += new System.EventHandler(this.button_FindUser_Click);
            // 
            // listView_Users
            // 
            this.listView_Users.Location = new System.Drawing.Point(196, 12);
            this.listView_Users.Name = "listView_Users";
            this.listView_Users.Size = new System.Drawing.Size(316, 237);
            this.listView_Users.TabIndex = 10;
            this.listView_Users.UseCompatibleStateImageBehavior = false;
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(94, 226);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(75, 23);
            this.button_AddUser.TabIndex = 11;
            this.button_AddUser.Text = "Tilføj bruger";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // Form_FindUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.listView_Users);
            this.Controls.Add(this.button_FindUser);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_UserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUpload);
            this.Name = "Form_FindUsers";
            this.Text = "Form_Users";
            this.Load += new System.EventHandler(this.Form_FindUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button button_FindUser;
        private System.Windows.Forms.ListView listView_Users;
        private System.Windows.Forms.Button button_AddUser;

    }
}