using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceTestApp1.ServiceReference1;

namespace MathServiceTestApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            var loClient = new MathServiceClient();

            Int32 loNum1 = Convert.ToInt32(textBox1.Text.Trim());
            Int32 loNum2 = Convert.ToInt32(textBox2.Text.Trim());

            switch (comboBox1.Text)
            {
                case "Add":
                    textResult.Text = loClient.Add(loNum1, loNum2).ToString();
                    break;
                case "Subtract":
                    textResult.Text = loClient.Subtract(loNum1, loNum2).ToString();
                    break;
                case "Multiply":
                    textResult.Text = loClient.Multiply(loNum1, loNum2).ToString();
                    break;
                case "Divide":
                    textResult.Text = loClient.Divide(loNum1, loNum2).ToString();
                    break;
            }
        }
    }
}
