namespace BD_Cabinet_Medical
{
    partial class Medic_Form
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.Specs_Label = new System.Windows.Forms.Label();
            this.PacientsData = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Buletin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numar_Buletin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Nasterii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Request_Label = new System.Windows.Forms.Label();
            this.Logout_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PacientsData)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(12, 13);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(49, 16);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name";
            this.Name_Label.Click += new System.EventHandler(this.Name_Label_Click);
            // 
            // Specs_Label
            // 
            this.Specs_Label.AutoSize = true;
            this.Specs_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specs_Label.Location = new System.Drawing.Point(12, 38);
            this.Specs_Label.Name = "Specs_Label";
            this.Specs_Label.Size = new System.Drawing.Size(37, 13);
            this.Specs_Label.TabIndex = 1;
            this.Specs_Label.Text = "Specs";
            // 
            // PacientsData
            // 
            this.PacientsData.AllowUserToAddRows = false;
            this.PacientsData.AllowUserToDeleteRows = false;
            this.PacientsData.AllowUserToResizeColumns = false;
            this.PacientsData.AllowUserToResizeRows = false;
            this.PacientsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PacientsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PacientsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.CNP,
            this.Serie_Buletin,
            this.Numar_Buletin,
            this.Data_Nasterii});
            this.PacientsData.Location = new System.Drawing.Point(121, 13);
            this.PacientsData.MultiSelect = false;
            this.PacientsData.Name = "PacientsData";
            this.PacientsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PacientsData.Size = new System.Drawing.Size(590, 352);
            this.PacientsData.TabIndex = 2;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume Pacient";
            this.Nume.Name = "Nume";
            this.Nume.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nume.Width = 120;
            // 
            // CNP
            // 
            this.CNP.HeaderText = "CNP";
            this.CNP.Name = "CNP";
            this.CNP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CNP.Width = 130;
            // 
            // Serie_Buletin
            // 
            this.Serie_Buletin.HeaderText = "Serie Buletin";
            this.Serie_Buletin.Name = "Serie_Buletin";
            this.Serie_Buletin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Serie_Buletin.Width = 50;
            // 
            // Numar_Buletin
            // 
            this.Numar_Buletin.HeaderText = "Numar Buletin";
            this.Numar_Buletin.Name = "Numar_Buletin";
            this.Numar_Buletin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Data_Nasterii
            // 
            this.Data_Nasterii.HeaderText = "Data Nasterii";
            this.Data_Nasterii.Name = "Data_Nasterii";
            this.Data_Nasterii.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Nasterii.Width = 147;
            // 
            // View_Button
            // 
            this.View_Button.Location = new System.Drawing.Point(15, 229);
            this.View_Button.Name = "View_Button";
            this.View_Button.Size = new System.Drawing.Size(75, 23);
            this.View_Button.TabIndex = 3;
            this.View_Button.Text = "View";
            this.View_Button.UseVisualStyleBackColor = true;
            this.View_Button.Click += new System.EventHandler(this.View_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(15, 281);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(15, 332);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 5;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Request_Label
            // 
            this.Request_Label.AutoSize = true;
            this.Request_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Request_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Request_Label.Location = new System.Drawing.Point(12, 64);
            this.Request_Label.Name = "Request_Label";
            this.Request_Label.Size = new System.Drawing.Size(71, 13);
            this.Request_Label.TabIndex = 6;
            this.Request_Label.Text = "Appointments";
            this.Request_Label.Click += new System.EventHandler(this.Request_Label_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(15, 97);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(75, 23);
            this.Logout_Button.TabIndex = 7;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Medic_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 377);
            this.ControlBox = false;
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.Request_Label);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.View_Button);
            this.Controls.Add(this.PacientsData);
            this.Controls.Add(this.Specs_Label);
            this.Controls.Add(this.Name_Label);
            this.Name = "Medic_Form";
            this.Load += new System.EventHandler(this.Medic_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacientsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Specs_Label;
        private System.Windows.Forms.DataGridView PacientsData;
        private System.Windows.Forms.Button View_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label Request_Label;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Buletin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numar_Buletin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Nasterii;
    }
}