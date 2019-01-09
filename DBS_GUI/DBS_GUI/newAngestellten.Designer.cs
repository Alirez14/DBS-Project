namespace DBS_GUI
{
    partial class newAngestellten
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
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label vornameLabel;
            System.Windows.Forms.Label nachnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gehaltLabel;
            System.Windows.Forms.Label firmaIDLabel;
            System.Windows.Forms.Label abt_nrLabel;
            this.unternehmDataSet = new DBS_GUI.UnternehmDataSet();
            this.sexMale = new System.Windows.Forms.RadioButton();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gehaltNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.firmaIDComboBox = new System.Windows.Forms.ComboBox();
            this.niederlassungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abt_nrComboBox = new System.Windows.Forms.ComboBox();
            this.abteilungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.niederlassungTableAdapter = new DBS_GUI.UnternehmDataSetTableAdapters.NiederlassungTableAdapter();
            this.abteilungTableAdapter = new DBS_GUI.UnternehmDataSetTableAdapters.AbteilungTableAdapter();
            this.sexFemale = new System.Windows.Forms.RadioButton();
            this.btnCreateAngestellten = new System.Windows.Forms.Button();
            sexLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            nachnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gehaltLabel = new System.Windows.Forms.Label();
            firmaIDLabel = new System.Windows.Forms.Label();
            abt_nrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unternehmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gehaltNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niederlassungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abteilungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(12, 43);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(83, 16);
            sexLabel.TabIndex = 0;
            sexLabel.Text = "Geschlecht:";
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(12, 71);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(68, 16);
            vornameLabel.TabIndex = 3;
            vornameLabel.Text = "Vorname:";
            // 
            // nachnameLabel
            // 
            nachnameLabel.AutoSize = true;
            nachnameLabel.Location = new System.Drawing.Point(12, 104);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new System.Drawing.Size(79, 16);
            nachnameLabel.TabIndex = 5;
            nachnameLabel.Text = "Nachname:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 137);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // gehaltLabel
            // 
            gehaltLabel.AutoSize = true;
            gehaltLabel.Location = new System.Drawing.Point(12, 167);
            gehaltLabel.Name = "gehaltLabel";
            gehaltLabel.Size = new System.Drawing.Size(54, 16);
            gehaltLabel.TabIndex = 9;
            gehaltLabel.Text = "Gehalt:";
            // 
            // firmaIDLabel
            // 
            firmaIDLabel.AutoSize = true;
            firmaIDLabel.Location = new System.Drawing.Point(12, 203);
            firmaIDLabel.Name = "firmaIDLabel";
            firmaIDLabel.Size = new System.Drawing.Size(102, 16);
            firmaIDLabel.TabIndex = 11;
            firmaIDLabel.Text = "Niederlassung:";
            // 
            // abt_nrLabel
            // 
            abt_nrLabel.AutoSize = true;
            abt_nrLabel.Location = new System.Drawing.Point(12, 236);
            abt_nrLabel.Name = "abt_nrLabel";
            abt_nrLabel.Size = new System.Drawing.Size(71, 16);
            abt_nrLabel.TabIndex = 13;
            abt_nrLabel.Text = "Abteilung:";
            // 
            // unternehmDataSet
            // 
            this.unternehmDataSet.DataSetName = "UnternehmDataSet";
            this.unternehmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexMale
            // 
            this.sexMale.Location = new System.Drawing.Point(176, 42);
            this.sexMale.Name = "sexMale";
            this.sexMale.Size = new System.Drawing.Size(127, 24);
            this.sexMale.TabIndex = 1;
            this.sexMale.TabStop = true;
            this.sexMale.Text = "männlich";
            this.sexMale.UseVisualStyleBackColor = true;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Location = new System.Drawing.Point(176, 73);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(236, 23);
            this.vornameTextBox.TabIndex = 4;
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.Location = new System.Drawing.Point(176, 106);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(236, 23);
            this.nachnameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(176, 139);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(236, 23);
            this.emailTextBox.TabIndex = 8;
            // 
            // gehaltNumericUpDown
            // 
            this.gehaltNumericUpDown.Location = new System.Drawing.Point(176, 172);
            this.gehaltNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.gehaltNumericUpDown.Name = "gehaltNumericUpDown";
            this.gehaltNumericUpDown.Size = new System.Drawing.Size(127, 23);
            this.gehaltNumericUpDown.TabIndex = 10;
            // 
            // firmaIDComboBox
            // 
            this.firmaIDComboBox.DataSource = this.niederlassungBindingSource;
            this.firmaIDComboBox.DisplayMember = "Ort";
            this.firmaIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmaIDComboBox.FormattingEnabled = true;
            this.firmaIDComboBox.Location = new System.Drawing.Point(176, 205);
            this.firmaIDComboBox.Name = "firmaIDComboBox";
            this.firmaIDComboBox.Size = new System.Drawing.Size(236, 24);
            this.firmaIDComboBox.TabIndex = 12;
            this.firmaIDComboBox.ValueMember = "PK_FirmaID";
            // 
            // niederlassungBindingSource
            // 
            this.niederlassungBindingSource.DataMember = "Niederlassung";
            this.niederlassungBindingSource.DataSource = this.unternehmDataSet;
            // 
            // abt_nrComboBox
            // 
            this.abt_nrComboBox.DataSource = this.abteilungBindingSource;
            this.abt_nrComboBox.DisplayMember = "Name";
            this.abt_nrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abt_nrComboBox.FormattingEnabled = true;
            this.abt_nrComboBox.Location = new System.Drawing.Point(176, 238);
            this.abt_nrComboBox.Name = "abt_nrComboBox";
            this.abt_nrComboBox.Size = new System.Drawing.Size(236, 24);
            this.abt_nrComboBox.TabIndex = 14;
            this.abt_nrComboBox.ValueMember = "PK_Abt_nr";
            // 
            // abteilungBindingSource
            // 
            this.abteilungBindingSource.DataMember = "Abteilung";
            this.abteilungBindingSource.DataSource = this.unternehmDataSet;
            // 
            // niederlassungTableAdapter
            // 
            this.niederlassungTableAdapter.ClearBeforeFill = true;
            // 
            // abteilungTableAdapter
            // 
            this.abteilungTableAdapter.ClearBeforeFill = true;
            // 
            // sexFemale
            // 
            this.sexFemale.Location = new System.Drawing.Point(309, 44);
            this.sexFemale.Name = "sexFemale";
            this.sexFemale.Size = new System.Drawing.Size(126, 23);
            this.sexFemale.TabIndex = 2;
            this.sexFemale.TabStop = true;
            this.sexFemale.Text = "weiblich";
            this.sexFemale.UseVisualStyleBackColor = true;
            // 
            // btnCreateAngestellten
            // 
            this.btnCreateAngestellten.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAngestellten.Location = new System.Drawing.Point(15, 282);
            this.btnCreateAngestellten.Name = "btnCreateAngestellten";
            this.btnCreateAngestellten.Size = new System.Drawing.Size(400, 55);
            this.btnCreateAngestellten.TabIndex = 15;
            this.btnCreateAngestellten.Text = "Erstellen";
            this.btnCreateAngestellten.UseVisualStyleBackColor = true;
            this.btnCreateAngestellten.Click += new System.EventHandler(this.addNewAngestellten);
            // 
            // newAngestellten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 354);
            this.Controls.Add(this.btnCreateAngestellten);
            this.Controls.Add(this.sexFemale);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexMale);
            this.Controls.Add(vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(nachnameLabel);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(gehaltLabel);
            this.Controls.Add(this.gehaltNumericUpDown);
            this.Controls.Add(firmaIDLabel);
            this.Controls.Add(this.firmaIDComboBox);
            this.Controls.Add(abt_nrLabel);
            this.Controls.Add(this.abt_nrComboBox);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newAngestellten";
            this.ShowIcon = false;
            this.Text = "Neuen Angestellten erstellen";
            this.Load += new System.EventHandler(this.newAngestellte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unternehmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gehaltNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niederlassungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abteilungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UnternehmDataSet unternehmDataSet;
        private System.Windows.Forms.RadioButton sexMale;
        private System.Windows.Forms.RadioButton sexFemale;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.NumericUpDown gehaltNumericUpDown;
        private System.Windows.Forms.ComboBox firmaIDComboBox;
        private System.Windows.Forms.ComboBox abt_nrComboBox;
        private UnternehmDataSetTableAdapters.NiederlassungTableAdapter niederlassungTableAdapter;
        private System.Windows.Forms.BindingSource niederlassungBindingSource;
        private UnternehmDataSetTableAdapters.AbteilungTableAdapter abteilungTableAdapter;
        private System.Windows.Forms.BindingSource abteilungBindingSource;
        private System.Windows.Forms.Button btnCreateAngestellten;
    }
}