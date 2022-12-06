using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectDB;

namespace E5
{
    public partial class Form5 : Form
    {
        MySqlConnection conn;
        Connecti connecti = new Connecti("server=chuc.caseum.ru;port=33333;username=st_2_20_29;password=15485706;database=is_2_20_st29_KURS");
        MySqlDataAdapter MySQLDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataTable DT = new DataTable();
        public void GetTable()
        {
            DT.Clear();
            string sqlview = "SELECT * FROM `t_Uchebka_Yuldashev`";
            conn.Open();

            MySQLDA.SelectCommand = new MySqlCommand(sqlview, conn);
            MySQLDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            conn.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;




            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;



            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;



            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string fio = FIO.Text;
                string datetime = DateTime.Text;

                string sql = "INSERT INTO `t_Uchebka_Yuldashev`(fioStud, datetimeStud) VALUES (@f, @dt)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@f", MySqlDbType.VarChar).Value = fio;
                cmd.Parameters.Add("@dt", MySqlDbType.VarChar).Value = datetime;

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Пользователь добавлен");
                else
                    MessageBox.Show("Ошибка добавления");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTable();
        }
    }
}
