using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DBS_GUI {

    public partial class listAngestellte : Form {

        private SqlConnection connection;

        public listAngestellte(SqlConnection conn) {
            InitializeComponent();

            connection = conn; 
        }

        private void listAngestellte_Load(object sender, EventArgs e) {
            dataviewAngestellte.DataSource = getAngestellte(0);    // default are only active Angestellte shown!
            // dataviewAngestellte.Columns[0].Visible = false;     // don't show id column!
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            if (showDeactivated.Checked) {
                dataviewAngestellte.DataSource = getAngestellte(1);
            }
            else {
                dataviewAngestellte.DataSource = getAngestellte(0);
            }
            foreach (DataGridViewColumn column in dataviewAngestellte.Columns) {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private DataTable getAngestellte(int active) {
            DataTable dt = new DataTable();

            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetAngestellteFilteredNicely", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = "";
            cmd.Parameters.AddWithValue("@active", SqlDbType.Int).Value = active;
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            connection.Close();

            return dt;
        }
    }
}
