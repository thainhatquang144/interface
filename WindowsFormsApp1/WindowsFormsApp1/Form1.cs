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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            String inValue;
            double purchaseAnt, percent, ans;
            inValue = textBox1.Text;
            purchaseAnt = Int32.Parse(inValue);
            inValue = label1.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1);
            percent = double.Parse(inValue) / 100;
            percent =
                (double.Parse(label3.Text.Remove(label3.Text.Length - 1, 1))) / 100;
            ans = (purchaseAnt + percent) + purchaseAnt;
            string.Format("0:C", ans.ToString());
        }
    }
}
