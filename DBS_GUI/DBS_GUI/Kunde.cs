using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBS_GUI
{
    public partial class kundeForm : Form
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand command = new SqlCommand();
        public DataSet data = new DataSet();

        public kundeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            con.ConnectionString =
                @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True;";
            foreach (Control c in tabPage1.Controls)
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


                command.Connection = con;
                command.CommandText =
                    "INSERT INTO Kunde (Vorname, Nachname, Sex, Adresse, City, Telefon, Email) VALUES (@fname, @lname, @sex, @adr, @city, @tel, @mail)";

                command.Parameters.AddWithValue("@fname", firstname.Text);
                command.Parameters.AddWithValue("@lname", lastname.Text);
                if (male.Checked)
                {
                    command.Parameters.AddWithValue("@sex", "M");
                }
                else if (female.Checked)
                {
                    command.Parameters.AddWithValue("@sex", "F");
                }

                command.Parameters.AddWithValue("@adr", address.Text);
                command.Parameters.AddWithValue("@city", city.Text);
                if (phone.Text != String.Empty)
                {
                    command.Parameters.AddWithValue("tel", Int64.Parse(phone.Text));
                }

                command.Parameters.AddWithValue("@mail", email.Text);

                try
                {
                    con.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("New Customer is added Successfully!", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        foreach (Control c in tabPage1.Controls)
                        {
                            if (c is TextBox)
                            {
                                TextBox textBox = c as TextBox;
                                if (textBox.Text != String.Empty)
                                {
                                    textBox.Text = String.Empty;
                                }
                            }

                            if (c is RadioButton)
                            {
                                RadioButton radio = c as RadioButton;
                                if (radio.Checked == true)
                                {
                                    radio.Checked = false;
                                }
                            }
                        }
                    }

                    command.Parameters.Clear();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int count = 0; 

            con.ConnectionString =
                @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True;";


            foreach (Control c in tabPage2.Controls)
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

            if (count == 3)
            {
                MessageBox.Show("Fill all the Boxes", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (kundeID.Text != String.Empty)
            {
                
                command.Connection = con;
                command.CommandText = "Select * From Kunde Where PK_KundID = @id";
                command.Parameters.AddWithValue("@id", Int32.Parse(kundeID.Text));
                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(data, "Search");
                if (data.Tables["Search"].Rows.Count == 0)
                {
                    MessageBox.Show("Can not find the user", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Parameters.Clear();
                    kundeID.ResetText();
                }
                else
                {
                    dataGridView1.DataSource = data.Tables["Search"];
                    kundeID.Text = String.Empty;
                    command.Parameters.Clear();

                }
            }

            else if (Namefisrt.Text != String.Empty && Nname.Text != String.Empty)
            {
              
               
                command.Connection = con;
                command.CommandText = "Select * From Kunde Where Vorname = @name  AND Nachname = @lastname";
                command.Parameters.AddWithValue("@name", Namefisrt.Text);
                command.Parameters.AddWithValue("@lastname", Nname.Text);
                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(data, "Search");
                if (data.Tables["Search"].Rows.Count == 0)
                {
                    MessageBox.Show("Can not find the user", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Parameters.Clear();

                }
                else
                {
                    dataGridView1.DataSource = data.Tables["Search"];
                    command.Parameters.Clear();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var update = new AddressUpdate();
            update.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var delete = new DeleteCus();
            delete.Show();
        }

        private void town_Click(object sender, EventArgs e)
        {
            var cityupdate = new CityUpdate();
            cityupdate.ShowDialog();
        }

        private void mail_Click(object sender, EventArgs e)
        {
            var email = new EmailUpdate();
            email.ShowDialog();
        }

        private void shomare_Click(object sender, EventArgs e)
        {
            var phone = new PhoneUpdate();
            phone.ShowDialog();
        }
    }
}
