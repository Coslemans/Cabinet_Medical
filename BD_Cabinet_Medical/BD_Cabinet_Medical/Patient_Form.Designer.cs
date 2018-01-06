namespace BD_Cabinet_Medical
{
    partial class Patient_Form
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
            this.components = new System.ComponentModel.Container();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newAppointment = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.medicLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Doctors = new System.Windows.Forms.ComboBox();
            this.saveAppointment = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.DataGridView();
            this.historyButton = new System.Windows.Forms.Button();
            this.cabinet_MedicalDataSet = new BD_Cabinet_Medical.Cabinet_MedicalDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new BD_Cabinet_Medical.Cabinet_MedicalDataSetTableAdapters.AppointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_MedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(12, 326);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(75, 23);
            this.Logout_Button.TabIndex = 0;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(8, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // newAppointment
            // 
            this.newAppointment.AccessibleDescription = "";
            this.newAppointment.AllowDrop = true;
            this.newAppointment.Location = new System.Drawing.Point(12, 64);
            this.newAppointment.Name = "newAppointment";
            this.newAppointment.Size = new System.Drawing.Size(75, 23);
            this.newAppointment.TabIndex = 2;
            this.newAppointment.Text = "New Appointment";
            this.newAppointment.UseVisualStyleBackColor = true;
            this.newAppointment.Click += new System.EventHandler(this.newAppointment_Click);
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTime.Enabled = false;
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(249, 121);
            this.dateTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(2018, 1, 15, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(225, 20);
            this.dateTime.TabIndex = 3;
            this.dateTime.Value = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            // 
            // medicLabel
            // 
            this.medicLabel.AutoSize = true;
            this.medicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicLabel.Location = new System.Drawing.Point(170, 66);
            this.medicLabel.Name = "medicLabel";
            this.medicLabel.Size = new System.Drawing.Size(60, 17);
            this.medicLabel.TabIndex = 5;
            this.medicLabel.Text = "Medic: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data:";
            // 
            // Doctors
            // 
            this.Doctors.Enabled = false;
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(249, 64);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(225, 21);
            this.Doctors.TabIndex = 7;
            // 
            // saveAppointment
            // 
            this.saveAppointment.Enabled = false;
            this.saveAppointment.Location = new System.Drawing.Point(399, 159);
            this.saveAppointment.Name = "saveAppointment";
            this.saveAppointment.Size = new System.Drawing.Size(75, 23);
            this.saveAppointment.TabIndex = 8;
            this.saveAppointment.Text = "Save";
            this.saveAppointment.UseVisualStyleBackColor = true;
            this.saveAppointment.Click += new System.EventHandler(this.saveAppointment_Click);
            // 
            // History
            // 
            this.History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.History.Enabled = false;
            this.History.Location = new System.Drawing.Point(173, 199);
            this.History.Name = "History";
            this.History.RowHeadersWidth = 100;
            this.History.Size = new System.Drawing.Size(500, 150);
            this.History.TabIndex = 9;
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(12, 204);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(75, 23);
            this.historyButton.TabIndex = 10;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // cabinet_MedicalDataSet
            // 
            this.cabinet_MedicalDataSet.DataSetName = "Cabinet_MedicalDataSet";
            this.cabinet_MedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.cabinet_MedicalDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // Patient_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(669, 373);
            this.ControlBox = false;
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.History);
            this.Controls.Add(this.saveAppointment);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medicLabel);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.newAppointment);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Logout_Button);
            this.MinimizeBox = false;
            this.Name = "Patient_Form";
            this.Load += new System.EventHandler(this.Patient_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_MedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button newAppointment;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label medicLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Doctors;
        private System.Windows.Forms.Button saveAppointment;
        private System.Windows.Forms.DataGridView History;
        private System.Windows.Forms.Button historyButton;
        private Cabinet_MedicalDataSet cabinet_MedicalDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private Cabinet_MedicalDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
    }
}