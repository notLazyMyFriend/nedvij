using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nedvij
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = nedvij; Integrated Security = True");
        public int myRow;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            con.Open();

            var com = new SqlCommand("select distinct complexes.Название_ЖК complex_name, " +
                "(select COUNT(houses.id_complex)) houses_count, " +
                "Статус status, " +
                "Город city from complexes, houses where complexes.id = houses.id_complex group by Название_ЖК, Статус, Город", con);

            var reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["complex_name"].ToString(), 
                        reader["status"].ToString(),
                        reader["houses_count"].ToString(),
                        reader["city"].ToString());

                    //проверяем повторение городов
                    if (!city_filter.Items.Contains(reader["city"]))
                    {
                        city_filter.Items.Add(reader["city"]);
                    }
                    
                }
            }

            con.Close();

           
        }

        private void filter_apply_Click(object sender, EventArgs e)
        {
            //"фильтрация"
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (!dgr.IsNewRow)
                {
                    if (dgr.Cells[3].Value.ToString().IndexOf(city_filter.SelectedItem.ToString()) == 0)
                        dgr.Visible = true;
                    else
                        dgr.Visible = false;
                }
            }
        }

        private void filter_clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                dgr.Visible = true;  
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //var con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = nedvij; Integrated Security = True");

            con.Open();
            
            var com = new SqlCommand("delete from houses where Название_ЖК = @name and Статус = @status and Город = @city", con);
            com.Parameters.Add("name", SqlDbType.NVarChar);
            com.Parameters["name"].Value = e.Row.Cells[0].Value.ToString();
            com.Parameters.Add("status", SqlDbType.NVarChar);
            com.Parameters["status"].Value = e.Row.Cells[1].Value.ToString();
            com.Parameters.Add("city", SqlDbType.NVarChar);
            com.Parameters["city"].Value = e.Row.Cells[3].Value.ToString();
            
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("row is deleted");
        }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            myRow = e.RowIndex;
        }

        private void row_delete_click(object sender, EventArgs e)
        {
            con.Open();

            var com = new SqlCommand("delete from houses where Название_ЖК = @name and Статус = @status and Город = @city", con);
            com.Parameters.Add("name", SqlDbType.NVarChar);
            com.Parameters["name"].Value = dataGridView1.Rows[myRow].Cells[0].Value.ToString();
            com.Parameters.Add("status", SqlDbType.NVarChar);
            com.Parameters["status"].Value = dataGridView1.Rows[myRow].Cells[1].Value.ToString();
            com.Parameters.Add("city", SqlDbType.NVarChar);
            com.Parameters["city"].Value = dataGridView1.Rows[myRow].Cells[3].Value.ToString();

            com.ExecuteNonQuery();
            con.Close();
            dataGridView1.Rows.RemoveAt(myRow);
            MessageBox.Show("row is deleted");
        }

        private void row_edit_Click(object sender, EventArgs e)
        {
            //Form f = new Form2();
            //f.Show();
        }

        private void row_add_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }
    }
}
