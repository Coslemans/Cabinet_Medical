namespace BD_Cabinet_Medical
{
    partial class Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Form));
            this.nameLabel = new System.Windows.Forms.Label();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.serieLabel = new System.Windows.Forms.Label();
            this.numarLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cnpBox = new System.Windows.Forms.TextBox();
            this.serieBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.data_nasterePick = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inregistrareGroupBox = new System.Windows.Forms.GroupBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.clearTextLabel = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.inregistrareGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(6, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume:";
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpLabel.Location = new System.Drawing.Point(6, 64);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(44, 17);
            this.cnpLabel.TabIndex = 1;
            this.cnpLabel.Text = "CNP:";
            // 
            // serieLabel
            // 
            this.serieLabel.AutoSize = true;
            this.serieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serieLabel.Location = new System.Drawing.Point(6, 99);
            this.serieLabel.Name = "serieLabel";
            this.serieLabel.Size = new System.Drawing.Size(109, 17);
            this.serieLabel.TabIndex = 2;
            this.serieLabel.Text = "Serie_buletin:";
            // 
            // numarLabel
            // 
            this.numarLabel.AutoSize = true;
            this.numarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarLabel.Location = new System.Drawing.Point(6, 144);
            this.numarLabel.Name = "numarLabel";
            this.numarLabel.Size = new System.Drawing.Size(119, 17);
            this.numarLabel.TabIndex = 3;
            this.numarLabel.Text = "Numar_Buletin:";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.Location = new System.Drawing.Point(6, 193);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(110, 17);
            this.birthLabel.TabIndex = 4;
            this.birthLabel.Text = "Data_nasterii:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(16, 27);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(86, 17);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(16, 71);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Parola:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(158, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 20);
            this.nameBox.TabIndex = 7;
            // 
            // cnpBox
            // 
            this.cnpBox.Location = new System.Drawing.Point(158, 64);
            this.cnpBox.MaxLength = 13;
            this.cnpBox.Name = "cnpBox";
            this.cnpBox.Size = new System.Drawing.Size(200, 20);
            this.cnpBox.TabIndex = 8;
            // 
            // serieBox
            // 
            this.serieBox.Location = new System.Drawing.Point(158, 99);
            this.serieBox.MaxLength = 2;
            this.serieBox.Name = "serieBox";
            this.serieBox.Size = new System.Drawing.Size(200, 20);
            this.serieBox.TabIndex = 9;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(158, 144);
            this.numberBox.MaxLength = 6;
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(200, 20);
            this.numberBox.TabIndex = 10;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(168, 27);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(200, 20);
            this.userBox.TabIndex = 11;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(168, 71);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(200, 20);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // data_nasterePick
            // 
            this.data_nasterePick.CustomFormat = "yyyy-MM-dd";
            this.data_nasterePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_nasterePick.Location = new System.Drawing.Point(158, 193);
            this.data_nasterePick.Name = "data_nasterePick";
            this.data_nasterePick.Size = new System.Drawing.Size(200, 20);
            this.data_nasterePick.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Location = new System.Drawing.Point(686, 256);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 124);
            this.addButton.TabIndex = 14;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(16, 124);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(132, 17);
            this.confirmLabel.TabIndex = 15;
            this.confirmLabel.Text = "Confirma_parola:";
            // 
            // confirmBox
            // 
            this.confirmBox.Location = new System.Drawing.Point(168, 124);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(200, 20);
            this.confirmBox.TabIndex = 16;
            this.confirmBox.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.cnpLabel);
            this.groupBox1.Controls.Add(this.serieLabel);
            this.groupBox1.Controls.Add(this.numarLabel);
            this.groupBox1.Controls.Add(this.data_nasterePick);
            this.groupBox1.Controls.Add(this.birthLabel);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.cnpBox);
            this.groupBox1.Controls.Add(this.numberBox);
            this.groupBox1.Controls.Add(this.serieBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 264);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Personale";
            // 
            // inregistrareGroupBox
            // 
            this.inregistrareGroupBox.Controls.Add(this.userBox);
            this.inregistrareGroupBox.Controls.Add(this.userLabel);
            this.inregistrareGroupBox.Controls.Add(this.confirmBox);
            this.inregistrareGroupBox.Controls.Add(this.passwordLabel);
            this.inregistrareGroupBox.Controls.Add(this.confirmLabel);
            this.inregistrareGroupBox.Controls.Add(this.passwordBox);
            this.inregistrareGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inregistrareGroupBox.Location = new System.Drawing.Point(471, 39);
            this.inregistrareGroupBox.Name = "inregistrareGroupBox";
            this.inregistrareGroupBox.Size = new System.Drawing.Size(390, 196);
            this.inregistrareGroupBox.TabIndex = 18;
            this.inregistrareGroupBox.TabStop = false;
            this.inregistrareGroupBox.Text = "Date de inregistrare";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(22, 383);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(37, 13);
            this.registerLabel.TabIndex = 19;
            this.registerLabel.Text = "Specs";
            // 
            // clearTextButton
            // 
            this.clearTextButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearTextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearTextButton.BackgroundImage")));
            this.clearTextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearTextButton.Location = new System.Drawing.Point(471, 256);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(171, 124);
            this.clearTextButton.TabIndex = 20;
            this.clearTextButton.UseVisualStyleBackColor = false;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // clearTextLabel
            // 
            this.clearTextLabel.AutoSize = true;
            this.clearTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTextLabel.Location = new System.Drawing.Point(514, 383);
            this.clearTextLabel.Name = "clearTextLabel";
            this.clearTextLabel.Size = new System.Drawing.Size(82, 17);
            this.clearTextLabel.TabIndex = 21;
            this.clearTextLabel.Text = "Clear Text";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.Location = new System.Drawing.Point(714, 381);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(125, 17);
            this.regLabel.TabIndex = 22;
            this.regLabel.Text = "Register Patient";
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 408);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.clearTextLabel);
            this.Controls.Add(this.clearTextButton);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.inregistrareGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.inregistrareGroupBox.ResumeLayout(false);
            this.inregistrareGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.Label serieLabel;
        private System.Windows.Forms.Label numarLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox cnpBox;
        private System.Windows.Forms.TextBox serieBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.DateTimePicker data_nasterePick;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox inregistrareGroupBox;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.Label clearTextLabel;
        private System.Windows.Forms.Label regLabel;
    }
}