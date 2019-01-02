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
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Nider()
        {
            InitializeComponent();
        }

        private void Nider_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Niederlassungs;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
