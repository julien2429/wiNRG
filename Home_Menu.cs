using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home_Menu : Form
    {
        public Home_Menu()
        {

            InitializeComponent();
            this.CenterToScreen();
            button1.UseVisualStyleBackColor = false;
            button2.UseVisualStyleBackColor = false;
            button3.UseVisualStyleBackColor = false;
            button4.UseVisualStyleBackColor = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            this.DoubleBuffered = true; // Reduce flickering during drawing
        }

        private void Home_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Calendar();
            f.ShowDialog();
            this.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Home();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new IndividualProgress();
            f.ShowDialog();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = false;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.UseVisualStyleBackColor = false;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, Color.Black);
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.UseVisualStyleBackColor = false;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
