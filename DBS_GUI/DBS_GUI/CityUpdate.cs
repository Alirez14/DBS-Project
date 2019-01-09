using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollectionChangeAction = System.ComponentModel.CollectionChangeAction;

namespace DBS_GUI
{
    public partial class CityUpdate : Form
    {
        public CityUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    var textbox = c as TextBox;
                    if (textbox.Text == String.Empty)
                    {
                        count++;
                        
                    }

                }
            }

            if (count > 0)
            {
                MessageBox.Show("Please Fill all the fields", "ERR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {


                SqlConnection con = new SqlConnection
                    (@"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True;");

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Update Kunde Set City = @city Where PK_KundID = @id";
                command.Parameters.AddWithValue("@city", CityName.Text);
                command.Parameters.AddWithValue("@id", CustomerID.Text);

                try
                {
                    con.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Updaet Completed", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        con.Close();
                        this.Close();
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show("Error", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(exception.ToString());
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
