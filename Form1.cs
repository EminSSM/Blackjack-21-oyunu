using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blakjack_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayaç = 0;
        int artıs = 0;
        int oyuncupuan = 0;
        int pcpuan = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            button2.Enabled = false;
            button1.Enabled = true;
            artıs++;
            if (artıs == 1)
            {
                int b1, b2, toplam;
                b1 = rastgele.Next(1, 11);
                b2 = rastgele.Next(1, 11);
                label5.Text = b1.ToString();
                label6.Text = b2.ToString();
                toplam = b1 + b2;
                label12.Text = toplam.ToString();
            }

            if (artıs == 2)
            {
                int b3, toplam;
                b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();
                toplam = Convert.ToInt32(label5.Text) + Convert.ToInt32(label6.Text) + b3;
                label12.Text = toplam.ToString();

            }
            if (artıs == 3)
            {
                int b4, toplam;
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();
                toplam = Convert.ToInt32(label5.Text) + Convert.ToInt32(label6.Text) + Convert.ToInt32(label7.Text) + b4;
                label12.Text = toplam.ToString();

            }
            if (label5.Text == "1")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
            }
            if (label5.Text == "2")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
            }
            if (label5.Text == "3")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
            }
            if (label5.Text == "4")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
            }
            if (label5.Text == "5")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
            }
            if (label5.Text == "6")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
            }
            if (label5.Text == "7")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
            }
            if (label5.Text == "8")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
            }
            if (label5.Text == "9")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
            }
            if (label5.Text == "10")
            {
                pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
            }
            if (label6.Text == "1")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
            }
            if (label6.Text == "2")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
            }
            if (label6.Text == "3")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
            }
            if (label6.Text == "4")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
            }
            if (label6.Text == "5")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
            }
            if (label6.Text == "6")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
            }
            if (label6.Text == "7")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
            }
            if (label6.Text == "8")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
            }
            if (label6.Text == "9")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
            }
            if (label6.Text == "10")
            {
                pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
            }
            if (label7.Text == "1")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
            }
            if (label7.Text == "2")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
            }
            if (label7.Text == "3")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
            }
            if (label7.Text == "4")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
            }
            if (label7.Text == "5")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
            }
            if (label7.Text == "6")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
            }
            if (label7.Text == "7")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
            }
            if (label7.Text == "8")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
            }
            if (label7.Text == "9")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
            }
            if (label7.Text == "10")
            {
                pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
            }
            if (label8.Text == "1")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
            }
            if (label8.Text == "2")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
            }
            if (label8.Text == "3")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
            }
            if (label8.Text == "4")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
            }
            if (label8.Text == "5")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
            }
            if (label8.Text == "6")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
            }
            if (label8.Text == "7")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
            }
            if (label8.Text == "8")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
            }
            if (label8.Text == "9")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
            }
            if (label8.Text == "10")
            {
                pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button1.Enabled = false;
                button2.Enabled = true;
                sayaç++;
                if (sayaç == 1)
                {
                    int a1, a2, toplam;
                    a1 = rastgele.Next(1, 11);
                    a2 = rastgele.Next(1, 11);
                    toplam = a2 + a1;
                    label1.Text = a1.ToString();
                    label2.Text = a2.ToString();
                    label11.Text = toplam.ToString();
                }
                if (sayaç == 2)
                {
                    int a3, toplam;
                    a3 = rastgele.Next(1, 11);
                    label3.Text = a3.ToString();
                    toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                    label11.Text = toplam.ToString();
                }
                if (sayaç == 3)
                {
                    int a4, toplam;
                    a4 = rastgele.Next(1, 11);
                    label4.Text = a4.ToString();
                    toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                    label11.Text = toplam.ToString();
                }
                if (label1.Text == "1")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
                }
                if (label1.Text == "2")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
                }
                if (label1.Text == "3")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
                }
                if (label1.Text == "4")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
                }
                if (label1.Text == "5")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
                }
                if (label1.Text == "6")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
                }
                if (label1.Text == "7")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
                }
                if (label1.Text == "8")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
                }
                if (label1.Text == "9")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
                }
                if (label1.Text == "10")
                {
                    pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
                }
                if (label2.Text == "1")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
                }
                if (label2.Text == "2")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
                }
                if (label2.Text == "3")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
                }
                if (label2.Text == "4")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
                }
                if (label2.Text == "5")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
                }
                if (label2.Text == "6")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
                }
                if (label2.Text == "7")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
                }
                if (label2.Text == "8")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
                }
                if (label2.Text == "9")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
                }
                if (label2.Text == "10")
                {
                    pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
                }
                if (label3.Text == "1")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
                }
                if (label3.Text == "2")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
                }
                if (label3.Text == "3")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
                }
                if (label3.Text == "4")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
                }
                if (label3.Text == "5")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
                }
                if (label3.Text == "6")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
                }
                if (label3.Text == "7")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
                }
                if (label3.Text == "8")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
                }
                if (label3.Text == "9")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
                }
                if (label3.Text == "10")
                {
                    pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
                }
                if (label4.Text == "1")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\1.png";
                }
                if (label4.Text == "2")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\2.png";
                }
                if (label4.Text == "3")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\3.png";
                }
                if (label4.Text == "4")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\4.png";
                }
                if (label4.Text == "5")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\5.jpg";
                }
                if (label4.Text == "6")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\6.png";
                }
                if (label4.Text == "7")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\7.jpg";
                }
                if (label4.Text == "8")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\8.jpg";
                }
                if (label4.Text == "9")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\9.jpg";
                }
                if (label4.Text == "10")
                {
                    pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\10.jpg";
                }

            }

            //private void button3_Click(object sender, EventArgs e)
            //{
              

            //}

            //private void button4_Click(object sender, EventArgs e)
            //{
              

            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button3.Enabled = true;
            int oyuncutoplam, pctoplam;
            oyuncutoplam = Convert.ToInt32(label11.Text);
            pctoplam = Convert.ToInt32(label12.Text);
            if (oyuncutoplam <= 21 && oyuncutoplam > pctoplam)
            {
                oyuncupuan += 10;
                skroyuncu.Text = oyuncupuan.ToString();

            }
            if (pctoplam <= 21 && pctoplam > oyuncutoplam)
            {
                pcpuan += 10;
                skrpc.Text = pcpuan.ToString();
            }
            if (pctoplam > 21 && oyuncupuan > 21)
            {
                MessageBox.Show("Değerler büyük!!");
            }
            if (pctoplam == oyuncutoplam && pctoplam <= 21 && oyuncutoplam <= 21)
            {
                oyuncupuan += 10;
                pcpuan += 10;
                skroyuncu.Text = oyuncupuan.ToString();
                skrpc.Text = pcpuan.ToString();

            }
            if (oyuncutoplam <= 21 && pctoplam > 21)
            {
                oyuncupuan += 10;

                skroyuncu.Text = oyuncupuan.ToString();
            }
            if (pctoplam <= 21 && oyuncutoplam > 21)
            {
                pcpuan += 10;

                skrpc.Text = pcpuan.ToString();
            }
            if (oyuncupuan == 50)
            {
                MessageBox.Show("Tebrikler Kazandınız!");

            }
            if (pcpuan == 50)
            {
                MessageBox.Show("Kaybettiniz!");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button5.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = true;
            sayaç = 0;
            artıs = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            if (oyuncupuan > pcpuan && oyuncupuan == 50)
            {
                oyuncupuan = 0;
                skroyuncu.Text = "0";
                pcpuan = 0;
                skrpc.Text = "0";


            }
            if (pcpuan > oyuncupuan && pcpuan == 50)
            {
                oyuncupuan = 0;
                skroyuncu.Text = "0";
                pcpuan = 0;
                skrpc.Text = "0";

            }
            pictureBox1.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
            pictureBox2.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
            pictureBox3.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
            pictureBox4.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
            pictureBox5.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
            pictureBox6.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
            pictureBox7.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
            pictureBox8.ImageLocation = "C:\\Users\\casper\\Desktop\\Blackjack\\kapalı1.jpg";
        }
    }
}

    //    private void Form1_Load(object sender, EventArgs e)
    //    {

    //    }

    //    private void pictureBox1_Click(object sender, EventArgs e)
    //    {

    //    }
    //}



//    private void button1_Click(object sender, EventArgs e)


//        }

//    }
//}
