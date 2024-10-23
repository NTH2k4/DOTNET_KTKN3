namespace _40831
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectDbContext())
            {
                var Project = new Project
                {
                    Name = txtName.Text,
                    TimeStart = dtpTimeStart.Value,
                    TimeEnd = dtpTimeEnd.Value,
                    Status = txtStatus.Text,
                };
                context.Projects.Add(Project);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvProject.DataSource = context.Projects.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectDbContext())
            {
                var Project = context.Projects.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (Project != null)
                {
                    Project.Name = txtName.Text;
                    Project.TimeStart = dtpTimeStart.Value;
                    Project.TimeEnd = dtpTimeEnd.Value;
                    Project.Status = txtStatus.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvProject.DataSource = context.Projects.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectDbContext())
            {
                var Project = context.Projects.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (Project != null)
                {
                    context.Remove(Project);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvProject.DataSource = context.Projects.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectDbContext())
            {
                var Project = context.Projects.ToList();
                dgvProject.DataSource = Project;
            }
        }

        private void dgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProject.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProject.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpTimeStart.Value = (DateTime)dgvProject.Rows[e.RowIndex].Cells[2].Value;
            dtpTimeEnd.Value = (DateTime)dgvProject.Rows[e.RowIndex].Cells[3].Value;
            txtStatus.Text = dgvProject.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new ProjectDbContext())
            {
                dgvProject.DataSource = context.Projects.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
