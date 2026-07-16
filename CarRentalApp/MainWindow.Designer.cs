namespace CarRentalApp
{
    partial class MainWindow
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            manageVehicleLToolStripMenuItem = new ToolStripMenuItem();
            mangaeRentalRecordsToolStripMenuItem = new ToolStripMenuItem();
            addRentalRecordsToolStripMenuItem = new ToolStripMenuItem();
            viewArchiceToolStripMenuItem = new ToolStripMenuItem();
            editRentalRecordToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageVehicleLToolStripMenuItem, mangaeRentalRecordsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageVehicleLToolStripMenuItem
            // 
            manageVehicleLToolStripMenuItem.Name = "manageVehicleLToolStripMenuItem";
            manageVehicleLToolStripMenuItem.Size = new Size(140, 20);
            manageVehicleLToolStripMenuItem.Text = "Manage Vehicle Listing";
            manageVehicleLToolStripMenuItem.Click += manageVehicleLToolStripMenuItem_Click;
            // 
            // mangaeRentalRecordsToolStripMenuItem
            // 
            mangaeRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRentalRecordsToolStripMenuItem, viewArchiceToolStripMenuItem, editRentalRecordToolStripMenuItem });
            mangaeRentalRecordsToolStripMenuItem.Name = "mangaeRentalRecordsToolStripMenuItem";
            mangaeRentalRecordsToolStripMenuItem.Size = new Size(143, 20);
            mangaeRentalRecordsToolStripMenuItem.Text = "Mangae Rental Records";
            // 
            // addRentalRecordsToolStripMenuItem
            // 
            addRentalRecordsToolStripMenuItem.Name = "addRentalRecordsToolStripMenuItem";
            addRentalRecordsToolStripMenuItem.Size = new Size(177, 22);
            addRentalRecordsToolStripMenuItem.Text = "Add Rental Records";
            addRentalRecordsToolStripMenuItem.Click += addRentalRecordsToolStripMenuItem_Click;
            // 
            // viewArchiceToolStripMenuItem
            // 
            viewArchiceToolStripMenuItem.Name = "viewArchiceToolStripMenuItem";
            viewArchiceToolStripMenuItem.Size = new Size(177, 22);
            viewArchiceToolStripMenuItem.Text = "View Archice";
            // 
            // editRentalRecordToolStripMenuItem
            // 
            editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            editRentalRecordToolStripMenuItem.Size = new Size(177, 22);
            editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Car Rental Mangement System";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageVehicleLToolStripMenuItem;
        private ToolStripMenuItem mangaeRentalRecordsToolStripMenuItem;
        private ToolStripMenuItem addRentalRecordsToolStripMenuItem;
        private ToolStripMenuItem viewArchiceToolStripMenuItem;
        private ToolStripMenuItem editRentalRecordToolStripMenuItem;
    }
}