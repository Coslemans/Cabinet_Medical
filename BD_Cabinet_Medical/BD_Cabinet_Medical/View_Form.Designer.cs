namespace BD_Cabinet_Medical
{
    partial class View_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Form));
            this.buttonScutire = new System.Windows.Forms.Button();
            this.buttonReteta = new System.Windows.Forms.Button();
            this.buttonBilet = new System.Windows.Forms.Button();
            this.labelNume = new System.Windows.Forms.Label();
            this.ViewData = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume_medic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTipC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.RetetaData = new System.Windows.Forms.DataGridView();
            this.cData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescriere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numar_flacoane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiletData = new System.Windows.Forms.DataGridView();
            this.CData3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMedic3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAfectiune3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNrB3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBAck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetetaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScutire
            // 
            this.buttonScutire.Location = new System.Drawing.Point(12, 168);
            this.buttonScutire.Name = "buttonScutire";
            this.buttonScutire.Size = new System.Drawing.Size(85, 25);
            this.buttonScutire.TabIndex = 1;
            this.buttonScutire.Text = "Scutire";
            this.buttonScutire.UseVisualStyleBackColor = true;
            this.buttonScutire.Click += new System.EventHandler(this.buttonScutire_Click);
            // 
            // buttonReteta
            // 
            this.buttonReteta.Location = new System.Drawing.Point(12, 211);
            this.buttonReteta.Name = "buttonReteta";
            this.buttonReteta.Size = new System.Drawing.Size(85, 25);
            this.buttonReteta.TabIndex = 2;
            this.buttonReteta.Text = "Reteta";
            this.buttonReteta.UseVisualStyleBackColor = true;
            this.buttonReteta.Click += new System.EventHandler(this.buttonReteta_Click);
            // 
            // buttonBilet
            // 
            this.buttonBilet.Location = new System.Drawing.Point(12, 258);
            this.buttonBilet.Name = "buttonBilet";
            this.buttonBilet.Size = new System.Drawing.Size(85, 25);
            this.buttonBilet.TabIndex = 3;
            this.buttonBilet.Text = "Bilet internare";
            this.buttonBilet.UseVisualStyleBackColor = true;
            this.buttonBilet.Click += new System.EventHandler(this.buttonBilet_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(13, 39);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(41, 15);
            this.labelNume.TabIndex = 5;
            this.labelNume.Text = "Nume";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // ViewData
            // 
            this.ViewData.AllowUserToAddRows = false;
            this.ViewData.AllowUserToDeleteRows = false;
            this.ViewData.AllowUserToResizeColumns = false;
            this.ViewData.AllowUserToResizeRows = false;
            this.ViewData.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ViewData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Nume_medic,
            this.Data,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewData.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.ViewData.Location = new System.Drawing.Point(168, 63);
            this.ViewData.Name = "ViewData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewData.Size = new System.Drawing.Size(544, 266);
            this.ViewData.TabIndex = 0;
            this.ViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewData_CellContentClick_1);
            this.ViewData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewData_CellContentClick);
            this.ViewData.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewData_CellContentClick);
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Data";
            this.Nume.Name = "Nume";
            // 
            // Nume_medic
            // 
            this.Nume_medic.HeaderText = "Nume medic";
            this.Nume_medic.Name = "Nume_medic";
            // 
            // Data
            // 
            this.Data.HeaderText = "Denumire afectiune";
            this.Data.Name = "Data";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tip scutire";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numar zile repaus";
            this.Column2.Name = "Column2";
            // 
            // comboBoxTipC
            // 
            this.comboBoxTipC.FormattingEnabled = true;
            this.comboBoxTipC.Items.AddRange(new object[] {
            "Reteta",
            "Scutire",
            "Bilet internare"});
            this.comboBoxTipC.Location = new System.Drawing.Point(12, 99);
            this.comboBoxTipC.Name = "comboBoxTipC";
            this.comboBoxTipC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipC.TabIndex = 6;
            this.comboBoxTipC.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tip consultatie";
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(12, 126);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(85, 25);
            this.buttonAfisare.TabIndex = 8;
            this.buttonAfisare.Text = "Ok";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // RetetaData
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RetetaData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RetetaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RetetaData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cData,
            this.CMedic,
            this.CDescriere,
            this.Medicament,
            this.Numar_flacoane});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RetetaData.DefaultCellStyle = dataGridViewCellStyle5;
            this.RetetaData.Location = new System.Drawing.Point(168, 63);
            this.RetetaData.Name = "RetetaData";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RetetaData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.RetetaData.Size = new System.Drawing.Size(544, 266);
            this.RetetaData.TabIndex = 9;
            this.RetetaData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RetetaData_CellContentClick);
            // 
            // cData
            // 
            this.cData.HeaderText = "Data";
            this.cData.Name = "cData";
            // 
            // CMedic
            // 
            this.CMedic.HeaderText = "Nume medic";
            this.CMedic.Name = "CMedic";
            // 
            // CDescriere
            // 
            this.CDescriere.HeaderText = "Denumire afectiune";
            this.CDescriere.Name = "CDescriere";
            // 
            // Medicament
            // 
            this.Medicament.HeaderText = "Medicament";
            this.Medicament.Name = "Medicament";
            // 
            // Numar_flacoane
            // 
            this.Numar_flacoane.HeaderText = "Numar flacoane";
            this.Numar_flacoane.Name = "Numar_flacoane";
            // 
            // BiletData
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BiletData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.BiletData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BiletData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CData3,
            this.CMedic3,
            this.CAfectiune3,
            this.Descriere,
            this.CNrB3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BiletData.DefaultCellStyle = dataGridViewCellStyle8;
            this.BiletData.Location = new System.Drawing.Point(168, 63);
            this.BiletData.Name = "BiletData";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BiletData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.BiletData.Size = new System.Drawing.Size(544, 266);
            this.BiletData.TabIndex = 10;
            this.BiletData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BiletData_CellContentClick);
            // 
            // CData3
            // 
            this.CData3.HeaderText = "Data";
            this.CData3.Name = "CData3";
            // 
            // CMedic3
            // 
            this.CMedic3.HeaderText = "Medic";
            this.CMedic3.Name = "CMedic3";
            // 
            // CAfectiune3
            // 
            this.CAfectiune3.HeaderText = "Denumire afectiune";
            this.CAfectiune3.Name = "CAfectiune3";
            // 
            // Descriere
            // 
            this.Descriere.HeaderText = "Descriere";
            this.Descriere.Name = "Descriere";
            // 
            // CNrB3
            // 
            this.CNrB3.HeaderText = "Numar bilet";
            this.CNrB3.Name = "CNrB3";
            // 
            // buttonBAck
            // 
            this.buttonBAck.Location = new System.Drawing.Point(12, 295);
            this.buttonBAck.Name = "buttonBAck";
            this.buttonBAck.Size = new System.Drawing.Size(85, 25);
            this.buttonBAck.TabIndex = 12;
            this.buttonBAck.Text = "Back";
            this.buttonBAck.UseVisualStyleBackColor = true;
            this.buttonBAck.Click += new System.EventHandler(this.buttonBAck_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(168, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(544, 290);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // View_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(713, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBAck);
            this.Controls.Add(this.BiletData);
            this.Controls.Add(this.RetetaData);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipC);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.buttonBilet);
            this.Controls.Add(this.buttonReteta);
            this.Controls.Add(this.buttonScutire);
            this.Controls.Add(this.ViewData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetetaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonScutire;
        private System.Windows.Forms.Button buttonReteta;
        private System.Windows.Forms.Button buttonBilet;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.DataGridView ViewData;
        private System.Windows.Forms.ComboBox comboBoxTipC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_medic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView RetetaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn cData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescriere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numar_flacoane;
        private System.Windows.Forms.DataGridView BiletData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CData3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMedic3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAfectiune3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriere;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNrB3;
        private System.Windows.Forms.Button buttonBAck;
        private System.Windows.Forms.Button button1;
    }
}