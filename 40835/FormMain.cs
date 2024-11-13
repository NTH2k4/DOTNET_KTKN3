using Microsoft.IdentityModel.Tokens;
using System.CodeDom;
using System.Linq.Expressions;
using System.Net.Mime;

namespace _40835
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text) && textBox != txtSearch && textBox != txtId)
                {
                    MessageBox.Show("Không được để các ô trống!", "Cảnh báo");
                    return;
                }
            }
            if (int.Parse(txtYear.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Năm sản xuất không được quá năm hiện tại!", "Cảnh báo");
                return;
            }
            try
            {
                using (var context = new ArticleDbContext())
                {
                    var article = new Article
                    {
                        Title = txtTitle.Text,
                        Name = txtName.Text,
                        Summary = txtSummary.Text,
                        Year = int.Parse(txtYear.Text)
                    };
                    context.Add(article);
                    context.SaveChanges();
                    MessageBox.Show("Thêm mới thành công!", "Thông báo");
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu muốn sửa!", "Cảnh báo");
                return;
            }
            if (int.Parse(txtYear.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Năm sản xuất không được quá năm hiện tại!", "Cảnh báo");
                return;
            }
            using (var context = new ArticleDbContext())
            {
                var article = context.Articles.FirstOrDefault(a => a.Id == int.Parse(txtId.Text));
                if (article != null)
                {
                    article.Title = txtTitle.Text;
                    article.Name = txtName.Text;
                    article.Summary = txtSummary.Text;
                    article.Year = int.Parse(txtYear.Text);
                    context.SaveChanges();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    btnLoad.PerformClick();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu muốn xóa!", "Cảnh báo");
                return;
            }
            using (var context = new ArticleDbContext())
            {
                var item = context.Articles.FirstOrDefault(a => a.Id == int.Parse(txtId.Text));
                if (item != null)
                {
                    context.Remove(item);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    btnLoad.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo");
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var context = new ArticleDbContext())
            {
                dgvData.DataSource = context.Articles.ToList();
                dgvData.Columns[0].HeaderText = "Mã bài báo";
                dgvData.Columns[1].HeaderText = "Tiêu đề";
                dgvData.Columns[2].HeaderText = "Tên tác giả";
                dgvData.Columns[3].HeaderText = "Năm sản xuất";
                dgvData.Columns[4].HeaderText = "Tóm tắt";
                txtId.Text = string.Empty;
                txtTitle.Text = string.Empty;
                txtName.Text = string.Empty;
                txtSummary.Text = string.Empty;
                txtYear.Text = string.Empty;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty || string.IsNullOrWhiteSpace(txtSearch.Text))
                using (var context = new ArticleDbContext())
                {
                    dgvData.DataSource = context.Articles.Where(a => a.Title.Contains(txtSearch.Text)).ToList();
                }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtTitle.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtYear.Text = row.Cells[3].Value.ToString();
            txtSummary.Text = row.Cells[4].Value.ToString();
        }
    }
}
