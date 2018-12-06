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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditProjekt = new System.Windows.Forms.Button();
            this.btnActiveProjekt = new System.Windows.Forms.Button();
            this.btnEditAngestellten = new System.Windows.Forms.Button();
            this.btnActiveAngestellten = new System.Windows.Forms.Button();
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
            this.groupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unternehmen Datenbank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewAngestellter
            // 
            this.btnNewAngestellter.Location = new System.Drawing.Point(30, 292);
            this.btnNewAngestellter.Name = "btnNewAngestellter";
            this.btnNewAngestellter.Size = new System.Drawing.Size(203, 29);
            this.btnNewAngestellter.TabIndex = 1;
            this.btnNewAngestellter.Text = "Neuen Angestellten erstellen";
            this.btnNewAngestellter.UseVisualStyleBackColor = true;
            this.btnNewAngestellter.Click += new System.EventHandler(this.addAngestellten);
            // 
            // btnViewAngestellte
            // 
            this.btnViewAngestellte.Location = new System.Drawing.Point(30, 397);
            this.btnViewAngestellte.Name = "btnViewAngestellte";
            this.btnViewAngestellte.Size = new System.Drawing.Size(203, 29);
            this.btnViewAngestellte.TabIndex = 2;
            this.btnViewAngestellte.Text = "Zeige alle Angestellten";
            this.btnViewAngestellte.UseVisualStyleBackColor = true;
            this.btnViewAngestellte.Click += new System.EventHandler(this.viewAngestellte);
            // 
            // btnShowProjects
            // 
            this.btnShowProjects.Location = new System.Drawing.Point(311, 397);
            this.btnShowProjects.Name = "btnShowProjects";
            this.btnShowProjects.Size = new System.Drawing.Size(203, 29);
            this.btnShowProjects.TabIndex = 6;
            this.btnShowProjects.Text = "Zeige alle Projekte";
            this.btnShowProjects.UseVisualStyleBackColor = true;
            this.btnShowProjects.Click += new System.EventHandler(this.btnShowProjects_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(311, 292);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(203, 29);
            this.btnCreateProject.TabIndex = 5;
            this.btnCreateProject.Text = "Neues Projekt erstellen";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnProjektteilnehmer
            // 
            this.btnProjektteilnehmer.Location = new System.Drawing.Point(311, 432);
            this.btnProjektteilnehmer.Name = "btnProjektteilnehmer";
            this.btnProjektteilnehmer.Size = new System.Drawing.Size(203, 29);
            this.btnProjektteilnehmer.TabIndex = 7;
            this.btnProjektteilnehmer.Text = "Projektteilnehmer";
            this.btnProjektteilnehmer.UseVisualStyleBackColor = true;
            this.btnProjektteilnehmer.Click += new System.EventHandler(this.btnProjektteilnehmer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Angestellte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Projekte";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditProjekt
            // 
            this.btnEditProjekt.Location = new System.Drawing.Point(311, 327);
            this.btnEditProjekt.Name = "btnEditProjekt";
            this.btnEditProjekt.Size = new System.Drawing.Size(203, 29);
            this.btnEditProjekt.TabIndex = 10;
            this.btnEditProjekt.Text = "Projekt bearbeiten";
            this.btnEditProjekt.UseVisualStyleBackColor = true;
            // 
            // btnActiveProjekt
            // 
            this.btnActiveProjekt.Location = new System.Drawing.Point(311, 362);
            this.btnActiveProjekt.Name = "btnActiveProjekt";
            this.btnActiveProjekt.Size = new System.Drawing.Size(203, 29);
            this.btnActiveProjekt.TabIndex = 11;
            this.btnActiveProjekt.Text = "Projekt (de-)aktivieren";
            this.btnActiveProjekt.UseVisualStyleBackColor = true;
            // 
            // btnEditAngestellten
            // 
            this.btnEditAngestellten.Location = new System.Drawing.Point(30, 327);
            this.btnEditAngestellten.Name = "btnEditAngestellten";
            this.btnEditAngestellten.Size = new System.Drawing.Size(203, 29);
            this.btnEditAngestellten.TabIndex = 12;
            this.btnEditAngestellten.Text = "Angestellten bearbeiten";
            this.btnEditAngestellten.UseVisualStyleBackColor = true;
            // 
            // btnActiveAngestellten
            // 
            this.btnActiveAngestellten.Location = new System.Drawing.Point(30, 362);
            this.btnActiveAngestellten.Name = "btnActiveAngestellten";
            this.btnActiveAngestellten.Size = new System.Drawing.Size(203, 29);
            this.btnActiveAngestellten.TabIndex = 13;
            this.btnActiveAngestellten.Text = "Angestellten (de-)aktivieren";
            this.btnActiveAngestellten.UseVisualStyleBackColor = true;
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
            this.groupSettings.Size = new System.Drawing.Size(503, 201);
            this.groupSettings.TabIndex = 14;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Einstellungen";
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.Location = new System.Drawing.Point(134, 164);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(99, 25);
            this.btnUpdateSettings.TabIndex = 11;
            this.btnUpdateSettings.Text = "Aktualisieren";
            this.btnUpdateSettings.UseVisualStyleBackColor = true;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // isWindowsAuthenticated
            // 
            this.isWindowsAuthenticated.AutoSize = true;
            this.isWindowsAuthenticated.Location = new System.Drawing.Point(134, 80);
            this.isWindowsAuthenticated.Name = "isWindowsAuthenticated";
            this.isWindowsAuthenticated.Size = new System.Drawing.Size(191, 20);
            this.isWindowsAuthenticated.TabIndex = 10;
            this.isWindowsAuthenticated.Text = "Windows Authentifizierung";
            this.isWindowsAuthenticated.UseVisualStyleBackColor = true;
            this.isWindowsAuthenticated.CheckedChanged += new System.EventHandler(this.isWindows_changed);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Passwort:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(134, 106);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 23);
            this.txtUsername.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Benutzername:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(134, 51);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(347, 23);
            this.txtDatabase.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Datenbank:";
            // 
            // txtDBServer
            // 
            this.txtDBServer.Location = new System.Drawing.Point(134, 22);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(347, 23);
            this.txtDBServer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datenbankserver:";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.ControlBox = false;
            this.Controls.Add(this.groupSettings);
            this.Controls.Add(this.btnActiveAngestellten);
            this.Controls.Add(this.btnEditAngestellten);
            this.Controls.Add(this.btnActiveProjekt);
            this.Controls.Add(this.btnEditProjekt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProjektteilnehmer);
            this.Controls.Add(this.btnShowProjects);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewAngestellte);
            this.Controls.Add(this.btnNewAngestellter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.ShowIcon = false;
            this.Text = "Hauptmenü";
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditProjekt;
        private System.Windows.Forms.Button btnActiveProjekt;
        private System.Windows.Forms.Button btnEditAngestellten;
        private System.Windows.Forms.Button btnActiveAngestellten;
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

    }
}
