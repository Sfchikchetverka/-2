using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач_опбд_версия_2.Формы_пользователя
{
    public partial class UserOrders : Form
    {
        AppDbContext _context;
        User _user;
        public UserOrders(AppDbContext context, User user)
        {
            InitializeComponent();
            _context=context;
            _user=user;
            var uOrder = from s in _context.Orders where s.UserId == _user.UserId select s;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource= uOrder.ToList();
        }

        private void UserOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
