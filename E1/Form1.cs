using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button4.Enabled = false;
        }

        abstract class Compo<T>
        {
            public double price;
            public int year;
            public T Article;
            public Compo(double price, int year, T arcticle)
            {
                this.price = price;
                this.year = year;
                Article = arcticle;
            }

            public virtual string Display()
            {
                return $"Цена: {price} \nГод выпуска: {year}";
            }
        }

        class HDD<T> : Compo<T>
        {
            int Turns;
            public int Turn
            {
                get { return Turns; }
                set { Turns = value; }
            }
            string ConnectI;
            public string Connect
            {
                get { return ConnectI; }
                set { ConnectI = value; }
            }
            int Size;
            public int size
            {
                get { return Size; }
                set { Size = value; }
            }
            public HDD(double price, int year, T Art, int Turns, string ConnectI, int Size) : base(price, year, Art)
            {
                Turn = Turns;
                Connect = ConnectI;
                size = Size;
            }
            public override string Display()
            {
                return $"Цена: {price} \n Год выпуска: {year} \n Артикул: {Article}\n Скорость оборотов: {Turn} \n Интерфейс подключения: {Connect} \n Объем: {size} ";
            }
        }

        class GPU<T> : Compo<T>
        {
            double freq;
            string vendor;
            int mem;

            public double Freqq
            {
                get { return freq; }
                set { freq = value; }
            }

            public string Vend
            {
                get { return vendor; }
                set { vendor = value; }
            }

            public int Memo
            {
                get { return mem; }
                set { mem = value; }   
            }

            public GPU(double price, int year, T Art, double freq, string vendor, int mem) : base(price, year, Art)
            {
                Freqq = freq;
                Vend = vendor;
                Memo = mem;
            }

            public override string Display()
            {
                return $"Цена: {price} \n Год выпуска: {year} \n Артикул: {Article}\n Частота: {freq} \n Производитель: {vendor} \n Объем: {mem} ";
            }
        }

        HDD<int> hdd;
        GPU<int> gpu;


        public void ClearTB()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hdd = new HDD<int>(Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(hdd.Display());
            button2.Enabled = false;
            ClearTB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                gpu = new GPU<int>(Convert.ToDouble(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToDouble(textBox10.Text), textBox11.Text, Convert.ToInt32(textBox12.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(gpu.Display());
            button4.Enabled = false;
            ClearTB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2999";
            textBox2.Text = "2022";
            textBox3.Text = "1";
            textBox4.Text = "7200";
            textBox5.Text = "SATA III";
            textBox6.Text = "1000";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = "51499";
            textBox8.Text = "2022";
            textBox9.Text = "1";
            textBox10.Text = "1500";
            textBox11.Text = "Nvidia";
            textBox12.Text = "8";
        }
    }

}
