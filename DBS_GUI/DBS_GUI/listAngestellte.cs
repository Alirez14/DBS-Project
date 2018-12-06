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
            dataviewAngestellte.DataSource = getAngestellte();
            dataviewAngestellte.Columns[0].Visible = false;     // don't show id column!
        }

        private DataTable getAngestellte () {
            DataTable dt = new DataTable();

            connection.Open();
            SqlCommand cmd = new SqlCommand("uspGetAngestellteFilteredNicely", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = "";
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            connection.Close();

            return dt;
        }
    }
}
