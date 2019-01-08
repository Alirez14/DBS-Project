namespace DBS_GUI
{
    partial class mainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewAngestellter = new System.Windows.Forms.Button();
            this.btnViewAngestellte = new System.Windows.Forms.Button();
            this.btnShowProjects = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnProjektteilnehmer = new System.Windows.Forms.Button();
            this.btnEditProjekt = new System.Windows.Forms.Button();
            this.btnEditAngestellten = new System.Windows.Forms.Button();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.btnUpdateSettings = new System.Windows.Forms.Button();
            this.isWindowsAuthenticated = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unternehmDataSet1 = new DBS_GUI.UnternehmDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnViewAbteilung = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnViewNiederlassungen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AngestelltenID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProjektID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.KundenID = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreateKunde = new System.Windows.Forms.Button();
            this.btnViewKunden = new System.Windows.Forms.Button();
            this.btnEditKunde = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnViewBestellungen = new System.Windows.Forms.Button();
            this.btnCreateBestellung = new System.Windows.Forms.Button();
            this.btnRaiseTestError = new System.Windows.Forms.Button();
            this.groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unternehmDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngestelltenID)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektID)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KundenID)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unternehmen Datenbank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(606, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewAngestellter
            // 
            this.btnNewAngestellter.Location = new System.Drawing.Point(10, 27);
            this.btnNewAngestellter.Name = "btnNewAngestellter";
            this.btnNewAngestellter.Size = new System.Drawing.Size(111, 29);
            this.btnNewAngestellter.TabIndex = 1;
            this.btnNewAngestellter.Text = "Neu";
            this.btnNewAngestellter.UseVisualStyleBackColor = true;
            this.btnNewAngestellter.Click += new System.EventHandler(this.addAngestellten);
            // 
            // btnViewAngestellte
            // 
            this.btnViewAngestellte.Location = new System.Drawing.Point(133, 27);
            this.btnViewAngestellte.Name = "btnViewAngestellte";
            this.btnViewAngestellte.Size = new System.Drawing.Size(125, 29);
            this.btnViewAngestellte.TabIndex = 2;
            this.btnViewAngestellte.Text = "Anzeigen";
            this.btnViewAngestellte.UseVisualStyleBackColor = true;
            this.btnViewAngestellte.Click += new System.EventHandler(this.viewAngestellte);
            // 
            // btnShowProjects
            // 
            this.btnShowProjects.Location = new System.Drawing.Point(135, 26);
            this.btnShowProjects.Name = "btnShowProjects";
            this.btnShowProjects.Size = new System.Drawing.Size(125, 29);
            this.btnShowProjects.TabIndex = 6;
            this.btnShowProjects.Text = "Anzeigen";
            this.btnShowProjects.UseVisualStyleBackColor = true;
            this.btnShowProjects.Click += new System.EventHandler(this.btnShowProjects_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(12, 26);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(111, 29);
            this.btnCreateProject.TabIndex = 5;
            this.btnCreateProject.Text = "Neu";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnProjektteilnehmer
            // 
            this.btnProjektteilnehmer.Location = new System.Drawing.Point(421, 152);
            this.btnProjektteilnehmer.Name = "btnProjektteilnehmer";
            this.btnProjektteilnehmer.Size = new System.Drawing.Size(274, 40);
            this.btnProjektteilnehmer.TabIndex = 7;
            this.btnProjektteilnehmer.Text = "Projektteilnehmer";
            this.btnProjektteilnehmer.UseVisualStyleBackColor = true;
            this.btnProjektteilnehmer.Click += new System.EventHandler(this.btnProjektteilnehmer_Click);
            // 
            // btnEditProjekt
            // 
            this.btnEditProjekt.Location = new System.Drawing.Point(135, 74);
            this.btnEditProjekt.Name = "btnEditProjekt";
            this.btnEditProjekt.Size = new System.Drawing.Size(125, 29);
            this.btnEditProjekt.TabIndex = 10;
            this.btnEditProjekt.Text = "Bearbeiten";
            this.btnEditProjekt.UseVisualStyleBackColor = true;
            this.btnEditProjekt.Click += new System.EventHandler(this.btnEditProjekt_Click);
            // 
            // btnEditAngestellten
            // 
            this.btnEditAngestellten.Location = new System.Drawing.Point(133, 71);
            this.btnEditAngestellten.Name = "btnEditAngestellten";
            this.btnEditAngestellten.Size = new System.Drawing.Size(125, 29);
            this.btnEditAngestellten.TabIndex = 12;
            this.btnEditAngestellten.Text = "Bearbeiten";
            this.btnEditAngestellten.UseVisualStyleBackColor = true;
            this.btnEditAngestellten.Click += new System.EventHandler(this.btnEditAngestellten_Click);
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.btnUpdateSettings);
            this.groupSettings.Controls.Add(this.isWindowsAuthenticated);
            this.groupSettings.Controls.Add(this.txtPassword);
            this.groupSettings.Controls.Add(this.label7);
            this.groupSettings.Controls.Add(this.txtUsername);
            this.groupSettings.Controls.Add(this.label6);
            this.groupSettings.Controls.Add(this.txtDatabase);
            this.groupSettings.Controls.Add(this.label5);
            this.groupSettings.Controls.Add(this.txtDBServer);
            this.groupSettings.Controls.Add(this.label4);
            this.groupSettings.Location = new System.Drawing.Point(11, 52);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(386, 201);
            this.groupSettings.TabIndex = 14;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Einstellungen";
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Location = new System.Drawing.Point(149, 161);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(155, 25);
            this.btnUpdateSettings.TabIndex = 11;
            this.btnUpdateSettings.Text = "Aktualisieren";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // isWindowsAuthenticated
            // 
            this.isWindowsAuthenticated.AutoSize = true;
            this.isWindowsAuthenticated.Location = new System.Drawing.Point(149, 77);
            this.isWindowsAuthenticated.Name = "isWindowsAuthenticated";
            this.isWindowsAuthenticated.Size = new System.Drawing.Size(224, 23);
            this.isWindowsAuthenticated.TabIndex = 10;
            this.isWindowsAuthenticated.Text = "Windows Authentifizierung";
            this.isWindowsAuthenticated.UseVisualStyleBackColor = true;
            this.isWindowsAuthenticated.CheckedChanged += new System.EventHandler(this.isWindows_changed);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 27);
            this.txtPassword.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Passwort:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(149, 103);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 27);
            this.txtUsername.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Benutzername:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(149, 48);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(224, 27);
            this.txtDatabase.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Datenbank:";
            // 
            // txtDBServer
            // 
            this.txtDBServer.Location = new System.Drawing.Point(149, 19);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(224, 27);
            this.txtDBServer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datenbankserver:";
            // 
            // unternehmDataSet1
            // 
            this.unternehmDataSet1.DataSetName = "UnternehmDataSet";
            this.unternehmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 272);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnViewAbteilung);
            this.groupBox7.Location = new System.Drawing.Point(33, 145);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(313, 101);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Abteilungen";
            // 
            // btnViewAbteilung
            // 
            this.btnViewAbteilung.Location = new System.Drawing.Point(24, 36);
            this.btnViewAbteilung.Name = "btnViewAbteilung";
            this.btnViewAbteilung.Size = new System.Drawing.Size(262, 40);
            this.btnViewAbteilung.TabIndex = 21;
            this.btnViewAbteilung.Text = "Anzeigen und Bearbeiten";
            this.btnViewAbteilung.UseVisualStyleBackColor = true;
            this.btnViewAbteilung.Click += new System.EventHandler(this.btnViewAbteilung_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnViewNiederlassungen);
            this.groupBox6.Location = new System.Drawing.Point(33, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 95);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Niederlassungen";
            // 
            // btnViewNiederlassungen
            // 
            this.btnViewNiederlassungen.Location = new System.Drawing.Point(24, 35);
            this.btnViewNiederlassungen.Name = "btnViewNiederlassungen";
            this.btnViewNiederlassungen.Size = new System.Drawing.Size(262, 40);
            this.btnViewNiederlassungen.TabIndex = 1;
            this.btnViewNiederlassungen.Text = "Anzeigen und Bearbeiten";
            this.btnViewNiederlassungen.UseVisualStyleBackColor = true;
            this.btnViewNiederlassungen.Click += new System.EventHandler(this.btnViewNiederlassungen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AngestelltenID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnNewAngestellter);
            this.groupBox2.Controls.Add(this.btnViewAngestellte);
            this.groupBox2.Controls.Add(this.btnEditAngestellten);
            this.groupBox2.Location = new System.Drawing.Point(421, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 117);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angestellten";
            // 
            // AngestelltenID
            // 
            this.AngestelltenID.Location = new System.Drawing.Point(49, 74);
            this.AngestelltenID.Name = "AngestelltenID";
            this.AngestelltenID.Size = new System.Drawing.Size(72, 27);
            this.AngestelltenID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProjektID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnCreateProject);
            this.groupBox3.Controls.Add(this.btnShowProjects);
            this.groupBox3.Controls.Add(this.btnEditProjekt);
            this.groupBox3.Location = new System.Drawing.Point(423, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 114);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Projekte";
            // 
            // ProjektID
            // 
            this.ProjektID.Location = new System.Drawing.Point(51, 77);
            this.ProjektID.Name = "ProjektID";
            this.ProjektID.Size = new System.Drawing.Size(72, 27);
            this.ProjektID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.KundenID);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnCreateKunde);
            this.groupBox4.Controls.Add(this.btnViewKunden);
            this.groupBox4.Controls.Add(this.btnEditKunde);
            this.groupBox4.Location = new System.Drawing.Point(421, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 116);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kunden";
            // 
            // KundenID
            // 
            this.KundenID.Location = new System.Drawing.Point(51, 72);
            this.KundenID.Name = "KundenID";
            this.KundenID.Size = new System.Drawing.Size(72, 27);
            this.KundenID.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID:";
            // 
            // btnCreateKunde
            // 
            this.btnCreateKunde.Location = new System.Drawing.Point(18, 26);
            this.btnCreateKunde.Name = "btnCreateKunde";
            this.btnCreateKunde.Size = new System.Drawing.Size(105, 29);
            this.btnCreateKunde.TabIndex = 17;
            this.btnCreateKunde.Text = "Neu";
            this.btnCreateKunde.UseVisualStyleBackColor = true;
            this.btnCreateKunde.Click += new System.EventHandler(this.btnCreateKunde_Click);
            // 
            // btnViewKunden
            // 
            this.btnViewKunden.Location = new System.Drawing.Point(135, 26);
            this.btnViewKunden.Name = "btnViewKunden";
            this.btnViewKunden.Size = new System.Drawing.Size(125, 29);
            this.btnViewKunden.TabIndex = 18;
            this.btnViewKunden.Text = "Anzeigen";
            this.btnViewKunden.UseVisualStyleBackColor = true;
            this.btnViewKunden.Click += new System.EventHandler(this.btnViewKunden_Click);
            // 
            // btnEditKunde
            // 
            this.btnEditKunde.Location = new System.Drawing.Point(135, 69);
            this.btnEditKunde.Name = "btnEditKunde";
            this.btnEditKunde.Size = new System.Drawing.Size(125, 29);
            this.btnEditKunde.TabIndex = 19;
            this.btnEditKunde.Text = "Bearbeiten";
            this.btnEditKunde.UseVisualStyleBackColor = true;
            this.btnEditKunde.Click += new System.EventHandler(this.btnEditKunde_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnViewBestellungen);
            this.groupBox5.Controls.Add(this.btnCreateBestellung);
            this.groupBox5.Location = new System.Drawing.Point(423, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 74);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bestellungen";
            // 
            // btnViewBestellungen
            // 
            this.btnViewBestellungen.Location = new System.Drawing.Point(153, 26);
            this.btnViewBestellungen.Name = "btnViewBestellungen";
            this.btnViewBestellungen.Size = new System.Drawing.Size(105, 32);
            this.btnViewBestellungen.TabIndex = 1;
            this.btnViewBestellungen.Text = "Anzeigen";
            this.btnViewBestellungen.UseVisualStyleBackColor = true;
            this.btnViewBestellungen.Click += new System.EventHandler(this.btnViewBestellungen_Click);
            // 
            // btnCreateBestellung
            // 
            this.btnCreateBestellung.Location = new System.Drawing.Point(31, 25);
            this.btnCreateBestellung.Name = "btnCreateBestellung";
            this.btnCreateBestellung.Size = new System.Drawing.Size(116, 33);
            this.btnCreateBestellung.TabIndex = 0;
            this.btnCreateBestellung.Text = "Erstellen";
            this.btnCreateBestellung.UseVisualStyleBackColor = true;
            this.btnCreateBestellung.Click += new System.EventHandler(this.btnCreateBestellung_Click);
            // 
            // btnRaiseTestError
            // 
            this.btnRaiseTestError.Location = new System.Drawing.Point(12, 550);
            this.btnRaiseTestError.Name = "btnRaiseTestError";
            this.btnRaiseTestError.Size = new System.Drawing.Size(224, 29);
            this.btnRaiseTestError.TabIndex = 24;
            this.btnRaiseTestError.Text = "Raise SQL Test Error";
            this.btnRaiseTestError.UseVisualStyleBackColor = true;
            this.btnRaiseTestError.Click += new System.EventHandler(this.btnRaiseTestError_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 591);
            this.Controls.Add(this.btnRaiseTestError);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProjektteilnehmer);
            this.Controls.Add(this.groupSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.ShowIcon = false;
            this.Text = "Hauptmenü";
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unternehmDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngestelltenID)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjektID)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KundenID)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewAngestellter;
        private System.Windows.Forms.Button btnViewAngestellte;

        private System.Windows.Forms.Button btnShowProjects;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnProjektteilnehmer;
        private System.Windows.Forms.Button btnEditProjekt;
        private System.Windows.Forms.Button btnEditAngestellten;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isWindowsAuthenticated;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateSettings;
        private System.Windows.Forms.TextBox txtUsername;
        private UnternehmDataSet unternehmDataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnViewBestellungen;
        private System.Windows.Forms.Button btnCreateBestellung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCreateKunde;
        private System.Windows.Forms.Button btnViewKunden;
        private System.Windows.Forms.Button btnEditKunde;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnViewAbteilung;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnViewNiederlassungen;
        private System.Windows.Forms.Button btnRaiseTestError;
        private System.Windows.Forms.NumericUpDown AngestelltenID;
        private System.Windows.Forms.NumericUpDown ProjektID;
        private System.Windows.Forms.NumericUpDown KundenID;
    }
}
