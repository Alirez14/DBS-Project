using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_GUI
{
    public partial class ProjShow : Form
    {
        public SqlConnection connection = new SqlConnection();
        public ProjShow()
        {
            InitializeComponent();
            DataSet data = new DataSet();
            string command = "Select * From Projekt";
            connection.ConnectionString =
                @"Data Source = DESKTOP-6JC714Q\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True";
            try
            {
                connection.Open();
                SqlDataAdapter adap = new SqlDataAdapter(command, connection);
                adap.Fill(data, "Projekt");
                showproj.DataSource = data.Tables["Projekt"];
            }
            catch (SqlException sql)
            {
                MessageBox.Show("ERROR", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
