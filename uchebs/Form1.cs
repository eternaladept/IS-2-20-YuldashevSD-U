using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uchebs
{
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

    HDD<int> hdd;


    public void Show(string p)
    {
        listBox1.Items.Add(p);
    }

    public void ClearTB()
    {
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        textBox4.Text = "";
        textBox5.Text = "";
        textBox6.Text = "";
    }

    public Task1()
    {
        InitializeComponent();
    }

    private void Task1_Load(object sender, EventArgs e)
    {
        button2.Enabled = false;
        button3.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            hdd = new HDD<int>(Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        button2.Enabled = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        listBox1.Items.Add(hdd.Display());
        button2.Enabled = false;
        ClearTB();
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
