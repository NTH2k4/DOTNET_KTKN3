namespace _40832
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
            txtQuantity = new TextBox();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lbAddress = new Label();
            lbQuantity = new Label();
            lbPhoneNumber = new Label();
            lbName = new Label();
            lbId = new Label();
            btnSearch = new Button();
            txtAddress = new TextBox();
            dgvDepartment = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
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
            // txtQuantity
            // 
            txtQuantity.Location = new Point(770, 139);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(433, 29);
            txtQuantity.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(770, 87);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(433, 29);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(428, 29);
            txtName.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(148, 86);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(428, 29);
            txtId.TabIndex = 21;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(82, 194);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(60, 21);
            lbAddress.TabIndex = 20;
            lbAddress.Text = "Địa chỉ:";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(616, 142);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(148, 21);
            lbQuantity.TabIndex = 19;
            lbQuantity.Text = "Số lượng nhân viên:";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(660, 89);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(104, 21);
            lbPhoneNumber.TabIndex = 18;
            lbPhoneNumber.Text = "Số điện thoại:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(27, 142);
            lbName.Name = "lbName";
            lbName.Size = new Size(115, 21);
            lbName.TabIndex = 17;
            lbName.Text = "Tên phòng ban:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(28, 90);
            lbId.Name = "lbId";
            lbId.Size = new Size(114, 21);
            lbId.TabIndex = 16;
            lbId.Text = "Mã phòng ban:";
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
            // txtAddress
            // 
            txtAddress.Location = new Point(148, 191);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(1055, 29);
            txtAddress.TabIndex = 6;
            // 
            // dgvDepartment
            // 
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(66, 237);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartment.Size = new Size(1137, 369);
            dgvDepartment.TabIndex = 32;
            dgvDepartment.CellClick += dgvDepartment_CellClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvDepartment);
            Controls.Add(txtAddress);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(txtQuantity);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lbAddress);
            Controls.Add(lbQuantity);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
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
        private TextBox txtQuantity;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private TextBox txtId;
        private Label lbAddress;
        private Label lbQuantity;
        private Label lbPhoneNumber;
        private Label lbName;
        private Label lbId;
        private Button btnSearch;
        private TextBox txtAddress;
        private DataGridView dgvDepartment;
    }
}
