using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBS_GUI {
    public partial class projektForm : Form {

        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlCommand command = new SqlCommand();
        public DataSet data = new DataSet();

        public projektForm() {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataSet data = new DataSet();

            con.ConnectionString = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True";

            int count = 0;
            foreach (Control c in panel1.Controls) {
                if (c is TextBox) {
                    var text = c as TextBox;
                    if (text.Text == String.Empty && text.Name == "SearchProject") {
                        count++;
                    }
                }
            }

            if (count > 0) {
                MessageBox.Show("Please Fill all the fields", "ERR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else {
                DataSet project = new DataSet();
                SqlCommand command = new SqlCommand();

                try {
                    cmd.CommandText = "Select Preis, BessID as Bestellung_ID From Bestellung Where BessID = @BessId";
                    command.CommandText =
                        "Select Name From Projekt p join Bestellung b on p.Pk_Proj_nr = b.FK_Proj Where BessId = @Bess";
                    cmd.Connection = con;
                    command.Connection = con;
                    cmd.Parameters.AddWithValue("@BessID", Int32.Parse(SearchProject.Text));
                    command.Parameters.AddWithValue("@Bess", Int32.Parse(SearchProject.Text));
                }
                catch (Exception exception) {
                    MessageBox.Show("Insert Existenace Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();

                }

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                SqlDataAdapter second = new SqlDataAdapter(command);
                adp.Fill(data, "Bestellung");
                second.Fill(project, "Project");
                if (data.Tables["Bestellung"].Rows.Count == 0 || project.Tables["Project"].Rows.Count == 0) {
                    var result = MessageBox.Show("The Order is not in the Databank, Try Again", "ERROE",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);
                    if (result == DialogResult.Retry) {
                        Application.Restart();
                    }
                    else if (result == DialogResult.Cancel) {
                        Application.Exit();
                    }
                }
                dataGridView1.DataSource = project.Tables["Project"];
                dataGridView2.DataSource = data.Tables["Bestellung"];
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            int count = 0;
            foreach (Control c in panel1.Controls) {
                if (c is TextBox)
                {
                    var text = c as TextBox;
                    if (text.Text == String.Empty && text.Name != "SearchProject")
                    {
                        count++;

                    }
                    continue;
                }
            }
            if (count > 0) {
                MessageBox.Show("Please Fill all the fields", "ERR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else {
                int number;
                DataSet projAdd = new DataSet();

                con.ConnectionString =
                    @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True";

                SqlCommand command = new SqlCommand();
                SqlCommand select = new SqlCommand();
                select.Connection = con;
                command.Connection = con;
                cmd.Connection = con;

                cmd.CommandText = "Select * From Projekt";

                SqlDataAdapter projInsert = new SqlDataAdapter(cmd);
                projInsert.Fill(projAdd, "ProjAdd");

                DataRow row = projAdd.Tables["ProjAdd"].NewRow();

                row["Name"] = ProjectaName.Text;
                row["Start_Date"] = txtDateStart.Text;
                row["FK_Nder_nr"] = textBox1.Text;

                projAdd.Tables["ProjAdd"].Rows.Add(row);
                SqlCommandBuilder build = new SqlCommandBuilder(projInsert);
                int projResult = projInsert.Update(projAdd, "ProjAdd");

                select.CommandText = "select PK_Proj_nr from Projekt where Name = @Name";
                select.Parameters.AddWithValue("@Name", ProjectaName.Text);
                try {
                    con.Open();
                    SqlDataReader reader;
                    reader = select.ExecuteReader();
                    while (reader.Read()) {
                        number = reader.GetInt32(0);
                        command.CommandText = "Select * from Bestellung";

                        reader.Close();
                        SqlDataAdapter adp = new SqlDataAdapter(command);
                        adp.Fill(data, "Add");

                        DataRow add = data.Tables["Add"].NewRow();
                        add["FK_Proj"] = number;
                        add["FK_Kunde"] = Int32.Parse(textBox1.Text);
                        add["Datum"] = txtDateStart.Text;
                        add["Preis"] = Int32.Parse(textBox2.Text);

                        data.Tables["Add"].Rows.Add(add);

                        SqlCommandBuilder builder = new SqlCommandBuilder(adp);

                        int result = adp.Update(data, "Add");
                        if (result > 0 && projResult > 0) {
                            MessageBox.Show("Success", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            Application.Restart();
                        }
                        else {
                            MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.ToString());
                    throw;
                }
                finally {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            con.ConnectionString = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Unternehm; Integrated Security = True";

            int count = 0;
            foreach (Control c in panel1.Controls) {
                if (c is TextBox) {
                    var text = c as TextBox;
                    if (text.Text == String.Empty && text.Name == "SearchProject") {
                        count++;
                    }
                }
            }
            if (count > 0) {
                MessageBox.Show("Please Fill all the fields", "ERR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else {
                SqlCommand cmd = new SqlCommand();
                SqlCommand command = new SqlCommand();
                SqlCommand row =
                    new SqlCommand(
                        "select PK_Proj_nr from Projekt Where PK_Proj_nr in (Select FK_Proj from Bestellung where BessID = @pid)",
                        con);
                row.Parameters.AddWithValue("@pid", Int32.Parse(SearchProject.Text));

                con.Open();
                int pid = Int32.Parse(SearchProject.Text);
                con.Close();
                command.Connection = con;
                cmd.Connection = con;

                try {
                    cmd.CommandText = "DELETE FROM Bestellung WHERE BessID = @var";
                    cmd.Parameters.AddWithValue("@var", Int32.Parse(SearchProject.Text));

                    command.CommandText = "Delete From Projekt where PK_Proj_nr = @id";
                    command.Parameters.AddWithValue("@id", pid);

                }
                catch (Exception exception) {
                    MessageBox.Show("Please select Bestellung ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                }

                try {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    int delete = command.ExecuteNonQuery();

                    if (result > 0 && delete > 0) {
                        MessageBox.Show("Order Number: " + SearchProject.Text + " has been Deleted", "DELETE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
                catch (SqlException exception) {
                    MessageBox.Show(exception.ToString());
                    //throw;
                }
                finally {
                    con.Close();
                }
            }
        }


    }
}
