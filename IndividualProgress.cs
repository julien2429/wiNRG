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
    public partial class IndividualProgress : Form
    {
        public IndividualProgress()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.DoubleBuffered = true; // Reduce flickering during drawing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Home_Menu();
            f.ShowDialog();
            this.Close();
        }

        private void IndividualProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
