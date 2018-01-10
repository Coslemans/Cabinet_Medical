namespace BD_Cabinet_Medical
{
    partial class Admin_Form
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
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.admin_label = new System.Windows.Forms.Label();
            this.User_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.AddMed = new System.Windows.Forms.Button();
            this.AddPill = new System.Windows.Forms.Button();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Spec_Box = new System.Windows.Forms.TextBox();
            this.Username_Box = new System.Windows.Forms.TextBox();
            this.Parola_Box = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Specializare_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Parola_Label = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Stoc_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(83, 93);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '*';
            this.Password_Box.Size = new System.Drawing.Size(100, 20);
            this.Password_Box.TabIndex = 0;
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_label.Location = new System.Drawing.Point(80, 59);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(53, 18);
            this.admin_label.TabIndex = 1;
            this.admin_label.Text = "admin";
            this.admin_label.Click += new System.EventHandler(this.admin_label_Click);
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Label.Location = new System.Drawing.Point(12, 59);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(47, 20);
            this.User_Label.TabIndex = 2;
            this.User_Label.Text = "User";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(12, 93);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(60, 20);
            this.Password_Label.TabIndex = 3;
            this.Password_Label.Text = "Parola";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(16, 138);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(108, 138);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // AddMed
            // 
            this.AddMed.Location = new System.Drawing.Point(12, 39);
            this.AddMed.Name = "AddMed";
            this.AddMed.Size = new System.Drawing.Size(75, 38);
            this.AddMed.TabIndex = 6;
            this.AddMed.Text = "Adauga Medic";
            this.AddMed.UseVisualStyleBackColor = true;
            this.AddMed.Visible = false;
            this.AddMed.Click += new System.EventHandler(this.AddMed_Click);
            // 
            // AddPill
            // 
            this.AddPill.Location = new System.Drawing.Point(12, 110);
            this.AddPill.Name = "AddPill";
            this.AddPill.Size = new System.Drawing.Size(75, 45);
            this.AddPill.TabIndex = 7;
            this.AddPill.Text = "Adauga Medicament";
            this.AddPill.UseVisualStyleBackColor = true;
            this.AddPill.Visible = false;
            this.AddPill.Click += new System.EventHandler(this.AddPill_Click);
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(348, 67);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(128, 20);
            this.Name_Box.TabIndex = 8;
            this.Name_Box.Visible = false;
            // 
            // Spec_Box
            // 
            this.Spec_Box.Location = new System.Drawing.Point(348, 123);
            this.Spec_Box.Name = "Spec_Box";
            this.Spec_Box.Size = new System.Drawing.Size(128, 20);
            this.Spec_Box.TabIndex = 9;
            this.Spec_Box.Visible = false;
            // 
            // Username_Box
            // 
            this.Username_Box.Location = new System.Drawing.Point(348, 179);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(128, 20);
            this.Username_Box.TabIndex = 10;
            this.Username_Box.Visible = false;
            // 
            // Parola_Box
            // 
            this.Parola_Box.Location = new System.Drawing.Point(348, 232);
            this.Parola_Box.Name = "Parola_Box";
            this.Parola_Box.PasswordChar = '*';
            this.Parola_Box.Size = new System.Drawing.Size(128, 20);
            this.Parola_Box.TabIndex = 11;
            this.Parola_Box.Visible = false;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(228, 67);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(52, 18);
            this.Name_Label.TabIndex = 12;
            this.Name_Label.Text = "Nume";
            this.Name_Label.Visible = false;
            // 
            // Specializare_Label
            // 
            this.Specializare_Label.AutoSize = true;
            this.Specializare_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specializare_Label.Location = new System.Drawing.Point(228, 125);
            this.Specializare_Label.Name = "Specializare_Label";
            this.Specializare_Label.Size = new System.Drawing.Size(100, 18);
            this.Specializare_Label.TabIndex = 13;
            this.Specializare_Label.Text = "Specializare";
            this.Specializare_Label.Visible = false;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.Location = new System.Drawing.Point(228, 181);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(85, 18);
            this.Username_Label.TabIndex = 14;
            this.Username_Label.Text = "Username";
            this.Username_Label.Visible = false;
            // 
            // Parola_Label
            // 
            this.Parola_Label.AutoSize = true;
            this.Parola_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parola_Label.Location = new System.Drawing.Point(228, 234);
            this.Parola_Label.Name = "Parola_Label";
            this.Parola_Label.Size = new System.Drawing.Size(57, 18);
            this.Parola_Label.TabIndex = 15;
            this.Parola_Label.Text = "Parola";
            this.Parola_Label.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 191);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Stoc_Label
            // 
            this.Stoc_Label.AutoSize = true;
            this.Stoc_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stoc_Label.Location = new System.Drawing.Point(228, 181);
            this.Stoc_Label.Name = "Stoc_Label";
            this.Stoc_Label.Size = new System.Drawing.Size(43, 18);
            this.Stoc_Label.TabIndex = 17;
            this.Stoc_Label.Text = "Stoc";
            this.Stoc_Label.Visible = false;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.Location = new System.Drawing.Point(228, 125);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(109, 18);
            this.Date_Label.TabIndex = 18;
            this.Date_Label.Text = "Data Expirarii";
            this.Date_Label.Visible = false;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 388);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Stoc_Label);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Parola_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Specializare_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Parola_Box);
            this.Controls.Add(this.Username_Box);
            this.Controls.Add(this.Spec_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.AddPill);
            this.Controls.Add(this.AddMed);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.User_Label);
            this.Controls.Add(this.admin_label);
            this.Controls.Add(this.Password_Box);
            this.Name = "Admin_Form";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label admin_label;
        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button AddMed;
        private System.Windows.Forms.Button AddPill;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Spec_Box;
        private System.Windows.Forms.TextBox Username_Box;
        private System.Windows.Forms.TextBox Parola_Box;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Specializare_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Parola_Label;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Stoc_Label;
        private System.Windows.Forms.Label Date_Label;
    }
}