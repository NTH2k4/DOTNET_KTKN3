namespace _40828
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
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lbDescribe = new Label();
            lbEmail = new Label();
            lbPhoneNumber = new Label();
            lbName = new Label();
            lbId = new Label();
            btnSearch = new Button();
            txtAddress = new TextBox();
            dgvSupplier = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
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
            // txtEmail
            // 
            txtEmail.Location = new Point(742, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(461, 29);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(742, 87);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(461, 29);
            txtPhoneNumber.TabIndex = 4;
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
            // lbDescribe
            // 
            lbDescribe.AutoSize = true;
            lbDescribe.Location = new Point(78, 194);
            lbDescribe.Name = "lbDescribe";
            lbDescribe.Size = new Size(60, 21);
            lbDescribe.TabIndex = 20;
            lbDescribe.Text = "Địa chỉ:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(685, 142);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 21);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email:";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(632, 90);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(104, 21);
            lbPhoneNumber.TabIndex = 18;
            lbPhoneNumber.Text = "Số điện thoại:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(10, 142);
            lbName.Name = "lbName";
            lbName.Size = new Size(132, 21);
            lbName.TabIndex = 17;
            lbName.Text = "Tên nhà cung cấp:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(11, 90);
            lbId.Name = "lbId";
            lbId.Size = new Size(131, 21);
            lbId.TabIndex = 16;
            lbId.Text = "Mã nhà cung cấp:";
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
            // dgvSupplier
            // 
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(66, 237);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplier.Size = new Size(1137, 369);
            dgvSupplier.TabIndex = 32;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvSupplier);
            Controls.Add(txtAddress);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lbDescribe);
            Controls.Add(lbEmail);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
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
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private TextBox txtId;
        private Label lbDescribe;
        private Label lbEmail;
        private Label lbPhoneNumber;
        private Label lbName;
        private Label lbId;
        private Button btnSearch;
        private TextBox txtAddress;
        private DataGridView dgvSupplier;
    }
}
