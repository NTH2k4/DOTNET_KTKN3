namespace _40827
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var Product = new Product
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = txtDescription.Text,
                };
                context.Products.Add(Product);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvProduct.DataSource = context.Products.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var Product = context.Products.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (Product != null)
                {
                    Product.Name = txtName.Text;
                    Product.Price = decimal.Parse(txtPrice.Text);
                    Product.Quantity = int.Parse(txtQuantity.Text);
                    Product.Description = txtDescription.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvProduct.DataSource = context.Products.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var Product = context.Products.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (Product != null)
                {
                    context.Remove(Product);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvProduct.DataSource = context.Products.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var Product = context.Products.ToList();
                dgvProduct.DataSource = Product;
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescription.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                dgvProduct.DataSource = context.Products.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
