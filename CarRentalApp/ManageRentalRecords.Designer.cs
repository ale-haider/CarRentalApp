namespace CarRentalApp
{
    partial class ManageRentalRecords
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
            btnDeleteRecord = new Button();
            btnEditRecord = new Button();
            btnAddRecord = new Button();
            gvRcordList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvRcordList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(129, 32);
            label1.Name = "label1";
            label1.Size = new Size(315, 37);
            label1.TabIndex = 2;
            label1.Text = "Mangae Rental Record";
            label1.Click += label1_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(449, 334);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(106, 60);
            btnDeleteRecord.TabIndex = 8;
            btnDeleteRecord.Text = "Delete Record";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnEditRecord
            // 
            btnEditRecord.Location = new Point(256, 334);
            btnEditRecord.Name = "btnEditRecord";
            btnEditRecord.Size = new Size(106, 60);
            btnEditRecord.TabIndex = 7;
            btnEditRecord.Text = "Edit Record";
            btnEditRecord.UseVisualStyleBackColor = true;
            btnEditRecord.Click += btnEditRecord_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(48, 334);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(106, 60);
            btnAddRecord.TabIndex = 6;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // gvRcordList
            // 
            gvRcordList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvRcordList.Location = new Point(24, 84);
            gvRcordList.Name = "gvRcordList";
            gvRcordList.Size = new Size(561, 207);
            gvRcordList.TabIndex = 5;
            // 
            // ManageRentalRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnEditRecord);
            Controls.Add(btnAddRecord);
            Controls.Add(gvRcordList);
            Controls.Add(label1);
            Name = "ManageRentalRecords";
            Text = "Form1";
            Load += ManageRentalRecords_Load;
            ((System.ComponentModel.ISupportInitialize)gvRcordList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDeleteRecord;
        private Button btnEditRecord;
        private Button btnAddRecord;
        private DataGridView gvRcordList;
    }
}