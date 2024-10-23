namespace _40829
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new OrderDbContext())
            {
                var Order = new Order
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Time = dtpTime.Value,
                    Status = txtStatus.Text,
                };
                context.Orders.Add(Order);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvOrder.DataSource = context.Orders.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new OrderDbContext())
            {
                var Order = context.Orders.FirstOrDefault(o => o.Id == int.Parse(txtId.Text));
                if (Order != null)
                {
                    Order.Name = txtName.Text;
                    Order.Price = decimal.Parse(txtPrice.Text);
                    Order.Time = dtpTime.Value;
                    Order.Status = txtStatus.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvOrder.DataSource = context.Orders.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new OrderDbContext())
            {
                var Order = context.Orders.FirstOrDefault(o => o.Id == int.Parse(txtId.Text));
                if (Order != null)
                {
                    context.Remove(Order);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvOrder.DataSource = context.Orders.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new OrderDbContext())
            {
                var Order = context.Orders.ToList();
                dgvOrder.DataSource = Order;
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpTime.Value = (DateTime)dgvOrder.Rows[e.RowIndex].Cells[2].Value;
            txtPrice.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStatus.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new OrderDbContext())
            {
                dgvOrder.DataSource = context.Orders.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
