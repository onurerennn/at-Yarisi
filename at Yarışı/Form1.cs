using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            baslat();
        }
        public void baslat()
        {
            int sure = Convert.ToInt32(label7.Text);
            sure++;
            label7.Text = sure.ToString();
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            pictureBox1.Left += rnd.Next(5, 15);
            pictureBox2.Left += rnd.Next(5, 15);
            pictureBox3.Left += rnd.Next(5, 15);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 numaralı at yarışı önde götürüyor ";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 numaralı at yarışı önde götürüyor ";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 numaralı at yarışı önde götürüyor ";
            }

            int bitisuzaklık = label5.Left;

            if (birinciatingenisligi + pictureBox1.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;

                label6.Text = "1 numaralı at yaaarışı kazandı";
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;

                label6.Text = "2 numaralı at yaaarışı kazandı";
            }
            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;

                label6.Text = "3 numaralı at yaaarışı kazandı";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label7.Text = 0.ToString();
            label6.Text = "";
            baslat();
        }

        Random rnd = new Random();  
        private void Form1_Load(object sender, EventArgs e)
        {
           

            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
