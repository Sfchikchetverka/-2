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
    public partial class OrdersStaff : Form
    {
        private readonly AppDbContext _context;
        public OrdersStaff(AppDbContext context)
        {
            InitializeComponent();
            _context=context;
            var Orders = from s in _context.Orders select s;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Orders.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            var order = (Order)selectedRow.DataBoundItem;
            foreach(var s in _context.Skates)
            {
                if(s.Id == order.SkatesId)
                {
                    s.Count++;
                }
            }
            _context.Orders.Remove(order);
            _context.SaveChanges();
            var orders = from s in _context.Orders select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.ToList();
        }
    }
}
