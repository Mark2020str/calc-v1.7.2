using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);   
        }

      

    

     

        
       
    }
}
