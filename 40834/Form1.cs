namespace _40834
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string errorMessage = ""; if (string.IsNullOrWhiteSpace(txtName.Text)) { errorMessage += "Vui lòng nhập tên.\n"; }
            if (string.IsNullOrWhiteSpace(txtNationality.Text)) { errorMessage += "Vui lòng nhập quốc tịch.\n"; }
            if (string.IsNullOrWhiteSpace(txtNumber.Text)) { errorMessage += "Vui lòng nhập số lượng.\n"; }
            if (!string.IsNullOrEmpty(errorMessage)) { MessageBox.Show(errorMessage, "Cảnh báo"); return; }
            using (var context = new AuthorDbContext())
            {
                var author = new Author
                {
                    Name = txtName.Text,
                    Birthday = dtpBirthDay.Value,
                    Nationality = txtNationality.Text,
                    Number = int.Parse(txtNumber.Text)
                };
                context.Add(author);
                context.SaveChanges();
                MessageBox.Show("Thêm mới thành công!", "Thông báo");
            }
            btnLoad.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAuthor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu muốn sửa!", "Thông báo");
                return;
            }
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorMessage += "Vui lòng nhập tên!\n";
            }
            if (string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                errorMessage += "Vui lòng nhập quốc tích!\n";
            }
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                errorMessage += "Vui lòng nhập số lượng!\n";
            }
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Cảnh báo");
                return;
            }
            using (var context = new AuthorDbContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.Id == int.Parse(txtId.Text));
                if (author != null)
                {
                    author.Name = txtName.Text;
                    author.Number = int.Parse(txtNumber.Text);
                    author.Birthday = dtpBirthDay.Value;
                    author.Nationality = txtNationality.Text;
                    context.SaveChanges();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu muốn sửa!", "Thông báo");
                }
            }
            btnLoad.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAuthor.SelectedRows.Count == 0 || txtId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu muốn xóa!", "Thông báo");
                return;
            }
            using (var context = new AuthorDbContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.Id == int.Parse(txtId.Text));
                if (author != null)
                {
                    context.Remove(author);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu muốn xóa!", "Thông báo");
                }
            }
            btnLoad.PerformClick();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var context = new AuthorDbContext())
            {
                dgvAuthor.DataSource = context.Authors.ToList();
                dgvAuthor.Columns[0].HeaderText = "Mã tác giả";
                dgvAuthor.Columns[1].HeaderText = "Tên tác giả";
                dgvAuthor.Columns[2].HeaderText = "Ngày sinh";
                dgvAuthor.Columns[3].HeaderText = "Quốc tịch";
                dgvAuthor.Columns[4].HeaderText = "Số lượng";
                txtId.Text = "";
                txtName.Text = string.Empty;
                txtNumber.Text = string.Empty;
                txtNationality.Text = string.Empty;
            }
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvAuthor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvAuthor.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpBirthDay.Value = (DateTime)dgvAuthor.Rows[e.RowIndex].Cells[2].Value;
            txtNationality.Text = dgvAuthor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumber.Text = dgvAuthor.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new AuthorDbContext())
            {
                dgvAuthor.DataSource = context.Authors.Where(a => a.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
