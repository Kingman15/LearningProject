using LearningProject.View.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningProject
{
    public partial class fForm : Form
    {
        public fForm()
        {
            InitializeComponent();
        }

        private void alimentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new fFoodItem();
            f.Show();
        }
    }
}
