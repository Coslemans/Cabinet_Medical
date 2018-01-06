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
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume:";
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpLabel.Location = new System.Drawing.Point(13, 61);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(44, 17);
            this.cnpLabel.TabIndex = 1;
            this.cnpLabel.Text = "CNP:";
            // 
            // serieLabel
            // 
            this.serieLabel.AutoSize = true;
            this.serieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serieLabel.Location = new System.Drawing.Point(13, 96);
            this.serieLabel.Name = "serieLabel";
            this.serieLabel.Size = new System.Drawing.Size(109, 17);
            this.serieLabel.TabIndex = 2;
            this.serieLabel.Text = "Serie_buletin:";
            // 
            // numarLabel
            // 
            this.numarLabel.AutoSize = true;
            this.numarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarLabel.Location = new System.Drawing.Point(13, 141);
            this.numarLabel.Name = "numarLabel";
            this.numarLabel.Size = new System.Drawing.Size(119, 17);
            this.numarLabel.TabIndex = 3;
            this.numarLabel.Text = "Numar_Buletin:";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.Location = new System.Drawing.Point(13, 190);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(110, 17);
            this.birthLabel.TabIndex = 4;
            this.birthLabel.Text = "Data_nasterii:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(13, 234);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(86, 17);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(13, 278);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Parola:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(165, 24);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 20);
            this.nameBox.TabIndex = 7;
            // 
            // cnpBox
            // 
            this.cnpBox.Location = new System.Drawing.Point(165, 61);
            this.cnpBox.MaxLength = 13;
            this.cnpBox.Name = "cnpBox";
            this.cnpBox.Size = new System.Drawing.Size(200, 20);
            this.cnpBox.TabIndex = 8;
            // 
            // serieBox
            // 
            this.serieBox.Location = new System.Drawing.Point(165, 96);
            this.serieBox.MaxLength = 2;
            this.serieBox.Name = "serieBox";
            this.serieBox.Size = new System.Drawing.Size(200, 20);
            this.serieBox.TabIndex = 9;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(165, 141);
            this.numberBox.MaxLength = 6;
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(200, 20);
            this.numberBox.TabIndex = 10;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(165, 234);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(200, 20);
            this.userBox.TabIndex = 11;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(165, 278);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(200, 20);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // data_nasterePick
            // 
            this.data_nasterePick.CustomFormat = "yyyy-MM-dd";
            this.data_nasterePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_nasterePick.Location = new System.Drawing.Point(165, 190);
            this.data_nasterePick.Name = "data_nasterePick";
            this.data_nasterePick.Size = new System.Drawing.Size(200, 20);
            this.data_nasterePick.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Location = new System.Drawing.Point(592, 118);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 133);
            this.addButton.TabIndex = 14;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(13, 331);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(132, 17);
            this.confirmLabel.TabIndex = 15;
            this.confirmLabel.Text = "Confirma_parola:";
            // 
            // confirmBox
            // 
            this.confirmBox.Location = new System.Drawing.Point(165, 331);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(200, 20);
            this.confirmBox.TabIndex = 16;
            this.confirmBox.UseSystemPasswordChar = true;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 408);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.data_nasterePick);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.serieBox);
            this.Controls.Add(this.cnpBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.numarLabel);
            this.Controls.Add(this.serieLabel);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
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
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.DateTimePicker data_nasterePick;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox confirmBox;
    }
}