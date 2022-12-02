using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public string connect = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;";


        public class SQLcon
        {
            public static MySqlConnection GetConnection(MySqlConnection mySql)
            {
                try
                {
                    MessageBox.Show("Подключено!");
                    return mySql;
                }

                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                    return null;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connect);

            try
            {
                SQLcon.GetConnection(conn);
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
    }
}
