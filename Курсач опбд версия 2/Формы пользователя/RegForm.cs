using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсач_опбд_версия_2
{
    public partial class RegForm : Form
    {
        private readonly AppDbContext _context;
        Hash hash = new Hash();
        public RegForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            PassTextBox.UseSystemPasswordChar= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"\+[0-9]{11}");
            if (phoneNumpattern.IsMatch(PhoneTextBox.Text))
            {
                bool flag = true;
                foreach (var u in _context.Users)
                {
                    if (u.Phone == PhoneTextBox.Text)
                    {
                        MessageBox.Show("Аккаунт с таким номером уже есть!");
                            flag=false;
                    }
                }
                if (flag)
                {
                    var user = new User
                    {
                        Name = NameTextBox.Text,
                        Surname = SurNameTextBox.Text,
                        Phone= PhoneTextBox.Text,
                        Role = "User",
                        Password = hash.GetHashString(PassTextBox.Text)
                    };
                    _context.Users.Add(user);
                    _context.SaveChanges();

                    MessageBox.Show("Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Неверный формат номера телефона!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            this.Close();
            loginForm.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                PassTextBox.UseSystemPasswordChar= false;
            }
            else
            {
                PassTextBox.UseSystemPasswordChar= true;
            }
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
