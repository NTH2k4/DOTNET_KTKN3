namespace TP01_Book
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var book = new Book
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = txtDescription.Text,
                };
                context.Books.Add(book);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvBook.DataSource = context.Books.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var book = context.Books.FirstOrDefault(b => b.Id == int.Parse(txtId.Text));
                if (book != null)
                {
                    book.Name = txtName.Text;
                    book.Price = decimal.Parse(txtPrice.Text);
                    book.Quantity = int.Parse(txtQuantity.Text);
                    book.Description = txtDescription.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvBook.DataSource = context.Books.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var book = context.Books.FirstOrDefault(b => b.Id == int.Parse(txtId.Text));
                if (book != null)
                {
                    context.Remove(book);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvBook.DataSource = context.Books.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var book = context.Books.ToList();
                dgvBook.DataSource = book;
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvBook.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = dgvBook.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescription.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                dgvBook.DataSource = context.Books.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
