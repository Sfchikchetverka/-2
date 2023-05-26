using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач_опбд_версия_2
{
    public partial class StaffAdd : Form
    {
        Hash hash= new Hash();
        private readonly AppDbContext _context;
        public User User { get; private set; }
        public StaffAdd(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"\+[0-9]{11}");
            if (phoneNumpattern.IsMatch(PhoneTextBox.Text))
            {
                bool flag=true;
                foreach (var u in _context.Users)
                {
                    if (u.Phone == PhoneTextBox.Text)
                    {
                        MessageBox.Show("Сотрудник с таким номером уже есть!");
                        flag= false;
                    }
                }
                if (flag)
                {
                    var user = new User
                    {
                        Name = NameTextBox.Text,
                        Surname = SurNameTextBox.Text,
                        Phone= PhoneTextBox.Text,
                        Role = "Staff",
                        Password = hash.GetHashString(PassTextBox.Text)
                    };
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    User = user;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Неверный формат номера телефона!");
            }
        }

        private void StaffAdd_Load(object sender, EventArgs e)
        {
            PassTextBox.UseSystemPasswordChar= true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassTextBox.UseSystemPasswordChar= false;
            }
            else
            {
                PassTextBox.UseSystemPasswordChar= true;
            }
        }
    }
}
