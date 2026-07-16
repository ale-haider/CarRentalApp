namespace CarRentalApp
{
    partial class AddRentalRecords
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbCustomerName = new TextBox();
            label2 = new Label();
            dtRented = new DateTimePicker();
            dtReturned = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cbTypeOfCar = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            tbCost = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Rental Record";
            label1.Click += label1_Click;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(12, 127);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(200, 23);
            tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer Name";
            label2.Click += label2_Click;
            // 
            // dtRented
            // 
            dtRented.Location = new Point(12, 243);
            dtRented.Name = "dtRented";
            dtRented.Size = new Size(200, 23);
            dtRented.TabIndex = 3;
            // 
            // dtReturned
            // 
            dtReturned.Location = new Point(308, 243);
            dtReturned.Name = "dtReturned";
            dtReturned.Size = new Size(200, 23);
            dtReturned.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F);
            label3.Location = new Point(12, 219);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 5;
            label3.Text = "Date Rented";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F);
            label4.Location = new Point(308, 219);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 6;
            label4.Text = "Date Returned";
            // 
            // cbTypeOfCar
            // 
            cbTypeOfCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeOfCar.FormattingEnabled = true;
            cbTypeOfCar.Location = new Point(12, 324);
            cbTypeOfCar.Name = "cbTypeOfCar";
            cbTypeOfCar.Size = new Size(200, 23);
            cbTypeOfCar.TabIndex = 7;
            cbTypeOfCar.SelectedIndexChanged += CarDropBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F);
            label5.Location = new Point(12, 300);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 8;
            label5.Text = "Type Of Car";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(358, 314);
            button1.Name = "button1";
            button1.Size = new Size(117, 68);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F);
            label6.Location = new Point(332, 96);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 10;
            label6.Text = "Cost";
            label6.Click += label6_Click;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(332, 132);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(100, 23);
            tbCost.TabIndex = 11;
            tbCost.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddRentalRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbCost);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(cbTypeOfCar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtReturned);
            Controls.Add(dtRented);
            Controls.Add(label2);
            Controls.Add(tbCustomerName);
            Controls.Add(label1);
            Name = "AddRentalRecords";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCustomerName;
        private Label label2;
        private DateTimePicker dtRented;
        private DateTimePicker dtReturned;
        private Label label3;
        private Label label4;
        private ComboBox cbTypeOfCar;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox tbCost;
        private ContextMenuStrip contextMenuStrip1;
    }
}
