namespace _40831
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
            lbTimeEnd = new Label();
            lbTimeStart = new Label();
            lbName = new Label();
            lbId = new Label();
            btnSearch = new Button();
            txtStatus = new TextBox();
            dgvProject = new DataGridView();
            dtpTimeStart = new DateTimePicker();
            dtpTimeEnd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvProject).BeginInit();
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
            lbStatus.Location = new Point(57, 194);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(82, 21);
            lbStatus.TabIndex = 20;
            lbStatus.Text = "Trạng thái:";
            // 
            // lbTimeEnd
            // 
            lbTimeEnd.AutoSize = true;
            lbTimeEnd.Location = new Point(627, 142);
            lbTimeEnd.Name = "lbTimeEnd";
            lbTimeEnd.Size = new Size(109, 21);
            lbTimeEnd.TabIndex = 19;
            lbTimeEnd.Text = "Ngày kết thúc:";
            // 
            // lbTimeStart
            // 
            lbTimeStart.AutoSize = true;
            lbTimeStart.Location = new Point(630, 89);
            lbTimeStart.Name = "lbTimeStart";
            lbTimeStart.Size = new Size(106, 21);
            lbTimeStart.TabIndex = 18;
            lbTimeStart.Text = "Ngày bắt đầu:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(60, 142);
            lbName.Name = "lbName";
            lbName.Size = new Size(79, 21);
            lbName.TabIndex = 17;
            lbName.Text = "Tên dự án:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(61, 90);
            lbId.Name = "lbId";
            lbId.Size = new Size(78, 21);
            lbId.TabIndex = 16;
            lbId.Text = "Mã dự án:";
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
            // dgvProject
            // 
            dgvProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProject.Location = new Point(66, 237);
            dgvProject.Name = "dgvProject";
            dgvProject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProject.Size = new Size(1137, 369);
            dgvProject.TabIndex = 32;
            dgvProject.CellClick += dgvProject_CellClick;
            // 
            // dtpTimeStart
            // 
            dtpTimeStart.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dtpTimeStart.Format = DateTimePickerFormat.Custom;
            dtpTimeStart.Location = new Point(742, 86);
            dtpTimeStart.Name = "dtpTimeStart";
            dtpTimeStart.Size = new Size(206, 29);
            dtpTimeStart.TabIndex = 33;
            // 
            // dtpTimeEnd
            // 
            dtpTimeEnd.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dtpTimeEnd.Format = DateTimePickerFormat.Custom;
            dtpTimeEnd.Location = new Point(742, 139);
            dtpTimeEnd.Name = "dtpTimeEnd";
            dtpTimeEnd.Size = new Size(206, 29);
            dtpTimeEnd.TabIndex = 34;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dtpTimeEnd);
            Controls.Add(dtpTimeStart);
            Controls.Add(dgvProject);
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
            Controls.Add(lbTimeEnd);
            Controls.Add(lbTimeStart);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvProject).EndInit();
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
        private Label lbTimeEnd;
        private Label lbTimeStart;
        private Label lbName;
        private Label lbId;
        private Button btnSearch;
        private TextBox txtStatus;
        private DataGridView dgvProject;
        private DateTimePicker dtpTimeStart;
        private DateTimePicker dtpTimeEnd;
    }
}
