namespace Library
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumberBorrow = new System.Windows.Forms.TextBox();
            this.txtPhoneNuber = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.EditUser = new System.Windows.Forms.Button();
            this.DeletUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearh = new System.Windows.Forms.TextBox();
            this.SearchUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.SearchUser);
            this.panel1.Controls.Add(this.txtSearh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNumberBorrow);
            this.panel1.Controls.Add(this.txtPhoneNuber);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.EditUser);
            this.panel1.Controls.Add(this.DeletUser);
            this.panel1.Controls.Add(this.AddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 155);
            this.panel1.TabIndex = 1;
            // 
            // txtNumberBorrow
            // 
            this.txtNumberBorrow.Location = new System.Drawing.Point(203, 101);
            this.txtNumberBorrow.Name = "txtNumberBorrow";
            this.txtNumberBorrow.Size = new System.Drawing.Size(158, 20);
            this.txtNumberBorrow.TabIndex = 5;
            // 
            // txtPhoneNuber
            // 
            this.txtPhoneNuber.Location = new System.Drawing.Point(153, 71);
            this.txtPhoneNuber.Name = "txtPhoneNuber";
            this.txtPhoneNuber.Size = new System.Drawing.Size(208, 20);
            this.txtPhoneNuber.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(153, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(208, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(441, 99);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(75, 23);
            this.EditUser.TabIndex = 2;
            this.EditUser.Text = "Edit User";
            this.EditUser.UseVisualStyleBackColor = true;
            // 
            // DeletUser
            // 
            this.DeletUser.Location = new System.Drawing.Point(441, 69);
            this.DeletUser.Name = "DeletUser";
            this.DeletUser.Size = new System.Drawing.Size(75, 23);
            this.DeletUser.TabIndex = 1;
            this.DeletUser.Text = "Delet User";
            this.DeletUser.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(441, 39);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(41, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(41, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Mumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(41, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of borrow books";
            // 
            // txtSearh
            // 
            this.txtSearh.Location = new System.Drawing.Point(591, 39);
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.Size = new System.Drawing.Size(158, 20);
            this.txtSearh.TabIndex = 9;
            // 
            // SearchUser
            // 
            this.SearchUser.Location = new System.Drawing.Point(637, 65);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(75, 23);
            this.SearchUser.TabIndex = 10;
            this.SearchUser.Text = "Search";
            this.SearchUser.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 289);
            this.panel2.TabIndex = 2;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumberBorrow;
        private System.Windows.Forms.TextBox txtPhoneNuber;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button DeletUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.TextBox txtSearh;
        private System.Windows.Forms.Panel panel2;
    }
}