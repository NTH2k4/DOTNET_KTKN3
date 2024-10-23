namespace TP02_Phone
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var Phone = new Phone
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = txtDescription.Text,
                };
                context.Phones.Add(Phone);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvPhone.DataSource = context.Phones.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var Phone = context.Phones.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (Phone != null)
                {
                    Phone.Name = txtName.Text;
                    Phone.Price = decimal.Parse(txtPrice.Text);
                    Phone.Quantity = int.Parse(txtQuantity.Text);
                    Phone.Description = txtDescription.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvPhone.DataSource = context.Phones.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var Phone = context.Phones.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (Phone != null)
                {
                    context.Remove(Phone);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvPhone.DataSource = context.Phones.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var Phone = context.Phones.ToList();
                dgvPhone.DataSource = Phone;
            }
        }

        private void dgvPhone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPhone.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvPhone.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvPhone.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = dgvPhone.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescription.Text = dgvPhone.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                dgvPhone.DataSource = context.Phones.Where(p => p.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
