using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filing2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Text = "Stream Reader";
            this.Text = "Filing";
            this.button2.Text = "Stream Writer";
            this.button3.Text = "Read";
            this.button4.Text = "Write";
            this.button5.Text = "File Stream";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fs = new Form2();
            fs.Show();
                
        }
    }
}
