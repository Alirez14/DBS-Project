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
    public partial class Nider : Form
    {
        public void getdata()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Niederlassungs;

        }
        private bool updatemode = false;
        public void cleartextbox()
        {
            NiderOrt.Clear();
            NiderEmail.Clear();
            NiderTel.Clear();
            NiderID.Clear();

        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Nider()
        {
            InitializeComponent();
        }

        private void Nider_Load(object sender, EventArgs e)
        {
            getdata();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADDBTN(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Niederlassung newab = new Niederlassung()
                    {
                        Ort = NiderOrt.Text,
                        Telefon=NiderTel.Text,
                        Email=NiderEmail.Text

                    };

                    db.Niederlassungs.InsertOnSubmit(newab);
                    db.SubmitChanges();
                    getdata();
                    cleartextbox();



                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);


            }
        }

        private void UPDATEBTN(object sender, EventArgs e)
        {
            SAVE.Enabled = true;
            updatemode = true;
            try
            {

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var newab = db.Niederlassungs.SingleOrDefault<Niederlassung>(x => x.PK_FirmaID == Convert.ToInt32(NiderID.Text));
                    NiderOrt.Text = newab.Ort;
                    NiderTel.Text = newab.Telefon;
                    NiderEmail.Text = newab.Email;


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);


            }

        }

        private void SAVEBTN(object sender, EventArgs e)
        {
            updatemode = false;
            SAVE.Enabled = false;
            try
            {
              
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var newab = db.Niederlassungs.SingleOrDefault<Niederlassung>(x => x.PK_FirmaID == Convert.ToInt32(NiderID.Text));


                    if (string.IsNullOrEmpty(NiderOrt.Text) && string.IsNullOrEmpty(NiderEmail.Text) && string.IsNullOrEmpty(NiderTel.Text))
                    {
                        db.Niederlassungs.DeleteOnSubmit(newab);
                    }
                    else
                    {
                        newab.Ort = NiderOrt.Text;
                        newab.Email = NiderEmail.Text;
                        newab.Telefon = NiderTel.Text;

                    }



                    db.SubmitChanges();
                    getdata();
                    cleartextbox();



                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);


            }

        }

        private void NiderOrt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NiderOrt.Text))
            {
                NiderAdd.Enabled = false;
            }
            else
            {
                if (updatemode == false)
                {
                    NiderAdd.Enabled = true;
                }
            }
        }

        private void NiderID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NiderID.Text))
            {
                UPDATE.Enabled = false;
            }
            else
            {
                UPDATE.Enabled = true;
            }

        }
    }
}
