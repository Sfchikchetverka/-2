using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач_опбд_версия_2.Формы_для_сотрудника
{
    public partial class StaffMainForm : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        public StaffMainForm(AppDbContext context,User user)
        {
            InitializeComponent();
            _context=context;
            _user=user;
            label1.Text = $"Добро пожаловать,{_user.Name}!";
            var Skates = from s in _context.Skates where s.isDeleted == false select s;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Skates.ToList();
        }

        private void StaffMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sssForm = new SkatesAdd(_context);
            if (sssForm.ShowDialog() == DialogResult.OK)
            {
                var Skates = from s in _context.Skates where s.isDeleted == false select s;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Skates.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            var skate = (Skates)selectedRow.DataBoundItem;
            skate.isDeleted = true;
            var Off = new WriteoffSkates
            {
                SkatesId = skate.Id,
                WriteOffDate = DateTime.Now
            };
            _context.SaveChanges();
            var Skates = from s in _context.Skates where s.isDeleted == false select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Skates.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sssForm = new OrdersStaff(_context);
            sssForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
