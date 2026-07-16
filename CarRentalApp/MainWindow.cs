using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddRentalRecords();
            addRentalRecord.MdiParent = this;
            addRentalRecord.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void manageVehicleLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleListing = new ManageVehicleListing();
            vehicleListing.MdiParent = this;
            vehicleListing.Show();
        }

        private void viewArchiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
        }
    }
}
