﻿using System;
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
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Abteillung()
        {
            InitializeComponent();
        }

        private void Abteillung_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Abteilungs;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
