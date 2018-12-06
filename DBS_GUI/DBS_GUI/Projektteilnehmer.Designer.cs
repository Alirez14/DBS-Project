namespace DBS_GUI
{
    partial class Projektteilnehmer
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
            System.Windows.Forms.Label labelTeilnehmer;
            System.Windows.Forms.Label fK_Proj_nrLabel;
            this.selectProjekt = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.selectTeilnehmer = new System.Windows.Forms.ListBox();
            this.txtTeilnehmerfilter = new System.Windows.Forms.TextBox();
            labelTeilnehmer = new System.Windows.Forms.Label();
            fK_Proj_nrLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTeilnehmer
            // 
            labelTeilnehmer.AutoSize = true;
            labelTeilnehmer.Location = new System.Drawing.Point(12, 61);
            labelTeilnehmer.Name = "labelTeilnehmer";
            labelTeilnehmer.Size = new System.Drawing.Size(81, 16);
            labelTeilnehmer.TabIndex = 1;
            labelTeilnehmer.Text = "Teilnehmer:";
            // 
            // fK_Proj_nrLabel
            // 
            fK_Proj_nrLabel.AutoSize = true;
            fK_Proj_nrLabel.Location = new System.Drawing.Point(12, 24);
            fK_Proj_nrLabel.Name = "fK_Proj_nrLabel";
            fK_Proj_nrLabel.Size = new System.Drawing.Size(56, 16);
            fK_Proj_nrLabel.TabIndex = 3;
            fK_Proj_nrLabel.Text = "Projekt:";
            // 
            // selectProjekt
            // 
            this.selectProjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectProjekt.FormattingEnabled = true;
            this.selectProjekt.Location = new System.Drawing.Point(99, 21);
            this.selectProjekt.Name = "selectProjekt";
            this.selectProjekt.Size = new System.Drawing.Size(377, 24);
            this.selectProjekt.TabIndex = 4;
            this.selectProjekt.SelectedIndexChanged += new System.EventHandler(this.ProjectChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(388, 365);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Bestätigen";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // selectTeilnehmer
            // 
            this.selectTeilnehmer.FormattingEnabled = true;
            this.selectTeilnehmer.ItemHeight = 16;
            this.selectTeilnehmer.Location = new System.Drawing.Point(99, 83);
            this.selectTeilnehmer.Name = "selectTeilnehmer";
            this.selectTeilnehmer.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectTeilnehmer.Size = new System.Drawing.Size(377, 276);
            this.selectTeilnehmer.TabIndex = 6;
            // 
            // txtTeilnehmerfilter
            // 
            this.txtTeilnehmerfilter.Location = new System.Drawing.Point(99, 58);
            this.txtTeilnehmerfilter.Name = "txtTeilnehmerfilter";
            this.txtTeilnehmerfilter.Size = new System.Drawing.Size(377, 23);
            this.txtTeilnehmerfilter.TabIndex = 8;
            this.txtTeilnehmerfilter.TextChanged += new System.EventHandler(this.Teilnehmerfilter_changed);
            // 
            // Projektteilnehmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 404);
            this.Controls.Add(this.txtTeilnehmerfilter);
            this.Controls.Add(this.selectTeilnehmer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(labelTeilnehmer);
            this.Controls.Add(fK_Proj_nrLabel);
            this.Controls.Add(this.selectProjekt);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Projektteilnehmer";
            this.ShowIcon = false;
            this.Text = "Projektteilnehmer ändern";
            this.Load += new System.EventHandler(this.Projektteilnehmer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox selectProjekt;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox selectTeilnehmer;
        private System.Windows.Forms.TextBox txtTeilnehmerfilter;
    }
}