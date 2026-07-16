namespace CarRentalApp
{
    partial class AddEditVehicle
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tbLicenseNum = new TextBox();
            tbYear = new TextBox();
            tbVin = new TextBox();
            tbModel = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            tbMake = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblId = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tbLicenseNum, 1, 4);
            tableLayoutPanel1.Controls.Add(tbYear, 1, 3);
            tableLayoutPanel1.Controls.Add(tbVin, 1, 2);
            tableLayoutPanel1.Controls.Add(tbModel, 1, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbMake, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(516, 318);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tbLicenseNum
            // 
            tbLicenseNum.Location = new Point(261, 255);
            tbLicenseNum.Name = "tbLicenseNum";
            tbLicenseNum.Size = new Size(207, 23);
            tbLicenseNum.TabIndex = 13;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(261, 192);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(207, 23);
            tbYear.TabIndex = 12;
            // 
            // tbVin
            // 
            tbVin.Location = new Point(261, 129);
            tbVin.Name = "tbVin";
            tbVin.Size = new Size(207, 23);
            tbVin.TabIndex = 11;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(261, 66);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(207, 23);
            tbModel.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 252);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 8;
            label9.Text = "License Plate Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 189);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 6;
            label7.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 126);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "VIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 63);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Make";
            // 
            // tbMake
            // 
            tbMake.Location = new Point(261, 3);
            tbMake.Name = "tbMake";
            tbMake.Size = new Size(207, 23);
            tbMake.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(54, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 55);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(297, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 55);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 20F);
            lblTitle.Location = new Point(106, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 37);
            lblTitle.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(545, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 4;
            lblId.Visible = false;
            // 
            // AddEditVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel1);
            Name = "AddEditVehicle";
            Text = "AddEditVehicle";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label lblTitle;
        private TextBox tbLicenseNum;
        private TextBox tbYear;
        private TextBox tbVin;
        private TextBox tbModel;
        private TextBox tbMake;
        private Label lblId;
    }
}