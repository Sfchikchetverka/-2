using Курсач_опбд_версия_2.Формы_для_сотрудника;

namespace Курсач_опбд_версия_2
{
    public partial class LoginForm : Form
    {
        private AppDbContext context;
        Hash Hash = new Hash();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            try { 
            User user;
            using (var context = new AppDbContext())
            {
                var phone = PhoneTextBox.Text;
                var password = Hash.GetHashString(PassTextBox.Text);

                user = context.Users.FirstOrDefault(u => u.Phone == phone && u.Password == password);
                if (user != null && user.Role=="User")
                {
                    MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserMainForm mainForm = new UserMainForm(new AppDbContext(), user);
                    Hide();
                    mainForm.ShowDialog();
                    DialogResult dialogResult = MessageBox.Show("Закрыть программу?", "Думай", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        Close();
                    else if (dialogResult == DialogResult.No)
                        Show();
                }
                /////////////////////////////////////////////////////////
                else if (user != null && user.Role=="Staff")
                {
                    MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StaffMainForm mainForm = new StaffMainForm(new AppDbContext(),user);
                    Hide();
                    mainForm.ShowDialog();
                    DialogResult dialogResult = MessageBox.Show("Закрыть программу?", "Думай", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        Close();
                    else if (dialogResult == DialogResult.No)
                        Show();
                }
                /////////////////////////////////////////////////////////
                else if (user != null && user.Role=="Admin")
                {
                    MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainForm mainForm = new AdminMainForm(new AppDbContext());
                    Hide();
                    mainForm.ShowDialog();
                    DialogResult dialogResult = MessageBox.Show("Закрыть программу?", "Думай", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        Close();
                    else if (dialogResult == DialogResult.No)
                        Show();
                }
                else
                {
                    MessageBox.Show("Неправильный номер или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm regForm = new RegForm(new AppDbContext());
            Hide();
            regForm.ShowDialog();
           
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
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