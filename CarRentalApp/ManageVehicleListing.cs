using CarRentalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRentalApp
{

    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalContext _db = new CarRentalContext();
        public ManageVehicleListing()
        {
            InitializeComponent();

        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {

            //var cars = _db.TypesOfCars.ToList();

            //this sirution is 
            //SELECT  Id as CarId, name as CarName From TypesOfCars
            //var cars = _db.TypesOfCars
            //    .Select(q => new { ID = q.Id, Name = q.Make}  )
            //    .ToList();

            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.Vin,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Id

                }).ToList();

            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1 ].HeaderText = "NAME"; 

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);


            //launch addEditVehicle
            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);


            //delete
            _db.TypesOfCars.Remove(car);
            _db.SaveChanges(); 
            
            gvVehicleList.Refresh();
        }
    }
}
