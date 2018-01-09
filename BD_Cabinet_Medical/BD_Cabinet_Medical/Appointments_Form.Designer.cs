namespace BD_Cabinet_Medical
{
    partial class Appointments_Form
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
            this.PatientsData = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Deny_Button = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsData)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(12, 18);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(49, 16);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Name";
            // 
            // Specs_Label
            // 
            this.Specs_Label.AutoSize = true;
            this.Specs_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specs_Label.Location = new System.Drawing.Point(12, 43);
            this.Specs_Label.Name = "Specs_Label";
            this.Specs_Label.Size = new System.Drawing.Size(37, 13);
            this.Specs_Label.TabIndex = 2;
            this.Specs_Label.Text = "Specs";
            // 
            // PatientsData
            // 
            this.PatientsData.AllowUserToAddRows = false;
            this.PatientsData.AllowUserToDeleteRows = false;
            this.PatientsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Data,
            this.Status});
            this.PatientsData.Location = new System.Drawing.Point(110, 18);
            this.PatientsData.Name = "PatientsData";
            this.PatientsData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PatientsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsData.Size = new System.Drawing.Size(447, 274);
            this.PatientsData.TabIndex = 3;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            this.Nume.Width = 132;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 130;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 142;
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(12, 229);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(75, 23);
            this.Accept_Button.TabIndex = 4;
            this.Accept_Button.Text = "Consulta";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Deny_Button
            // 
            this.Deny_Button.Location = new System.Drawing.Point(12, 269);
            this.Deny_Button.Name = "Deny_Button";
            this.Deny_Button.Size = new System.Drawing.Size(75, 23);
            this.Deny_Button.TabIndex = 5;
            this.Deny_Button.Text = "Refuza";
            this.Deny_Button.UseVisualStyleBackColor = true;
            this.Deny_Button.Click += new System.EventHandler(this.Deny_Button_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 73);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Appointments_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 304);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Deny_Button);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.PatientsData);
            this.Controls.Add(this.Specs_Label);
            this.Controls.Add(this.Name_Label);
            this.Name = "Appointments_Form";
            this.Text = "Programari ";
            this.Load += new System.EventHandler(this.Appointments_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Specs_Label;
        private System.Windows.Forms.DataGridView PatientsData;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.Button Deny_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button Back;
    }
}