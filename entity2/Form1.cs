using System.Windows.Forms;
using entity2.Data;
using entity2.Models;

namespace entity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using var db = new AppDbContext();
            dataGridView1.DataSource = db.Employees.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddName.Text) ||
                string.IsNullOrWhiteSpace(txtAddPosition.Text) ||
                !decimal.TryParse(txtAddSalary.Text, out decimal salary))
            {
                MessageBox.Show("Заполните все поля корректно.");
                return;
            }

            using var db = new AppDbContext();
            db.Employees.Add(new Employee
            {
                Name = txtAddName.Text,
                Position = txtAddPosition.Text,
                Salary = salary
            });
            db.SaveChanges();

            txtAddName.Clear();
            txtAddPosition.Clear();
            txtAddSalary.Clear();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUpdId.Text, out int id) ||
                string.IsNullOrWhiteSpace(txtUpdName.Text) ||
                string.IsNullOrWhiteSpace(txtUpdPosition.Text) ||
                !decimal.TryParse(txtUpdSalary.Text, out decimal salary))
            {
                MessageBox.Show("Заполните все поля корректно.");
                return;
            }

            using var db = new AppDbContext();
            var employee = db.Employees.Find(id);

            if (employee == null)
            {
                MessageBox.Show("Сотрудник не найден.");
                return;
            }

            employee.Name = txtUpdName.Text;
            employee.Position = txtUpdPosition.Text;
            employee.Salary = salary;
            db.SaveChanges();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDelId.Text, out int id))
            {
                MessageBox.Show("Введите корректный ID.");
                return;
            }

            using var db = new AppDbContext();
            var employee = db.Employees.Find(id);

            if (employee == null)
            {
                MessageBox.Show("Сотрудник не найден.");
                return;
            }

            db.Employees.Remove(employee);
            db.SaveChanges();

            txtDelId.Clear();
            LoadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFindId.Text, out int id))
            {
                MessageBox.Show("Введите корректный ID.");
                return;
            }

            using var db = new AppDbContext();
            var employee = db.Employees.Find(id);

            if (employee == null)
            {
                MessageBox.Show("Сотрудник не найден.");
                return;
            }

            dataGridView1.DataSource = new List<Employee> { employee };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}