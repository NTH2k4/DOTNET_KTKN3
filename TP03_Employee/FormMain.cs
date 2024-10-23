namespace TP03_Employee
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeDbContext())
            {
                var Employee = new Employee
                {
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Position = txtPosition.Text,
                    Address = txtAddress.Text,
                };
                context.Employees.Add(Employee);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvEmployee.DataSource = context.Employees.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeDbContext())
            {
                var Employee = context.Employees.FirstOrDefault(b => b.Id == int.Parse(txtId.Text));
                if (Employee != null)
                {
                    Employee.Name = txtName.Text;
                    Employee.Age = int.Parse(txtAge.Text);
                    Employee.Position = txtPosition.Text;
                    Employee.Address = txtAddress.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvEmployee.DataSource = context.Employees.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeDbContext())
            {
                var Employee = context.Employees.FirstOrDefault(b => b.Id == int.Parse(txtId.Text));
                if (Employee != null)
                {
                    context.Remove(Employee);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvEmployee.DataSource = context.Employees.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeDbContext())
            {
                var Employee = context.Employees.ToList();
                dgvEmployee.DataSource = Employee;
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAge.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPosition.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeDbContext())
            {
                dgvEmployee.DataSource = context.Employees.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
