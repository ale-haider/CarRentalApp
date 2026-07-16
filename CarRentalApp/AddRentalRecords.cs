using CarRentalApp.Models;

namespace CarRentalApp
{
    public partial class AddRentalRecords : Form
    {
        // The modern .NET 10 equivalent 
        private readonly CarRentalContext carRentalContext = new CarRentalContext();

        public AddRentalRecords()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show($"thank you for renting {tbCustomerName.Text}");
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);

                var carType = cbTypeOfCar.Text;

                var isValid = true;
                var errorMsg = string.Empty;

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(carType))
                {
                    isValid = false;
                    errorMsg += "Error : please enter name and car type";
                }
                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMsg += "Error: please enter the date correctly ";
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCar = (int)cbTypeOfCar.SelectedValue;

                    //storing data in the database
                    carRentalContext.CarRentalRecords.Add(rentalRecord);
                    carRentalContext.SaveChanges();

                    MessageBox.Show($" Customer Name : {customerName}\n\r"
                        + $"Date Rented : {dateOut}\n\r"
                        + $" Date Reuturned : {dateIn}\n\r"
                        + $" Cost  : {cost}\n\r"
                        + $" Car Type: {carType}\n\r" +
                        $"Thank you for your buisness");
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //IT is just like doing select *
            //var cars = carRentalContext.TypesOfCars.ToList();

            var cars = carRentalContext.TypesOfCars
                .Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model })
                .ToList();

            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "Id";
            cbTypeOfCar.DataSource = cars;

        }

        private void CarDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
