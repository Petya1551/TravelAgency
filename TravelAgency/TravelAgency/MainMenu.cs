using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class MainMenu : Form
    {
        bool LightMode = false;

        int currentIndex = 0;
        List<Image> images = new List<Image>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void excursionBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Travel Agency: Dark Mode";
            images.Add(Image.FromFile("Images/hawaiianImage.jpg"));
            images.Add(Image.FromFile("Images/image2.jpg"));
            images.Add(Image.FromFile("Images/image3.jpg"));
            images.Add(Image.FromFile("Images/image4.jpg"));
            images.Add(Image.FromFile("Images/image5.jpg"));
            images.Add(Image.FromFile("Images/image6.jpg"));
            images.Add(Image.FromFile("Images/image7.jpg"));

            pictureBox1.Image = images[currentIndex];
            backgroundTimer.Start();
        }

        private void themeBtn_Click(object sender, EventArgs e)
        {
            LightMode = !LightMode;
            ApplyTheme(this, LightMode);
            this.Text = LightMode ? "Travel Agency: Light Mode" : "Travel Agency: Dark Mode";
        }

        private void ApplyTheme(Control ctrl, bool lightMode)
        {
            if (lightMode)
            {
                themeBtn.Text = "☼";
                ctrl.BackColor = SystemColors.Control;
                ctrl.ForeColor = Color.MidnightBlue;
                panel1.BackColor = Color.MidnightBlue;
            }

            else
            {
                themeBtn.Text = "☾";
                ctrl.BackColor = Color.MidnightBlue;
                ctrl.ForeColor = Color.AliceBlue;
                panel1.BackColor = Color.AliceBlue;
            }

            foreach (Control child in ctrl.Controls)
            {
                ApplyTheme(child, lightMode);
            }
        }

        private void backgroundTimer_Tick(object sender, EventArgs e)
        {
            currentIndex++;

            if (currentIndex >= images.Count)
                currentIndex = 0;

            pictureBox1.Image = images[currentIndex];
        }
    }
}
