using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач_опбд_версия_2.Формы_для_сотрудника;
using Курсач_опбд_версия_2.Формы_пользователя;

namespace Курсач_опбд_версия_2
{
    public partial class UserMainForm : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        public UserMainForm(AppDbContext context, User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            label.Text = $"Добро пожаловать,{_user.Name}!";
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderCell.Value = "Тип";
            dataGridView1.Columns[1].HeaderCell.Value = "Размер";
            dataGridView1.Columns[2].HeaderCell.Value = "Количество";
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach(var s in _context.Skates)
            {
                dataGridView1.Rows[i].Cells[0].Value = s.Type;
                dataGridView1.Rows[i].Cells[1].Value = s.Size;
                dataGridView1.Rows[i].Cells[2].Value = s.Count;
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach(var s in _context.Orders)
            {
                if(s.UserId == _user.UserId) flag = false;
            }
            if (flag)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow != null)
                {
                    var skate = (Skates)selectedRow.DataBoundItem;
                    _context.Orders.Add(new Order
                    {
                        UserId=_user.UserId,
                        SkatesId = skate.Id,
                        Status= "Не выдан",
                        GetTime = DateTime.Now.AddHours(1),
                        Fine = 0,
                        GiveTime = DateTime.Now.AddHours(2),
                        IsHanded= false,
                    });
                    skate.Count--;
                    _context.SaveChanges();
                    var Skates = from s in _context.Skates where s.isDeleted == false && s.Count>0 select s;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Skates.ToList();
                }
                else
                {
                    MessageBox.Show("Сначала выберите коньки!");
                }
            }
            else
            {
                MessageBox.Show("У вас уже есть заказ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sssForm = new UserOrders(_context,_user);
            if (sssForm.ShowDialog() == DialogResult.OK)
            {
                var Skates = from s in _context.Skates where s.isDeleted == false && s.Count>0 select s;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = Skates.ToList();
            }
        }
    }
}
