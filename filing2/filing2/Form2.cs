using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace filing2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "File location";
            this.label2.Text = "File name";
            this.button1.Text = "Read";
            this.button2.Text = "File Stream Read";
            this.button3.Text = "File Stream Write";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FILE KO READ KARWANAY KA CODE via stream reader
            string ss = this.textBox1.Text + this.textBox2.Text;
            StreamReader sr = new StreamReader(ss);
            this.textBox3.Text = sr.ReadToEnd();
            sr.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FILE STREAM READ ( FILE KO READ KRWANA VIA FILE STREAM READ0
            string fn = this.textBox1.Text + this.textBox2.Text;
            FileStream fs = new FileStream(fn, FileMode.Open);
            byte[] bb = new byte[100];
            char[] ch = new char[100];
            fs.Read(bb, 0, 100);
            Decoder de = Encoding.UTF8.GetDecoder();
            de.GetChars(bb, 0, bb.Length, ch, 0);
            foreach (char c in ch)
           {
                this.textBox3.Text += c;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        { //FILE STREAM WRITE 
           
            byte[] bb= new byte[100];
            char[] ch = new char[100];
            string fr = this.textBox1.Text + this.textBox2.Text;
            FileStream fw = new FileStream(fr, FileMode.OpenOrCreate);
            ch = textBox3.Text.ToCharArray();
            Encoder en = Encoding.UTF8.GetEncoder();
            en.GetBytes(ch, 0, ch.Length, bb, 0, true);
            fw.Write(bb, 0, bb.Length);
            
                MessageBox.Show("File has written");
            



            


             



        }
    }
}
