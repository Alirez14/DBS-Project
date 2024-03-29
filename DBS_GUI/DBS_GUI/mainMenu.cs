﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace DBS_GUI {
    public partial class mainMenu : Form {

        // holds connection to database
        public SqlConnection connection;
        public string SQL;

        public mainMenu() {
            InitializeComponent();

            txtDBServer.Text = @".\SQLEXPRESS";
            txtDatabase.Text = "Unternehm";

            connection = new SqlConnection($"Data Source={txtDBServer.Text};Initial Catalog={txtDatabase.Text};Integrated Security=True");

            //isWindowsAuthenticated.Enabled = false;
            isWindowsAuthenticated.Checked = true;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.PasswordChar = '*';
        }

        private void btnUpdateSettings_Click(object sender, EventArgs e) {
            if (isWindowsAuthenticated.Checked) {
                connection.ConnectionString = $"Data Source={txtDBServer.Text};Initial Catalog={txtDatabase.Text};Integrated Security=True";
            }
            else {
                connection.ConnectionString = $"Data Source={txtDBServer.Text};Initial Catalog={txtDatabase.Text};User id={txtUsername.Text};Password={txtPassword.Text}";
            }
            MessageBox.Show("Changed Settings!");
        }

        private void isWindows_changed(object sender, EventArgs e) {
            if (isWindowsAuthenticated.Checked) {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void addAngestellten(object sender, EventArgs e) {
            newAngestellten form = new newAngestellten(connection);
            form.ShowDialog();
        }

        private void viewAngestellte(object sender, EventArgs e) {
            listAngestellte form = new listAngestellte(connection);
            form.ShowDialog();
        }

        private void btnEditAngestellten_Click(object sender, EventArgs e) {
            // MessageBox.Show("Edit Angestellten: " + (int)AngestelltenID.Value);
            editAngestellten form = new editAngestellten(connection, (int)AngestelltenID.Value);
            form.ShowDialog();
        }

        private void btnProjektteilnehmer_Click(object sender, EventArgs e) {
            Projektteilnehmer form = new Projektteilnehmer(connection);
            form.ShowDialog();
        }

        private void btnViewProjekteBestellungen_Click(object sender, EventArgs e) {
            // MessageBox.Show("Projekte und/oder Bestellungen anzeigen/bearbeiten.");
            projektForm form = new projektForm();
            form.ShowDialog();
        }

        private void btnViewKunden_Click(object sender, EventArgs e) {
            // MessageBox.Show("Zeige alle Kunden an!");
            kundeForm form = new kundeForm();
            form.ShowDialog();
        }

        private void btnViewNiederlassungen_Click(object sender, EventArgs e) {
            // MessageBox.Show("Zeige alle Niederlassungen an!");
            Nider form = new Nider();
            form.ShowDialog();
        }

        private void btnViewAbteilung_Click(object sender, EventArgs e) {
            // MessageBox.Show("Zeige alle Abteilungen an!");
            Abteillung form = new Abteillung();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnRaiseTestError_Click(object sender, EventArgs e) {
            raiseTesterrorSQL();
        }

        // SQL Help functions:
        private void raiseTesterrorSQL() {
            try {
                connection.Open();
                SqlCommand cmd = new SqlCommand("uspTesterror", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) {
                MessageBox.Show($"Message:\t{ex.Message}\nNumber:\t\t{ex.Number}\nstate:\t\t{ex.State}\nProcedure:\t{ex.Procedure}\nServer:\t\t{ex.Server}");
            }
            finally {
                connection.Close();
            }
        }
    }
}
