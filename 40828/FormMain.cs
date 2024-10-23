namespace _40828
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbContext())
            {
                var Supplier = new Supplier
                {
                    Name = txtName.Text,
                    Phone_Number = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                };
                context.Suppliers.Add(Supplier);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvSupplier.DataSource = context.Suppliers.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbContext())
            {
                var Supplier = context.Suppliers.FirstOrDefault(s => s.Id == int.Parse(txtId.Text));
                if (Supplier != null)
                {
                    Supplier.Name = txtName.Text;
                    Supplier.Phone_Number = txtPhoneNumber.Text;
                    Supplier.Address = txtAddress.Text;
                    Supplier.Email = txtEmail.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvSupplier.DataSource = context.Suppliers.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbContext())
            {
                var Supplier = context.Suppliers.FirstOrDefault(s => s.Id == int.Parse(txtId.Text));
                if (Supplier != null)
                {
                    context.Remove(Supplier);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvSupplier.DataSource = context.Suppliers.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbContext())
            {
                var Supplier = context.Suppliers.ToList();
                dgvSupplier.DataSource = Supplier;
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhoneNumber.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbContext())
            {
                dgvSupplier.DataSource = context.Suppliers.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
