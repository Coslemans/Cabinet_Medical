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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Form));
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
            this.Programare = new System.Windows.Forms.GroupBox();
            this.showHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_MedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            this.Programare.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(12, 110);
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
            this.nameLabel.Location = new System.Drawing.Point(8, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // newAppointment
            // 
            this.newAppointment.AccessibleDescription = "";
            this.newAppointment.AllowDrop = true;
            this.newAppointment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newAppointment.BackgroundImage")));
            this.newAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newAppointment.Location = new System.Drawing.Point(35, 23);
            this.newAppointment.Name = "newAppointment";
            this.newAppointment.Size = new System.Drawing.Size(121, 109);
            this.newAppointment.TabIndex = 2;
            this.newAppointment.UseVisualStyleBackColor = true;
            this.newAppointment.Click += new System.EventHandler(this.newAppointment_Click);
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTime.Enabled = false;
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(303, 97);
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
            this.medicLabel.Location = new System.Drawing.Point(220, 40);
            this.medicLabel.Name = "medicLabel";
            this.medicLabel.Size = new System.Drawing.Size(60, 17);
            this.medicLabel.TabIndex = 5;
            this.medicLabel.Text = "Medic: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data:";
            // 
            // Doctors
            // 
            this.Doctors.Enabled = false;
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(303, 39);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(225, 21);
            this.Doctors.TabIndex = 7;
            this.Doctors.SelectedIndexChanged += new System.EventHandler(this.Doctors_SelectedIndexChanged);
            // 
            // saveAppointment
            // 
            this.saveAppointment.Enabled = false;
            this.saveAppointment.Location = new System.Drawing.Point(441, 134);
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
            this.History.Location = new System.Drawing.Point(130, 204);
            this.History.Name = "History";
            this.History.RowHeadersWidth = 100;
            this.History.Size = new System.Drawing.Size(519, 150);
            this.History.TabIndex = 9;
            // 
            // historyButton
            // 
            this.historyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyButton.BackgroundImage")));
            this.historyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historyButton.Location = new System.Drawing.Point(13, 215);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(74, 96);
            this.historyButton.TabIndex = 10;
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
            // Programare
            // 
            this.Programare.Controls.Add(this.label1);
            this.Programare.Controls.Add(this.medicLabel);
            this.Programare.Controls.Add(this.newAppointment);
            this.Programare.Controls.Add(this.Doctors);
            this.Programare.Controls.Add(this.saveAppointment);
            this.Programare.Controls.Add(this.dateTime);
            this.Programare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programare.Location = new System.Drawing.Point(130, 12);
            this.Programare.Name = "Programare";
            this.Programare.Size = new System.Drawing.Size(532, 163);
            this.Programare.TabIndex = 12;
            this.Programare.TabStop = false;
            this.Programare.Text = "Programare noua";
            // 
            // showHistory
            // 
            this.showHistory.AutoSize = true;
            this.showHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHistory.Location = new System.Drawing.Point(21, 323);
            this.showHistory.Name = "showHistory";
            this.showHistory.Size = new System.Drawing.Size(52, 17);
            this.showHistory.TabIndex = 13;
            this.showHistory.Text = "Istoric";
            // 
            // Patient_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(674, 373);
            this.ControlBox = false;
            this.Controls.Add(this.showHistory);
            this.Controls.Add(this.Programare);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.History);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Logout_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Patient_Form";
            this.Load += new System.EventHandler(this.Patient_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_MedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            this.Programare.ResumeLayout(false);
            this.Programare.PerformLayout();
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
        private System.Windows.Forms.GroupBox Programare;
        private System.Windows.Forms.Label showHistory;
    }
}