namespace _40829
{
    partial class FormMain
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
            txtSearch = new TextBox();
            lbSearch = new Label();
            btnLoadData = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddNew = new Button();
            txtName = new TextBox();
            txtId = new TextBox();
            lbStatus = new Label();
            lbPrice = new Label();
            lbTime = new Label();
            lbName = new Label();
            lbId = new Label();
            btnSearch = new Button();
            txtStatus = new TextBox();
            dgvOrder = new DataGridView();
            dtpTime = new DateTimePicker();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(148, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(974, 29);
            txtSearch.TabIndex = 31;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(42, 38);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(100, 21);
            lbSearch.TabIndex = 30;
            lbSearch.Text = "Tim theo tên:";
            // 
            // btnLoadData
            // 
            btnLoadData.Cursor = Cursors.Hand;
            btnLoadData.Font = new Font("Segoe UI", 14.25F);
            btnLoadData.Location = new Point(1074, 612);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(129, 53);
            btnLoadData.TabIndex = 10;
            btnLoadData.Text = "Tải lại";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 14.25F);
            btnDelete.Location = new Point(738, 612);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 53);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 14.25F);
            btnUpdate.Location = new Point(402, 612);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 53);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.Font = new Font("Segoe UI", 14.25F);
            btnAddNew.Location = new Point(66, 612);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(129, 53);
            btnAddNew.TabIndex = 7;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(456, 29);
            txtName.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(148, 86);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(456, 29);
            txtId.TabIndex = 21;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(60, 194);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(82, 21);
            lbStatus.TabIndex = 20;
            lbStatus.Text = "Trạng thái:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(644, 142);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(92, 21);
            lbPrice.TabIndex = 19;
            lbPrice.Text = "Tổng giá trị:";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Location = new Point(700, 90);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(36, 21);
            lbTime.TabIndex = 18;
            lbTime.Text = "Giá:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(22, 142);
            lbName.Name = "lbName";
            lbName.Size = new Size(120, 21);
            lbName.TabIndex = 17;
            lbName.Text = "Tên khách hàng:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(23, 90);
            lbId.Name = "lbId";
            lbId.Size = new Size(119, 21);
            lbId.TabIndex = 16;
            lbId.Text = "Mã khách hàng:";
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 9.75F);
            btnSearch.Location = new Point(1128, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(148, 191);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(1055, 29);
            txtStatus.TabIndex = 6;
            // 
            // dgvOrder
            // 
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(66, 237);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(1137, 369);
            dgvOrder.TabIndex = 32;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(742, 86);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(198, 29);
            dtpTime.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(742, 142);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(461, 29);
            txtPrice.TabIndex = 33;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(txtPrice);
            Controls.Add(dtpTime);
            Controls.Add(dgvOrder);
            Controls.Add(txtStatus);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lbStatus);
            Controls.Add(lbPrice);
            Controls.Add(lbTime);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lbSearch;
        private Button btnLoadData;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNew;
        private TextBox txtName;
        private TextBox txtId;
        private Label lbStatus;
        private Label lbPrice;
        private Label lbTime;
        private Label lbName;
        private Label lbId;
        private Button btnSearch;
        private TextBox txtStatus;
        private DataGridView dgvOrder;
        private DateTimePicker dtpTime;
        private TextBox txtPrice;
    }
}
