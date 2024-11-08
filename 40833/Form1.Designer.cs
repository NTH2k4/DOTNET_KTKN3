namespace _40833
{
    partial class Form1
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
            dgvDistributor = new DataGridView();
            lbId = new Label();
            txtId = new TextBox();
            lbName = new Label();
            txtName = new TextBox();
            lbAddress = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtAddress = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDistributor).BeginInit();
            SuspendLayout();
            // 
            // dgvDistributor
            // 
            dgvDistributor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDistributor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistributor.Dock = DockStyle.Bottom;
            dgvDistributor.Location = new Point(0, 309);
            dgvDistributor.Name = "dgvDistributor";
            dgvDistributor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistributor.Size = new Size(1029, 321);
            dgvDistributor.TabIndex = 0;
            dgvDistributor.CellClick += dgvDistributor_CellClick;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(48, 82);
            lbId.Name = "lbId";
            lbId.Size = new Size(139, 21);
            lbId.TabIndex = 1;
            lbId.Text = "Mã nhà phân phối:";
            // 
            // txtId
            // 
            txtId.Location = new Point(193, 79);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(326, 29);
            txtId.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(47, 131);
            lbName.Name = "lbName";
            lbName.Size = new Size(140, 21);
            lbName.TabIndex = 1;
            lbName.Text = "Tên nhà phân phối:";
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 29);
            txtName.TabIndex = 2;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(127, 185);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(60, 21);
            lbAddress.TabIndex = 1;
            lbAddress.Text = "Địa chỉ:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(639, 79);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(326, 29);
            txtPhoneNumber.TabIndex = 2;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 82);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 1;
            label4.Text = "Số điện thoại:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(639, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 29);
            txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(582, 134);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 21);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(193, 182);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(772, 29);
            txtAddress.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(99, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(735, 29);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(846, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(99, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(341, 243);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 243);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(825, 243);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(103, 34);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Tải lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(lbEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lbName);
            Controls.Add(lbAddress);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(dgvDistributor);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDistributor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDistributor;
        private Label lbId;
        private TextBox txtId;
        private Label lbName;
        private TextBox txtName;
        private Label lbAddress;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtAddress;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
    }
}
