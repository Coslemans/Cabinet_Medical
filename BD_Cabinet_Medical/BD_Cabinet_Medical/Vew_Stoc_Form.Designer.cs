namespace BD_Cabinet_Medical
{
    partial class Vew_Stoc_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vew_Stoc_Form));
            this.StocView = new System.Windows.Forms.DataGridView();
            this.Afectiune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinet_MedicalDataSet = new BD_Cabinet_Medical.Cabinet_MedicalDataSet();
            this.cabinetMedicalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StocView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_MedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetMedicalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StocView
            // 
            this.StocView.BackgroundColor = System.Drawing.Color.Gray;
            this.StocView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StocView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Afectiune,
            this.Medicament,
            this.Data,
            this.Stoc});
            this.StocView.Location = new System.Drawing.Point(210, 1);
            this.StocView.Name = "StocView";
            this.StocView.Size = new System.Drawing.Size(443, 296);
            this.StocView.TabIndex = 0;
            this.StocView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Afectiune
            // 
            this.Afectiune.HeaderText = "Denumire Afectiune";
            this.Afectiune.Name = "Afectiune";
            // 
            // Medicament
            // 
            this.Medicament.HeaderText = "Medicament";
            this.Medicament.Name = "Medicament";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data Expirarii";
            this.Data.Name = "Data";
            // 
            // Stoc
            // 
            this.Stoc.HeaderText = "Stoc";
            this.Stoc.Name = "Stoc";
            // 
            // cabinet_MedicalDataSet
            // 
            this.cabinet_MedicalDataSet.DataSetName = "Cabinet_MedicalDataSet";
            this.cabinet_MedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cabinetMedicalDataSetBindingSource
            // 
            this.cabinetMedicalDataSetBindingSource.DataSource = this.cabinet_MedicalDataSet;
            this.cabinetMedicalDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vew_Stoc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StocView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Vew_Stoc_Form";
            this.Text = "Stoc Medicamente";
            ((System.ComponentModel.ISupportInitialize)(this.StocView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_MedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetMedicalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StocView;
        private System.Windows.Forms.BindingSource cabinetMedicalDataSetBindingSource;
        private Cabinet_MedicalDataSet cabinet_MedicalDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afectiune;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stoc;
        private System.Windows.Forms.Button button1;
    }
}