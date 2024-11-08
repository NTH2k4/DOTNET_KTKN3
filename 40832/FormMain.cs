namespace _40832
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new DepartmentDbContext())
            {
                var Department = new Department
                {
                    Name = txtName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    Address = txtAddress.Text,
                };
                context.Departments.Add(Department);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvDepartment.DataSource = context.Departments.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DepartmentDbContext())
            {
                var Department = context.Departments.FirstOrDefault(d => d.Id == int.Parse(txtId.Text));
                if (Department != null)
                {
                    Department.Name = txtName.Text;
                    Department.PhoneNumber = txtPhoneNumber.Text;
                    Department.Quantity = int.Parse(txtQuantity.Text);
                    Department.Address = txtAddress.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvDepartment.DataSource = context.Departments.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new DepartmentDbContext())
            {
                var Department = context.Departments.FirstOrDefault(d => d.Id == int.Parse(txtId.Text));
                if (Department != null)
                {
                    context.Remove(Department);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvDepartment.DataSource = context.Departments.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new DepartmentDbContext())
            {
                var Department = context.Departments.ToList();
                dgvDepartment.DataSource = Department;
            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhoneNumber.Text = dgvDepartment.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = dgvDepartment.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvDepartment.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new DepartmentDbContext())
            {
                dgvDepartment.DataSource = context.Departments.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
