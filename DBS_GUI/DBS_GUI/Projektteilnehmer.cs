using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DBS_GUI {
    public partial class Projektteilnehmer : Form {

        private SqlConnection connection;

        public Projektteilnehmer(SqlConnection conn) {
            InitializeComponent();
            connection = conn;
        }

        private void Projektteilnehmer_Load(object sender, EventArgs e) {
            selectProjekt.DataSource = getProjects();
            selectProjekt.DisplayMember = "Projektname";
            selectProjekt.ValueMember = "id";

            selectTeilnehmer.DataSource = getAllAngestellte();
            selectTeilnehmer.DisplayMember = "Angestellter";
            selectTeilnehmer.ValueMember = "id";
        }

        private void ProjectChanged(object sender, EventArgs e) {
            DataRowView drv = (DataRowView)selectProjekt.SelectedItem;
            listTeilnehmer.DataSource = getAngestellte((String)drv["Projektname"]);
        }

        private void btnEntfernen_Click(object sender, EventArgs e) {
            DataRowView drvT = (DataRowView)selectTeilnehmer.SelectedItem;
            DataRowView drvP = (DataRowView)selectProjekt.SelectedItem;

            connection.Open();
            SqlCommand cmd = new SqlCommand("uspDeleteTeilnehmer", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ang_id", SqlDbType.Int).Value = TeilnehmerID.Value;
            cmd.Parameters.AddWithValue("@proj_id", SqlDbType.Int).Value = drvP["id"];
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            listTeilnehmer.DataSource = getAngestellte((String)drvP["Projektname"]);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            DataRowView drvT = (DataRowView)selectTeilnehmer.SelectedItem;
            DataRowView drvP = (DataRowView)selectProjekt.SelectedItem;

            connection.Open();
            SqlCommand cmd = new SqlCommand("uspAddTeilnehmer", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = (String)drvT["Angestellter"];
            cmd.Parameters.AddWithValue("@projekt", SqlDbType.VarChar).Value = (String)drvP["Projektname"];
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            listTeilnehmer.DataSource = getAngestellte((String)drvP["Projektname"]);
        }

        // helper functions:
        private DataTable getProjects() {
            DataTable dt = new DataTable();
            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetProjekte", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        private DataTable getAngestellte(string projekt) {
            DataTable dt = new DataTable();
            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetAngestellteForProjektNicely", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Projekt", SqlDbType.VarChar).Value = projekt;
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        private DataTable getAllAngestellte() {
            DataTable dt = new DataTable();
            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetAngestellteFilteredNicely", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = "";
            cmd.Parameters.AddWithValue("@active", SqlDbType.Int).Value = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

    }
}
