namespace CarRentalApp
{
    partial class ManageVehicleListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvVehicleList = new DataGridView();
            label1 = new Label();
            btnAddCar = new Button();
            btnEditCar = new Button();
            btnDeleteCar = new Button();
            ((System.ComponentModel.ISupportInitialize)gvVehicleList).BeginInit();
            SuspendLayout();
            // 
            // gvVehicleList
            // 
            gvVehicleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvVehicleList.Location = new Point(12, 89);
            gvVehicleList.Name = "gvVehicleList";
            gvVehicleList.Size = new Size(561, 207);
            gvVehicleList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(131, 40);
            label1.Name = "label1";
            label1.Size = new Size(323, 37);
            label1.TabIndex = 1;
            label1.Text = "Manage Vehicle Listing";
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(36, 339);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(106, 60);
            btnAddCar.TabIndex = 2;
            btnAddCar.Text = "Add New Car\r\n";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.Location = new Point(244, 339);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(106, 60);
            btnEditCar.TabIndex = 3;
            btnEditCar.Text = "Edit Car";
            btnEditCar.UseVisualStyleBackColor = true;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(437, 339);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(106, 60);
            btnDeleteCar.TabIndex = 4;
            btnDeleteCar.Text = "Delete Car";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // ManageVehicleListing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteCar);
            Controls.Add(btnEditCar);
            Controls.Add(btnAddCar);
            Controls.Add(label1);
            Controls.Add(gvVehicleList);
            Name = "ManageVehicleListing";
            Text = "Manage Vehicle Listing";
            Load += ManageVehicleListing_Load;
            ((System.ComponentModel.ISupportInitialize)gvVehicleList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvVehicleList;
        private Label label1;
        private Button btnAddCar;
        private Button btnEditCar;
        private Button btnDeleteCar;
    }
}