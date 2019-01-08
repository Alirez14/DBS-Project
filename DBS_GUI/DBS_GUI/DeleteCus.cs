using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_GUI
{
    public partial class DeleteCus : Form
    {
        public DeleteCus()
        {
            InitializeComponent();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result = 
                MessageBox.Show("Delete the Customer?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            SqlConnection con = new SqlConnection
                (@"Data Source = DESKTOP-6JC714Q\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True;");

            SqlCommand command = new SqlCommand();
            SqlCommand query = new SqlCommand();

            query.Connection = con;
            query.CommandText = "Delete From Bestellung where FK_Kunde = @kid";
            query.Parameters.AddWithValue("@kid", pid.Text);

            con.Open();
            int res = query.ExecuteNonQuery();
            con.Close();

            command.Connection = con;
            command.CommandText = "Delete From Kunde Where PK_KundID = @id";
            command.Parameters.AddWithValue("@id", pid.Text);

            if (result == DialogResult.Yes)
            {
                con.Open();
                int exe = command.ExecuteNonQuery();
                if (exe > 0)
                {
                    MessageBox.Show("The Customer has been deleted", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    con.Close();
                    this.Close();
                }
                
            }
        }
    }
}
