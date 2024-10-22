namespace TP01_Book
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
            splitContainer1 = new SplitContainer();
            btnLoadData = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddNew = new Button();
            txtDescription = new RichTextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lbDescribe = new Label();
            lbQuantity = new Label();
            lbPrice = new Label();
            lbName = new Label();
            lbId = new Label();
            dgvBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnLoadData);
            splitContainer1.Panel1.Controls.Add(btnDelete);
            splitContainer1.Panel1.Controls.Add(btnUpdate);
            splitContainer1.Panel1.Controls.Add(btnAddNew);
            splitContainer1.Panel1.Controls.Add(txtDescription);
            splitContainer1.Panel1.Controls.Add(txtQuantity);
            splitContainer1.Panel1.Controls.Add(txtPrice);
            splitContainer1.Panel1.Controls.Add(txtName);
            splitContainer1.Panel1.Controls.Add(txtId);
            splitContainer1.Panel1.Controls.Add(lbDescribe);
            splitContainer1.Panel1.Controls.Add(lbQuantity);
            splitContainer1.Panel1.Controls.Add(lbPrice);
            splitContainer1.Panel1.Controls.Add(lbName);
            splitContainer1.Panel1.Controls.Add(lbId);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvBook);
            splitContainer1.Size = new Size(1029, 630);
            splitContainer1.SplitterDistance = 408;
            splitContainer1.TabIndex = 0;
            // 
            // btnLoadData
            // 
            btnLoadData.Font = new Font("Segoe UI", 9.75F);
            btnLoadData.Location = new Point(297, 567);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(75, 31);
            btnLoadData.TabIndex = 13;
            btnLoadData.Text = "Tải lại";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F);
            btnDelete.Location = new Point(208, 567);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F);
            btnUpdate.Location = new Point(119, 567);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Font = new Font("Segoe UI", 9.75F);
            btnAddNew.Location = new Point(30, 567);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 31);
            btnAddNew.TabIndex = 10;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(112, 301);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(262, 223);
            txtDescription.TabIndex = 9;
            txtDescription.Text = "";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(112, 228);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(262, 29);
            txtQuantity.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(112, 162);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(262, 29);
            txtPrice.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 29);
            txtName.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(112, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(262, 29);
            txtId.TabIndex = 5;
            // 
            // lbDescribe
            // 
            lbDescribe.AutoSize = true;
            lbDescribe.Location = new Point(25, 297);
            lbDescribe.Name = "lbDescribe";
            lbDescribe.Size = new Size(53, 21);
            lbDescribe.TabIndex = 4;
            lbDescribe.Text = "Mô tả:";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(25, 231);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(76, 21);
            lbQuantity.TabIndex = 3;
            lbQuantity.Text = "Số lượng:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(25, 165);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(36, 21);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Giá:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(25, 99);
            lbName.Name = "lbName";
            lbName.Size = new Size(71, 21);
            lbName.TabIndex = 1;
            lbName.Text = "Tên sách:";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(25, 33);
            lbId.Name = "lbId";
            lbId.Size = new Size(70, 21);
            lbId.TabIndex = 0;
            lbId.Text = "Mã sách:";
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Dock = DockStyle.Fill;
            dgvBook.Location = new Point(0, 0);
            dgvBook.Name = "dgvBook";
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBook.Size = new Size(617, 630);
            dgvBook.TabIndex = 0;
            dgvBook.CellClick += dgvBook_CellClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvBook;
        private Label lbId;
        private Label lbDescribe;
        private Label lbQuantity;
        private Label lbPrice;
        private Label lbName;
        private RichTextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnLoadData;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNew;
    }
}
