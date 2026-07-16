using CarRentalApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalContext _db = new CarRentalContext();
        public ManageRentalRecords()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddRentalRecords
            {
                MdiParent = this.MdiParent
            };
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {

        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid(GetGvRcordList1());
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private DataGridView GetGvRcordList1()
        {
            return gvRcordList;
        }

        private void PopulateGrid(DataGridView gvRcordList1)
        {
            var records = _db.CarRentalRecords
                .Include(q => q.TypeOfCar)
                .Select(static q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.Id,
                q.Cost,

                    Car = q.TypeOfCarNavigation != null
                ? q.TypeOfCarNavigation.Make + " " + q.TypeOfCarNavigation.Model
                : "No Car Assigned"
                }).ToList();

            gvRcordList.DataSource = records;
            gvRcordList1.Columns["DateIn"].HeaderText = "Date In";
            gvRcordList.Columns["DateOut"].HeaderText = "Date Out";
            gvRcordList.Columns[5].Visible = false;
            //gvRcordList.Columns[0].HeaderText = "ID";
            //gvRcordList.Columns[1 ].HeaderText = "NAME"; 
            gvRcordList.Columns["Id"].Visible = false;

        }
    }
}
