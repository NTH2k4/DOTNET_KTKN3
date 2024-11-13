namespace _40835
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
            dgvData = new DataGridView();
            lbId = new Label();
            txtSearch = new TextBox();
            txtId = new TextBox();
            lbTitle = new Label();
            txtTitle = new TextBox();
            lbName = new Label();
            txtName = new TextBox();
            lbYear = new Label();
            txtYear = new TextBox();
            lbSummary = new Label();
            txtSummary = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Bottom;
            dgvData.Location = new Point(0, 294);
            dgvData.Name = "dgvData";
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(1029, 336);
            dgvData.TabIndex = 0;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(71, 90);
            lbId.Name = "lbId";
            lbId.Size = new Size(90, 21);
            lbId.TabIndex = 1;
            lbId.Text = "Mã bài báo:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(140, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(701, 29);
            txtSearch.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(167, 87);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(298, 29);
            txtId.TabIndex = 2;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(97, 128);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(63, 21);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Tiêu đề:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(167, 122);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(298, 29);
            txtTitle.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(543, 93);
            lbName.Name = "lbName";
            lbName.Size = new Size(85, 21);
            lbName.TabIndex = 1;
            lbName.Text = "Tên tác giả:";
            // 
            // txtName
            // 
            txtName.Location = new Point(634, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(298, 29);
            txtName.TabIndex = 2;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(523, 128);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(105, 21);
            lbYear.TabIndex = 1;
            lbYear.Text = "Năm sản xuất";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(634, 125);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(298, 29);
            txtYear.TabIndex = 2;
            txtYear.KeyPress += txtYear_KeyPress;
            // 
            // lbSummary
            // 
            lbSummary.AutoSize = true;
            lbSummary.Location = new Point(97, 163);
            lbSummary.Name = "lbSummary";
            lbSummary.Size = new Size(64, 21);
            lbSummary.TabIndex = 1;
            lbSummary.Text = "Tóm tắt:";
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(167, 160);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(765, 29);
            txtSummary.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(849, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(140, 216);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(358, 216);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 32);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(576, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(794, 216);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(85, 32);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Tải lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSummary);
            Controls.Add(txtYear);
            Controls.Add(lbSummary);
            Controls.Add(txtName);
            Controls.Add(lbYear);
            Controls.Add(txtTitle);
            Controls.Add(lbName);
            Controls.Add(txtId);
            Controls.Add(lbTitle);
            Controls.Add(txtSearch);
            Controls.Add(lbId);
            Controls.Add(dgvData);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label lbId;
        private TextBox txtSearch;
        private TextBox txtId;
        private Label lbTitle;
        private TextBox txtTitle;
        private Label lbName;
        private TextBox txtName;
        private Label lbYear;
        private TextBox txtYear;
        private Label lbSummary;
        private TextBox txtSummary;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
    }
}
