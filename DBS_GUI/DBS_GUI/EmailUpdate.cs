using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBS_GUI
{
    public partial class EmailUpdate : Form
    {
        public EmailUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
                (@"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True;");
            int count = 0;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
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
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Update Kunde Set Email = @mail where PK_KundID = @cusID";
                command.Parameters.AddWithValue("@mail", EmailID.Text);
                command.Parameters.AddWithValue("@cusID", customerID.Text);

                try
                {
                    con.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Update completed", "Upadate", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        con.Close();
                        this.Close();
                    }


                }
                catch (SqlException exception)
                {
                    MessageBox.Show("Error by Updating", "ERR", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    throw;
                }
                finally
                {
                    con.Close();
                    this.Close();
                }
            }
        }
    }
}
