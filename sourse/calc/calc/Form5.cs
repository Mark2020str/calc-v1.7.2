using System;
using System.Windows.Forms;
using System.Threading;

namespace calc
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }

      
    }
}
