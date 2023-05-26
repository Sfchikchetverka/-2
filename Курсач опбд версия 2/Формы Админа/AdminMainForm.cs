using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач_опбд_версия_2
{
    public partial class AdminMainForm : Form
    {
        private readonly AppDbContext _context;
       
        public AdminMainForm(AppDbContext context)
        {
            InitializeComponent();
            _context=context;
            var Staff = from s in _context.Users
                           where s.Role == "Staff"
                           select s;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Staff.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sssForm = new StaffAdd(_context);
            if (sssForm.ShowDialog() == DialogResult.OK)
            {
                var Staff = from s in _context.Users
                            where s.Role == "Staff"
                            select s;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Staff.ToList();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            var staff = (User)selectedRow.DataBoundItem;
            _context.Users.Remove(staff);
            _context.SaveChanges();
            var Staff = from s in _context.Users
                        where s.Role == "Staff"
                        select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Staff.ToList();
        }
    }
}
