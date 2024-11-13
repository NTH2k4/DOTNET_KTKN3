namespace _40834
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
            lbId = new Label();
            txtId = new TextBox();
            dgvAuthor = new DataGridView();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNationality = new TextBox();
            txtNumber = new TextBox();
            label5 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dtpBirthDay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(95, 101);
            lbId.Name = "lbId";
            lbId.Size = new Size(84, 21);
            lbId.TabIndex = 0;
            lbId.Text = "Mã tác giá:";
            // 
            // txtId
            // 
            txtId.Location = new Point(185, 98);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(292, 29);
            txtId.TabIndex = 2;
            // 
            // dgvAuthor
            // 
            dgvAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Dock = DockStyle.Bottom;
            dgvAuthor.Location = new Point(0, 328);
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthor.Size = new Size(1029, 302);
            dgvAuthor.TabIndex = 2;
            dgvAuthor.CellClick += dgvAuthor_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 155);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên tác giả:";
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 29);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 104);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 0;
            label3.Text = "Năm sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 155);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 0;
            label4.Text = "Quốc tích:";
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(640, 152);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(292, 29);
            txtNationality.TabIndex = 5;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(185, 200);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(292, 29);
            txtNumber.TabIndex = 6;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 203);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 0;
            label5.Text = "Số tác phẩm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(75, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(774, 29);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(858, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(173, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 39);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(358, 256);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 39);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 39);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(728, 256);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(96, 39);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Tải lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.CustomFormat = "dd/MM/yyyy";
            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.Location = new Point(640, 101);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new Size(292, 29);
            dtpBirthDay.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(dtpBirthDay);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(dgvAuthor);
            Controls.Add(txtSearch);
            Controls.Add(txtNumber);
            Controls.Add(txtNationality);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private TextBox txtId;
        private DataGridView dgvAuthor;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtNationality;
        private TextBox txtNumber;
        private Label label5;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
        private DateTimePicker dtpBirthDay;
    }
}
