namespace TP03_Employee
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
            txtPosition = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lbAddress = new Label();
            lbPosition = new Label();
            lbAge = new Label();
            lbName = new Label();
            lbId = new Label();
            btnSearch = new Button();
            txtAddress = new TextBox();
            dgvEmployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
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
            // txtPosition
            // 
            txtPosition.Location = new Point(742, 139);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(461, 29);
            txtPosition.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(742, 87);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(461, 29);
            txtAge.TabIndex = 4;
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
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(82, 194);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(60, 21);
            lbAddress.TabIndex = 20;
            lbAddress.Text = "Địa chỉ:";
            // 
            // lbPosition
            // 
            lbPosition.AutoSize = true;
            lbPosition.Location = new Point(667, 142);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(69, 21);
            lbPosition.TabIndex = 19;
            lbPosition.Text = "Chức vụ:";
            // 
            // lbAge
            // 
            lbAge.AutoSize = true;
            lbAge.Location = new Point(693, 90);
            lbAge.Name = "lbAge";
            lbAge.Size = new Size(43, 21);
            lbAge.TabIndex = 18;
            lbAge.Text = "Tuổi:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(34, 142);
            lbName.Name = "lbName";
            lbName.Size = new Size(108, 21);
            lbName.TabIndex = 17;
            lbName.Text = "Tên nhân viên:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(35, 89);
            lbId.Name = "lbId";
            lbId.Size = new Size(107, 21);
            lbId.TabIndex = 16;
            lbId.Text = "Mã nhân viên:";
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
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(66, 237);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(1137, 369);
            dgvEmployee.TabIndex = 32;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvEmployee);
            Controls.Add(txtAddress);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(txtPosition);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lbAddress);
            Controls.Add(lbPosition);
            Controls.Add(lbAge);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
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
        private TextBox txtPosition;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txtId;
        private Label lbAddress;
        private Label lbPosition;
        private Label lbAge;
        private Label lbName;
        private Label lbId;
        private Button btnSearch;
        private TextBox txtAddress;
        private DataGridView dgvEmployee;
    }
}
