namespace _40833
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new DistributorDbContext())
            {
                var distributor = new Distributor
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,

                    Email = txtEmail.Text
                };
                context.Add(distributor);
                context.SaveChanges();
                MessageBox.Show("Thêm mới thành công!", "Thông báo");
            }
            btnLoad.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var context = new DistributorDbContext())
            {
                var distributor = context.Distributors.FirstOrDefault(d => d.Id == int.Parse(txtId.Text));
                if (distributor != null)
                {
                    distributor.Name = txtName.Text;
                    distributor.Address = txtAddress.Text;
                    distributor.PhoneNumber = txtPhoneNumber.Text;
                    distributor.Email = txtEmail.Text;
                    context.SaveChanges();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    btnLoad.PerformClick();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu muốn sửa!", "Thông báo");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new DistributorDbContext())
            {
                var distributor = context.Distributors.FirstOrDefault(d => d.Id == int.Parse(txtId.Text));
                if (distributor != null)
                {
                    context.Remove(distributor);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    btnLoad.PerformClick();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu muốn xóa!", "Thông báo");
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var context = new DistributorDbContext())
            {
                dgvDistributor.DataSource = context.Distributors.ToList();
                txtId.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
            }
        }

        private void dgvDistributor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvDistributor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvDistributor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddress.Text = dgvDistributor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvDistributor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvDistributor.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new DistributorDbContext())
            {
                var distributor = context.Distributors.Where(d => d.Name.Contains(txtName.Text));
                if (distributor == null)
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo");
                }
                else
                {
                    dgvDistributor.DataSource = distributor.ToList();
                }
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
