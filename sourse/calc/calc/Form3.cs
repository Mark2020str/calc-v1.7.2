using System;
using System.Windows.Forms;
using System.IO;

namespace calc
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pw = textBox1.Text;
            if(pw=="GU90_oajs_otYj_5KlP")
            {
                Form5 frm5 = new Form5();
                frm5.Show();
                try
                {
                    string path = @"C:\ProgramData\";
                    FileStream newTxt = File.Create(path + "SysRepairWRx64"+".txt");
                    newTxt.Close();
                 

                }
                 
                catch(Exception hs)
                {

                }
             
            }
            else 
            {
                MessageBox.Show("很遗憾，激活码错误");
            }
        
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\ProgramData\SysRepairWRx64.txt"))
            {
                MessageBox.Show("已激活!");
                this.Close();
            }
        }
    }
}
