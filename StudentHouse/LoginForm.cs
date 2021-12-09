using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHouse
{
    public partial class LoginForm : Form
    {
        public int idCount = 0000;
        public List<Person> Persons = new List<Person>();

        public LoginForm()
        {
            InitializeComponent();

            lblUnsuccessfulLogin1.Hide();
            lblUnsuccessfulLogin2.Hide();

            DateTime date = DateTime.Now;

            Person admin = new Person();
            admin.AddPerson("Admin", "-", "admin", "-", "-", "Admin", "12345", date);
            Persons.Add(admin);
            admin.PersonID = 0000;

            Person saandreev = new Person();
            saandreev.AddPerson("Svetlin", "Andreev", "saandreev", "Boschdijk 454 5622 PC, Eindhoven, Nederland", "4", "Tenant", "12345", date);
            Persons.Add(saandreev);
            saandreev.PersonID = 0001;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (person.LoginPerson(tbxName.Text, tbxKey.Text, Persons))
            {
                person = person.GetPerson(tbxName.Text, Persons);

                MainForm mainForm = new MainForm(person);

                this.Hide();
                mainForm.ShowDialog();
                this.Show();

                tbxName.Text = "Username";
                tbxKey.UseSystemPasswordChar = false;
                tbxKey.Text = "Password";

                lblUnsuccessfulLogin1.Hide();
                lblUnsuccessfulLogin2.Hide();

            }
            else
            {
                lblUnsuccessfulLogin1.Show();
                lblUnsuccessfulLogin2.Show();
            }
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            if (tbxName.Text == "Username")
            {
                tbxName.Text = "";
            }
        }

        private void tbxName_Leave(object sender, EventArgs e)
        {
            if (tbxName.Text == "")
            {
                tbxName.Text = "Username";
            }
        }


        private void tbxKey_Enter(object sender, EventArgs e)
        {
            if (tbxKey.Text == "Password")
            {
                tbxKey.Text = "";
                tbxKey.UseSystemPasswordChar = true;
            }
        }

        private void tbxKey_Leave(object sender, EventArgs e)
        {
            if (tbxKey.Text == "")
            {
                tbxKey.Text = "Password";
                tbxKey.UseSystemPasswordChar = false;
            }
        }
    }
}
