using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBS_GUI
{
    public partial class AddressUpdate : Form
    {
        public AddressUpdate()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
                (@"Data Source = DESKTOP-6JC714Q\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True;");
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
                command.CommandText = "Update Kunde Set Adresse = @adr where PK_KundID = @id";
                command.Parameters.AddWithValue("@adr", adrUpdate.Text);
                command.Parameters.AddWithValue("@id", cusid.Text);

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
