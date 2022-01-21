using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Day5Demo
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Accept a number n from the user and display all prime numbers between 1 and n
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Jump();

            listBox1.Items.Clear();
            listBox1.Items.Add("Below are all the prime numbers:");
            var n = int.Parse(textBox1.Text);
            for (var i = 1; i <= n; i++)
            {
                var isPrime = true;

                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        if (i == 10)
                            continue;
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    listBox1.Items.Add(i);
            }
        }

        private void Jump()
        {
            MessageBox.Show(@"Hello to Jump");
        }
    }
}
