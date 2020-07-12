using System;

using System.Linq;
using System. IO;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace calc
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

    

        bool add=false, sub=false, mul=false, devide=false,c=false;
        double num,num1,num2,num3,result;
      

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string a = "1";
         
            textBox1.Text = s+a;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s2 = textBox1.Text;
            string b = "2";
        
            textBox1.Text =s2+ b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s3 = textBox1.Text;
            string c = "3";
            
            textBox1.Text =s3+ c;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s4 = textBox1.Text;
            string d = "4";
            
            textBox1.Text = s4+d;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s5 = textBox1.Text;
            string f = "5";
            
            textBox1.Text =s5+ f;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s5 = textBox1.Text;
            string g = "6";
        
            textBox1.Text = s5+g;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s6 = textBox1.Text;
            string t = "7";
            
            textBox1.Text =s6+ t;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s7 = textBox1.Text;
            string p = "8";

            textBox1.Text = s7 + p;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s8 = textBox1.Text;
            string q = "9";

            textBox1.Text = s8 + q;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string add1 = textBox1.Text;
            label1.Text = add1 + "+";
            num = Convert.ToDouble(add1);
            add = true;
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sub1 = textBox1.Text;
            label1.Text = sub1 + "-";
            num1 = Convert.ToDouble(sub1);
            sub = true;
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string mul1 = textBox1.Text;
            label1.Text = mul1 + "x";
             num2 = Convert.ToDouble(mul1);
            mul = true;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string dev1 = textBox1.Text;
            label1.Text = dev1 + "÷";
            num3 = Convert.ToDouble(dev1);
            devide = true;
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string s9 = textBox1.Text;
            string q = ".";

            textBox1.Text = s9 + q;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string squ = textBox1.Text;
            double square = Convert.ToDouble(squ);
            double re=square*square;
            string last = Convert.ToString(re);
            textBox1.Clear();
            textBox1.Text = last;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string squ = textBox1.Text;
            double square = Convert.ToDouble(squ);
            double re = square * square*square;
            string last = Convert.ToString(re);
            textBox1.Clear();
            textBox1.Text = last;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string te = textBox1.Text;
      
            if(add==true)
            {
                double add2= Convert.ToDouble(te);
                result = add2 + num;
               string suc1 = Convert.ToString(result);
                textBox1.Text = suc1;
                label1.Text = "";
            }
            if(sub==true)
            {

                double sub2 = Convert.ToDouble(te);
                result = num1-sub2;
                string suc2 = Convert.ToString(result);
                textBox1.Text = suc2;
                label1.Text = "";
            }
            if(mul==true)
            {
              
                double mul2 = Convert.ToDouble(te);
                if (mul2 == 0)
                {
                    MessageBox.Show("除数不能为0!");
                    textBox1.Clear();
                    return;
                }
                result = mul2 * num2;
               string suc3 = Convert.ToString(result);
                textBox1.Text = suc3;
                label1.Text = "";
            }
            if(devide==true)
            {
                double dev2 = Convert.ToDouble(te);
                result =  num3 / dev2;
                string suc4 = Convert.ToString(result);
                textBox1.Text = suc4;
                label1.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
        
                string fu = textBox1.Text;
                double sp = Convert.ToDouble(fu);
                double r = -sp;
                string l = Convert.ToString(r);
                textBox1.Text = l;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string s10= textBox1.Text;
            string q = "0";

            textBox1.Text = s10+q;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string ans = "3.14159265358";
            textBox1.Text = ans;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string c1 = textBox1.Text;
            double sp1 = Convert.ToDouble(c1);
            sp1 = sp1 / 100;
            string an = Convert.ToString(sp1);
            textBox1.Text = an;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string c1 = textBox1.Text;
            double sp1 = Convert.ToDouble(c1);
            sp1 = 1 / sp1; ;
            string an = Convert.ToString(sp1);
            textBox1.Text = an;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string c1 = textBox1.Text;
            double sp1 = Convert.ToDouble(c1);
            sp1 = Math.Sqrt(sp1);
            string an = Convert.ToString(sp1);
            textBox1.Text = an;
        }

       

        private void 标准型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fm2 = new Form2();
            fm2.Show();
        }   

        private void 科学型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void 激活程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void 程序版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\ProgramData\SysRepairWRx64.txt"))
            {
                c=true;
            }
            if(c==true)
            {
                panel1.Visible=true;
            }
            else 
            {
                panel1.Visible=false;
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

      

      

        
     

        

        

        

        

      

      

        

      
        

        
        
       
      
      

        

      
                    }
    }

