namespace _40830
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryDbContext())
            {
                var Inventory = new Inventory
                {
                    Name = txtName.Text,
                    Location = txtLocation.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = txtDescription.Text,
                };
                context.Inventories.Add(Inventory);
                int check = context.SaveChanges();
                if (check == 0)
                {
                    MessageBox.Show("Thêm mới dữ liệu không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                    dgvInventory.DataSource = context.Inventories.ToList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryDbContext())
            {
                var Inventory = context.Inventories.FirstOrDefault(i => i.Id == int.Parse(txtId.Text));
                if (Inventory != null)
                {
                    Inventory.Name = txtName.Text;
                    Inventory.Location = txtLocation.Text;
                    Inventory.Quantity = int.Parse(txtQuantity.Text);
                    Inventory.Description = txtDescription.Text;
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        dgvInventory.DataSource = context.Inventories.ToList();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryDbContext())
            {
                var Inventory = context.Inventories.FirstOrDefault(i => i.Id == int.Parse(txtId.Text));
                if (Inventory != null)
                {
                    context.Remove(Inventory);
                    int check = context.SaveChanges();
                    if (check == 0)
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        dgvInventory.DataSource = context.Inventories.ToList();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryDbContext())
            {
                var Inventory = context.Inventories.ToList();
                dgvInventory.DataSource = Inventory;
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantity.Text = dgvInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLocation.Text = dgvInventory.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescription.Text = dgvInventory.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new InventoryDbContext())
            {
                dgvInventory.DataSource = context.Inventories.Where(b => b.Name.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
