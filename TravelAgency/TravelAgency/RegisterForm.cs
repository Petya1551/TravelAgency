using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgency
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            PersonalInfoLabel.Parent = RegisterPictureBox;
            PersonalInfoLabel.BackColor = Color.Transparent;
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "First Name")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.ForeColor = Color.Black;
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                firstNameTextBox.Text = "First Name";
                firstNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void secondNameTextBox_Enter(object sender, EventArgs e)
        {
            if (secondNameTextBox.Text == "Second Name")
            {
                secondNameTextBox.Text = "";
                secondNameTextBox.ForeColor = Color.Black;
            }
        }

        private void secondNameTextBox_Leave(object sender, EventArgs e)
        {
            if (secondNameTextBox.Text == "")
            {
                secondNameTextBox.Text = "Second Name";
                secondNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Last Name")
            {
                lastNameTextBox.Text = "";
                lastNameTextBox.ForeColor = Color.Black;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "Last Name";
                lastNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void birthdateTextBox_Enter(object sender, EventArgs e)
        {
            if (birthdateTextBox.Text == "MM/DD/YYYY")
            {
                birthdateTextBox.Text = "";
                birthdateTextBox.ForeColor = Color.Black;
            }
        }

        private void birthdateTextBox_Leave(object sender, EventArgs e)
        {
            if (birthdateTextBox.Text == "")
            {
                birthdateTextBox.Text = "MM/DD/YYYY";
                birthdateTextBox.ForeColor = Color.Gray;
            }
        }

        private void egnTextBox_Enter(object sender, EventArgs e)
        {
            if (egnTextBox.Text == "1234567890")
            {
                egnTextBox.Text = "";
                egnTextBox.ForeColor = Color.Black;
            }
        }

        private void egnTextBox_Leave(object sender, EventArgs e)
        {
            if (egnTextBox.Text == "")
            {
                egnTextBox.Text = "1234567890";
                egnTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
