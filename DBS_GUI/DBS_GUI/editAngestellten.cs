using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DBS_GUI {
    public partial class editAngestellten : Form {

        private SqlConnection connection;
        private int id;

        public editAngestellten(SqlConnection conn, int recvID) {
            InitializeComponent();
            connection = conn;
            id = recvID;
        }

        private void editAngestellte_Load(object sender, EventArgs e) {
            // TODO: make this also via SQL Stored Procedures!

            // Diese Codezeile lädt Daten in die Tabelle "unternehmDataSet.Abteilung".
            this.abteilungTableAdapter.Fill(this.unternehmDataSet.Abteilung);
            // Diese Codezeile lädt Daten in die Tabelle "unternehmDataSet.Niederlassung".
            this.niederlassungTableAdapter.Fill(this.unternehmDataSet.Niederlassung);


            // fill out existing Angestellten data:
            int found = 0;
            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetAllAngestellenDataForId", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
            using (SqlDataReader rdr = cmd.ExecuteReader()) {
                if (rdr.Read()) {
                    found = 1;
                    if ((String)rdr["Sex"] == "F") sexFemale.Checked = true;
                    else                           sexMale.Checked = true;
                    vornameTextBox.Text = (String) rdr["Vorname"];
                    nachnameTextBox.Text = (String) rdr["Nachname"];
                    emailTextBox.Text = (String) rdr["Email"];
                    gehaltNumericUpDown.Value = (Int32)rdr["Gehalt"];
                    abt_nrComboBox.SelectedValue = rdr["Abt_nr"];
                    firmaIDComboBox.SelectedValue = rdr["FirmaID"];
                    isActive.Checked = (Boolean) rdr["active"];
                }
            }
            connection.Close();

            if (found == 0) {
                MessageBox.Show("Kein Angestellter gefunden!\nBitte prüfen Sie die eingegebene ID!");
                this.Close();
            }
        }

        private void btnUpdateAngestellten_Click(object sender, EventArgs e) {
            connection.Open();
            // define SQL command:
            SqlCommand cmd = new SqlCommand("uspEditAngestellten", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("@active", SqlDbType.Bit).Value = isActive.Checked;
            cmd.Parameters.AddWithValue("@Sex", SqlDbType.VarChar).Value = sexMale.Checked ? "M" : "F";
            cmd.Parameters.AddWithValue("@Vorname", SqlDbType.VarChar).Value = vornameTextBox.Text.Trim();
            cmd.Parameters.AddWithValue("@Nachname", SqlDbType.VarChar).Value = nachnameTextBox.Text.Trim();
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = emailTextBox.Text.Trim();
            cmd.Parameters.AddWithValue("@Gehalt", SqlDbType.Int).Value = (int)gehaltNumericUpDown.Value;
            cmd.Parameters.AddWithValue("@FirmaID", SqlDbType.Int).Value = (int)firmaIDComboBox.SelectedValue;
            cmd.Parameters.AddWithValue("@Abt_nr", SqlDbType.Int).Value = (int)abt_nrComboBox.SelectedValue;

            cmd.ExecuteNonQuery();
            connection.Close();
            this.Close();
            MessageBox.Show("Angestellter geändert!");
        }


    }
}
