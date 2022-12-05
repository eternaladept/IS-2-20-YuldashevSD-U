using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using ConnectDB;
using MySql.Data.MySqlClient;

namespace E4
{
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        Connecti connecti = new Connecti("server=chuc.caseum.ru;port=33333;username=st_2_20_29;password=15485706;database=is_2_20_st29_KURS");
        MySqlDataAdapter MySQLDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataTable DT = new DataTable();

        public void GetTable()
        {
            DT.Clear();
            string sqlview = "SELECT t_datatime.id AS `Код`, t_datatime.fio AS `ФИО`, t_datatime.date_of_Birth `Дата рождения`, t_datatime.photoUrl AS `Ссылка на фото` FROM `t_datatime`";
            conn.Open();

            MySQLDA.SelectCommand = new MySqlCommand(sqlview, conn);
            MySQLDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            conn.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = false;



            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;


            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connecti.Connection();
            GetTable();
        }

        void LoadImage(string a)
        {
            var rec = WebRequest.Create(a);
            using (var res = rec.GetResponse())
            using (var stream = res.GetResponseStream())
            pictureBox1.Image = Bitmap.FromStream(stream);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                conn.Open();

                string sql = "SELECT t_datatime.photoUrl AS `Ссылка на фото` FROM `t_datatime` WHERE t_datatime.id =" + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                string pic = cmd.ExecuteScalar().ToString();
                LoadImage(pic);
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}
