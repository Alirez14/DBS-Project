using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DBS_GUI {
    public partial class newAngestellten : Form {

        private SqlConnection connection;

        public newAngestellten(SqlConnection conn) {
            InitializeComponent();
            connection = conn;
        }

        private void newAngestellte_Load(object sender, EventArgs e) {
            // TODO: make this also via SQL Stored Procedures!
            
            // Diese Codezeile lädt Daten in die Tabelle "unternehmDataSet.Abteilung".
            this.abteilungTableAdapter.Fill(this.unternehmDataSet.Abteilung);
            // Diese Codezeile lädt Daten in die Tabelle "unternehmDataSet.Niederlassung".
            this.niederlassungTableAdapter.Fill(this.unternehmDataSet.Niederlassung);
        }

        private void addNewAngestellten(object sender, EventArgs e) {

            connection.Open();
            // define SQL command:
            SqlCommand cmd = new SqlCommand("uspAddNewAngestellten", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Sex", SqlDbType.VarChar).Value = sexMale.Checked ? "M" : "F";
            cmd.Parameters.AddWithValue("@Vorname", SqlDbType.VarChar).Value = vornameTextBox.Text.Trim();
            cmd.Parameters.AddWithValue("@Nachname", SqlDbType.VarChar).Value = nachnameTextBox.Text.Trim();
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = emailTextBox.Text.Trim();
            cmd.Parameters.AddWithValue("@Gehalt", SqlDbType.Int).Value = (int) gehaltNumericUpDown.Value;
            cmd.Parameters.AddWithValue("@FirmaID", SqlDbType.Int).Value = (int) firmaIDComboBox.SelectedValue;
            cmd.Parameters.AddWithValue("@Abt_nr", SqlDbType.Int).Value = (int) abt_nrComboBox.SelectedValue;

            cmd.ExecuteNonQuery();
            connection.Close();
            this.Close();
            MessageBox.Show("Angestellter hinzugefügt!");
        }
        
    }
}
