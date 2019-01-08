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
            System.Windows.Forms.Label fK_Proj_nrLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.selectProjekt = new System.Windows.Forms.ComboBox();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.listTeilnehmer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TeilnehmerID = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.selectTeilnehmer = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            fK_Proj_nrLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listTeilnehmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeilnehmerID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fK_Proj_nrLabel
            // 
            fK_Proj_nrLabel.AutoSize = true;
            fK_Proj_nrLabel.Location = new System.Drawing.Point(12, 24);
            fK_Proj_nrLabel.Name = "fK_Proj_nrLabel";
            fK_Proj_nrLabel.Size = new System.Drawing.Size(64, 19);
            fK_Proj_nrLabel.TabIndex = 3;
            fK_Proj_nrLabel.Text = "Projekt:";
            // 
            // selectProjekt
            // 
            this.selectProjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectProjekt.FormattingEnabled = true;
            this.selectProjekt.Location = new System.Drawing.Point(110, 21);
            this.selectProjekt.Name = "selectProjekt";
            this.selectProjekt.Size = new System.Drawing.Size(366, 27);
            this.selectProjekt.TabIndex = 4;
            this.selectProjekt.SelectedIndexChanged += new System.EventHandler(this.ProjectChanged);
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.Location = new System.Drawing.Point(336, 21);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(106, 27);
            this.btnEntfernen.TabIndex = 5;
            this.btnEntfernen.Text = "Entfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            this.btnEntfernen.Click += new System.EventHandler(this.btnEntfernen_Click);
            // 
            // listTeilnehmer
            // 
            this.listTeilnehmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTeilnehmer.Location = new System.Drawing.Point(16, 77);
            this.listTeilnehmer.Name = "listTeilnehmer";
            this.listTeilnehmer.RowTemplate.Height = 24;
            this.listTeilnehmer.Size = new System.Drawing.Size(673, 232);
            this.listTeilnehmer.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 19);
            label1.TabIndex = 7;
            label1.Text = "Teilnehmer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            // 
            // TeilnehmerID
            // 
            this.TeilnehmerID.Location = new System.Drawing.Point(104, 21);
            this.TeilnehmerID.Name = "TeilnehmerID";
            this.TeilnehmerID.Size = new System.Drawing.Size(215, 27);
            this.TeilnehmerID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 19);
            label3.TabIndex = 11;
            label3.Text = "Teilnehmer:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 27);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // selectTeilnehmer
            // 
            this.selectTeilnehmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTeilnehmer.FormattingEnabled = true;
            this.selectTeilnehmer.Location = new System.Drawing.Point(104, 20);
            this.selectTeilnehmer.Name = "selectTeilnehmer";
            this.selectTeilnehmer.Size = new System.Drawing.Size(215, 27);
            this.selectTeilnehmer.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TeilnehmerID);
            this.groupBox1.Controls.Add(this.btnEntfernen);
            this.groupBox1.Location = new System.Drawing.Point(16, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 60);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Löschen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.selectTeilnehmer);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(16, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 59);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hinzufügen";
            // 
            // Projektteilnehmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.listTeilnehmer);
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
            ((System.ComponentModel.ISupportInitialize)(this.listTeilnehmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeilnehmerID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox selectProjekt;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.DataGridView listTeilnehmer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TeilnehmerID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox selectTeilnehmer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}