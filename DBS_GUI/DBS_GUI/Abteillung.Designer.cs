namespace DBS_GUI
{
    partial class Abteillung
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ADDbtn = new System.Windows.Forms.Button();
            this.Anzahl_Angestellte = new System.Windows.Forms.TextBox();
            this.Emailab = new System.Windows.Forms.TextBox();
            this.nameab = new System.Windows.Forms.TextBox();
            this.Telefonab = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.IDFinder = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ADDbtn
            // 
            this.ADDbtn.Enabled = false;
            this.ADDbtn.Location = new System.Drawing.Point(713, 234);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(75, 23);
            this.ADDbtn.TabIndex = 1;
            this.ADDbtn.Text = "ADD";
            this.ADDbtn.UseVisualStyleBackColor = true;
            this.ADDbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ADDbtn_MouseClick);
            // 
            // Anzahl_Angestellte
            // 
            this.Anzahl_Angestellte.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Anzahl_Angestellte.Location = new System.Drawing.Point(50, 262);
            this.Anzahl_Angestellte.Name = "Anzahl_Angestellte";
            this.Anzahl_Angestellte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Anzahl_Angestellte.Size = new System.Drawing.Size(166, 20);
            this.Anzahl_Angestellte.TabIndex = 2;
            // 
            // Emailab
            // 
            this.Emailab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Emailab.Location = new System.Drawing.Point(50, 288);
            this.Emailab.Name = "Emailab";
            this.Emailab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Emailab.Size = new System.Drawing.Size(166, 20);
            this.Emailab.TabIndex = 3;
            // 
            // nameab
            // 
            this.nameab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameab.Location = new System.Drawing.Point(50, 236);
            this.nameab.Name = "nameab";
            this.nameab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameab.Size = new System.Drawing.Size(166, 20);
            this.nameab.TabIndex = 4;
            this.nameab.TextChanged += new System.EventHandler(this.nameab_TextChanged);
            // 
            // Telefonab
            // 
            this.Telefonab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Telefonab.Location = new System.Drawing.Point(50, 314);
            this.Telefonab.Name = "Telefonab";
            this.Telefonab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Telefonab.Size = new System.Drawing.Size(166, 20);
            this.Telefonab.TabIndex = 5;
            // 
            // updatebtn
            // 
            this.updatebtn.Enabled = false;
            this.updatebtn.Location = new System.Drawing.Point(713, 366);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // IDFinder
            // 
            this.IDFinder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDFinder.Location = new System.Drawing.Point(50, 369);
            this.IDFinder.Name = "IDFinder";
            this.IDFinder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDFinder.Size = new System.Drawing.Size(166, 20);
            this.IDFinder.TabIndex = 7;
            this.IDFinder.TextChanged += new System.EventHandler(this.IDFinder_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.Enabled = false;
            this.Savebtn.Location = new System.Drawing.Point(713, 395);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 8;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anzahl";
            // 
            // Abteillung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.IDFinder);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Telefonab);
            this.Controls.Add(this.nameab);
            this.Controls.Add(this.Emailab);
            this.Controls.Add(this.Anzahl_Angestellte);
            this.Controls.Add(this.ADDbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Abteillung";
            this.Text = "Abteillung";
            this.Load += new System.EventHandler(this.Abteillung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ADDbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Savebtn;
        public System.Windows.Forms.TextBox Anzahl_Angestellte;
        public System.Windows.Forms.TextBox Emailab;
        public System.Windows.Forms.TextBox nameab;
        public System.Windows.Forms.TextBox Telefonab;
        public System.Windows.Forms.TextBox IDFinder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}