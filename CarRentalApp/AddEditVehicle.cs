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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private  CarRentalContext _db = new CarRentalContext();
        public AddEditVehicle()
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            isEditMode = false;
            _db = new CarRentalContext();
        }

        public AddEditVehicle(TypesOfCar carToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";

            PopulateFiedls(carToEdit);
            isEditMode = true;
            _db = new CarRentalContext();
        }

        private void PopulateFiedls(TypesOfCar car)
        {
            lblId.Text = car.Id.ToString();

            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVin.Text = car.Vin;
            tbYear.Text = car.Year.ToString();
            tbLicenseNum.Text = car.LicensePlateNumber;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if isEditmode == true
            if (isEditMode)
            {
                var id = int.Parse(lblId.Text);



                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                if (car != null) 
                {
                    car.Model = tbModel.Text;
                    car.Make = tbMake.Text;
                    car.Vin = tbVin.Text;
                    car.Year = int.Parse(tbYear.Text);
                    car.LicensePlateNumber = tbLicenseNum.Text;

                    _db.SaveChanges();
                }
                _db.SaveChanges();
            }
            else
            {
                var newCar = new TypesOfCar
                {
                    LicensePlateNumber = tbLicenseNum.Text,
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    Vin = tbVin.Text,
                    Year = int.Parse(tbYear.Text)
                };

                _db.TypesOfCars.Add(newCar);
                _db.SaveChanges();

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//close the window opposite to show
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
