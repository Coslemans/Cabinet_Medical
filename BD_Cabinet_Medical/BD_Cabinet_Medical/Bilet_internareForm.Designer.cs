namespace BD_Cabinet_Medical
{
    partial class Bilet_internareForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.regLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 267);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Location = new System.Drawing.Point(545, 281);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(36, 13);
            this.regLabel.TabIndex = 1;
            this.regLabel.Text = "Medic";
            // 
            // Bilet_internareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 306);
            this.ControlBox = false;
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.backButton);
            this.Name = "Bilet_internareForm";
            this.Text = "Bilet_internareForm";
            this.Load += new System.EventHandler(this.Bilet_internareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label regLabel;
    }
}