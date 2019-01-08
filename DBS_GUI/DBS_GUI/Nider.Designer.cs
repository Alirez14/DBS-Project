namespace DBS_GUI
{
    partial class Nider
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unternehmDataSet = new DBS_GUI.UnternehmDataSet();
            this.niederlassungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.niederlassungTableAdapter = new DBS_GUI.UnternehmDataSetTableAdapters.NiederlassungTableAdapter();
            this.NiderAdd = new System.Windows.Forms.Button();
            this.NiderOrt = new System.Windows.Forms.TextBox();
            this.NiderEmail = new System.Windows.Forms.TextBox();
            this.NiderTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.NiderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unternehmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niederlassungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // unternehmDataSet
            // 
            this.unternehmDataSet.DataSetName = "UnternehmDataSet";
            this.unternehmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // niederlassungBindingSource
            // 
            this.niederlassungBindingSource.DataMember = "Niederlassung";
            this.niederlassungBindingSource.DataSource = this.unternehmDataSet;
            // 
            // niederlassungTableAdapter
            // 
            this.niederlassungTableAdapter.ClearBeforeFill = true;
            // 
            // NiderAdd
            // 
            this.NiderAdd.Enabled = false;
            this.NiderAdd.Location = new System.Drawing.Point(678, 256);
            this.NiderAdd.Name = "NiderAdd";
            this.NiderAdd.Size = new System.Drawing.Size(75, 23);
            this.NiderAdd.TabIndex = 1;
            this.NiderAdd.Text = "ADD";
            this.NiderAdd.UseVisualStyleBackColor = true;
            this.NiderAdd.Click += new System.EventHandler(this.ADDBTN);
            // 
            // NiderOrt
            // 
            this.NiderOrt.Location = new System.Drawing.Point(60, 256);
            this.NiderOrt.Name = "NiderOrt";
            this.NiderOrt.Size = new System.Drawing.Size(156, 20);
            this.NiderOrt.TabIndex = 2;
            this.NiderOrt.TextChanged += new System.EventHandler(this.NiderOrt_TextChanged);
            // 
            // NiderEmail
            // 
            this.NiderEmail.Location = new System.Drawing.Point(60, 308);
            this.NiderEmail.Name = "NiderEmail";
            this.NiderEmail.Size = new System.Drawing.Size(156, 20);
            this.NiderEmail.TabIndex = 3;
            // 
            // NiderTel
            // 
            this.NiderTel.Location = new System.Drawing.Point(60, 282);
            this.NiderTel.Name = "NiderTel";
            this.NiderTel.Size = new System.Drawing.Size(156, 20);
            this.NiderTel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel";
            // 
            // SAVE
            // 
            this.SAVE.Enabled = false;
            this.SAVE.Location = new System.Drawing.Point(678, 401);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 23);
            this.SAVE.TabIndex = 8;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVEBTN);
            // 
            // UPDATE
            // 
            this.UPDATE.Enabled = false;
            this.UPDATE.Location = new System.Drawing.Point(678, 372);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(75, 23);
            this.UPDATE.TabIndex = 9;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATEBTN);
            // 
            // NiderID
            // 
            this.NiderID.Location = new System.Drawing.Point(60, 372);
            this.NiderID.Name = "NiderID";
            this.NiderID.Size = new System.Drawing.Size(156, 20);
            this.NiderID.TabIndex = 10;
            this.NiderID.TextChanged += new System.EventHandler(this.NiderID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // Nider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NiderID);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NiderTel);
            this.Controls.Add(this.NiderEmail);
            this.Controls.Add(this.NiderOrt);
            this.Controls.Add(this.NiderAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Nider";
            this.Text = "Nider";
            this.Load += new System.EventHandler(this.Nider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unternehmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niederlassungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UnternehmDataSet unternehmDataSet;
        private System.Windows.Forms.BindingSource niederlassungBindingSource;
        private UnternehmDataSetTableAdapters.NiederlassungTableAdapter niederlassungTableAdapter;
        private System.Windows.Forms.Button NiderAdd;
        private System.Windows.Forms.TextBox NiderOrt;
        private System.Windows.Forms.TextBox NiderEmail;
        private System.Windows.Forms.TextBox NiderTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.TextBox NiderID;
        private System.Windows.Forms.Label label4;
    }
}