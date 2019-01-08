using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_GUI
{
public partial class Abteillung : Form
{
    public void getdata()
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        dataGridView1.DataSource = db.Abteilungs;

    }
        private bool updatemode = false;
        public void cleartextbox()
        {
            nameab.Clear();
            Anzahl_Angestellte.Clear();
            IDFinder.Clear();
            Telefonab.Clear();
            Emailab.Clear();


        }
 
  
    public Abteillung()
    {
        InitializeComponent();

    }

    private void Abteillung_Load(object sender, EventArgs e)
    {
            
            getdata();
            

        }

    private void ADDbtn_MouseClick(object sender, MouseEventArgs e)
    {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Abteilung newab = new Abteilung()
                    {
                        Name = nameab.Text,
                        Anzahl_Angestellte = Convert.ToInt32(Anzahl_Angestellte.Text),
                        Email = Emailab.Text,
                        Telefon = Telefonab.Text

                    };

                    db.Abteilungs.InsertOnSubmit(newab);
                    db.SubmitChanges();
                    getdata();
                    cleartextbox();



                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message); 
                
                
            }
    }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Savebtn.Enabled = true;
            updatemode = true;
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var newab = db.Abteilungs.SingleOrDefault<Abteilung>(x => x.PK_Abt_nr == Convert.ToInt32(IDFinder.Text));
                    nameab.Text = newab.Name;
                    Anzahl_Angestellte.Text = Convert.ToString(newab.Anzahl_Angestellte);
                    Emailab.Text = newab.Email;
                    Telefonab.Text = newab.Telefon;


                   


                    

                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);


            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Savebtn.Enabled = false;
            updatemode = false;
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var newab = db.Abteilungs.SingleOrDefault<Abteilung>(x => x.PK_Abt_nr == Convert.ToInt32(IDFinder.Text));


                    if (string.IsNullOrEmpty(nameab.Text) && string.IsNullOrEmpty(Anzahl_Angestellte.Text) && string.IsNullOrEmpty(Emailab.Text) && string.IsNullOrEmpty(Telefonab.Text))
                    {
                        db.Abteilungs.DeleteOnSubmit(newab);
                    }
                    else
                    {
                        newab.Name = nameab.Text;
                        newab.Anzahl_Angestellte = Convert.ToInt32(Anzahl_Angestellte.Text);
                        newab.Email = Emailab.Text;
                        newab.Telefon = Telefonab.Text;

                    }


                   
                    db.SubmitChanges();
                    


                }
                getdata();
                cleartextbox();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message); 
                
                
            }

        }

        private void nameab_TextChanged(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(nameab.Text))
            {
                ADDbtn.Enabled = false;
            }
            else
            {
                if (updatemode == false)
                {
                    ADDbtn.Enabled = true;
                }
            }
        }

        private void IDFinder_TextChanged(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(IDFinder.Text))
            {
                updatebtn.Enabled = false;
            }
            else
            {
                updatebtn.Enabled = true;
            }
        }
    }
}
