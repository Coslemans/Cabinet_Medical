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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Form));
            this.buttonScutire = new System.Windows.Forms.Button();
            this.buttonReteta = new System.Windows.Forms.Button();
            this.buttonBilet = new System.Windows.Forms.Button();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelNumePacient = new System.Windows.Forms.Label();
            this.ViewData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScutire
            // 
            this.buttonScutire.Location = new System.Drawing.Point(16, 180);
            this.buttonScutire.Name = "buttonScutire";
            this.buttonScutire.Size = new System.Drawing.Size(85, 25);
            this.buttonScutire.TabIndex = 1;
            this.buttonScutire.Text = "Scutire";
            this.buttonScutire.UseVisualStyleBackColor = true;
            // 
            // buttonReteta
            // 
            this.buttonReteta.Location = new System.Drawing.Point(16, 238);
            this.buttonReteta.Name = "buttonReteta";
            this.buttonReteta.Size = new System.Drawing.Size(85, 25);
            this.buttonReteta.TabIndex = 2;
            this.buttonReteta.Text = "Reteta";
            this.buttonReteta.UseVisualStyleBackColor = true;
            this.buttonReteta.Click += new System.EventHandler(this.buttonReteta_Click);
            // 
            // buttonBilet
            // 
            this.buttonBilet.Location = new System.Drawing.Point(16, 284);
            this.buttonBilet.Name = "buttonBilet";
            this.buttonBilet.Size = new System.Drawing.Size(85, 25);
            this.buttonBilet.TabIndex = 3;
            this.buttonBilet.Text = "Bilet internare";
            this.buttonBilet.UseVisualStyleBackColor = true;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(12, 39);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(41, 15);
            this.labelNume.TabIndex = 5;
            this.labelNume.Text = "Nume";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // labelNumePacient
            // 
            this.labelNumePacient.AutoSize = true;
            this.labelNumePacient.Location = new System.Drawing.Point(92, 25);
            this.labelNumePacient.Name = "labelNumePacient";
            this.labelNumePacient.Size = new System.Drawing.Size(0, 13);
            this.labelNumePacient.TabIndex = 6;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewData.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.ViewData.Location = new System.Drawing.Point(184, 39);
            this.ViewData.Name = "ViewData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ViewData.Size = new System.Drawing.Size(706, 304);
            this.ViewData.TabIndex = 0;
            this.ViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewData_CellContentClick);
            // 
            // View_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(893, 355);
            this.Controls.Add(this.labelNumePacient);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonScutire;
        private System.Windows.Forms.Button buttonReteta;
        private System.Windows.Forms.Button buttonBilet;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelNumePacient;
        private System.Windows.Forms.DataGridView ViewData;
    }
}