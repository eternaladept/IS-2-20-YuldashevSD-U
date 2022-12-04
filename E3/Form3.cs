using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static E3.Program;

namespace E3
{
    public partial class Form3 : Form
    {
        Connect connect = new Connect("server=chuc.caseum.ru;port=33333;username=st_2_20_29;password=15485706;database=is_2_20_st29_KURS");
        MySqlConnection conn;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable DT = new DataTable();
        BindingSource BindingS = new BindingSource();

        public void People()
        {
            DT.Clear();
            string table = "SELECT forucheb.id AS `id`, forucheb.name AS `имя`, forucheb.spec AS `профессия` FROM forucheb";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(table, conn);
            MyDA.Fill(DT);
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


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = connect.Conn();
            People();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            conn.Open();
            string i1 = "";
            string i2 = "";
            string i3 = "";
            string sql = $"SELECT forucheb.id AS `id`, forucheb.name AS `имя`, forucheb.spec AS `профессия` FROM forucheb WHERE forucheb.id_forucheb = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i1 = reader[0].ToString();
                i2 = reader[1].ToString();
                i3 = reader[2].ToString();
            }
            reader.Close();
            MessageBox.Show($"id: {i1} имя: {i2} профессия: {i3}");
            conn.Close();
        }
    }
}
