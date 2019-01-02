using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace DBS_GUI {
    public partial class mainMenu : Form {

        // holds connection to database
        private SqlConnection connection;

        public mainMenu() {
            InitializeComponent();

            txtDBServer.Text = @"MARKUS\SQLEXPRESS";
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

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnProjektteilnehmer_Click(object sender, EventArgs e) {
            Projektteilnehmer form = new Projektteilnehmer(connection);
            form.ShowDialog();
        }

        private void btnCreateProject_Click(object sender, EventArgs e) {
            raiseTesterrorSQL();
        }

        private void btnShowProjects_Click(object sender, EventArgs e) {
            raiseTesterrorSQL();
        }

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Abteillung form = new Abteillung();
            form.ShowDialog();
            
        }

        private void Niderl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nider form = new Nider();
            form.ShowDialog();
        }
    }
}
