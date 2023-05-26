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

namespace Курсач_опбд_версия_2.Формы_для_сотрудника
{
    public partial class SkatesAdd : Form
    {
        private readonly AppDbContext _context;
        public SkatesAdd(AppDbContext context)
        {
            InitializeComponent();
            _context=context;
        }

        private void SkatesAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type="";
            if (radioButton1.Checked)
            {
                type="Фигурные";
            }
            else if (radioButton2.Checked)
            {
                type = "Хоккейные";
            }
            var skate = new Skates
            {
                Manufacturer = ManuTextBox.Text,
                Price = (float)Convert.ToDouble(PriceTextBox.Text),
                Size = Convert.ToInt32(numericUpDown1.Value),
                Count = Convert.ToInt32(numericUpDown2.Value),
                Type= type,
                isDeleted = false
            };
            _context.Skates.Add(skate);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
        }
            
    }
}
