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

namespace Projekt
{
    public partial class ProjektBearbeiten : Form
    {
        public ProjektBearbeiten()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con =
                new SqlConnection(
                    @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True");

            int count = 0;

            foreach (var control in this.Controls)
            {
                if (control is TextBox)
                {
                    var text = control as TextBox;
                    if (text.Text == string.Empty)
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                MessageBox.Show("Fill all the Boxes", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Projekt set End_Date = @endDate Where PK_Proj_nr = @Name", con);


                cmd.Parameters.AddWithValue("@endDate", Projfin.Text);
                cmd.Parameters.AddWithValue("@Name", Int32.Parse(Projekt.Text));
                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Project has been Updated", "Upadate", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                    throw;
                }
            }

        }

    }
}
