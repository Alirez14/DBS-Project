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

            selectTeilnehmer.DataSource = getAngestellte("");
            selectTeilnehmer.DisplayMember = "Angestellter";
            selectTeilnehmer.ValueMember = "id";

            selectTeilnehmer.SetSelected(0, false);
            //selectTeilnehmer.SetSelected(10, true);
            //selectTeilnehmer.SetSelected(3, true);
        }

        private DataTable getProjects () {
            DataTable dt = new DataTable();

            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetProjekte", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        private DataTable getAngestellte(string filter) {
            DataTable dt = new DataTable();

            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetAngestellteFilteredNicely", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = filter;
            cmd.Parameters.AddWithValue("@active", SqlDbType.Int).Value = 0;

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            MessageBox.Show("Nothing changed!");
            this.Close();
        }

        private void ProjectChanged(object sender, EventArgs e) {
            
        }

        private void Teilnehmerfilter_changed(object sender, EventArgs e) {
            selectTeilnehmer.DataSource = getAngestellte(txtTeilnehmerfilter.Text);
        }
    }
}
