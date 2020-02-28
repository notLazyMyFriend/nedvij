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
    public partial class Form2 : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = nedvij; Integrated Security = True");

        public Form2()
        {
            InitializeComponent();
        }

        private void complex_add_Click(object sender, EventArgs e)
        {
            con.Open();
            Int32.TryParse(complex_addcost.Text, out int res1);
            Int32.TryParse(complex_cost.Text, out int res2);
            var com = new SqlCommand($"INSERT INTO complexes VALUES ('{complex_name.Text}', '{complex_city.Text}', '{complex_status.Text}', {complex_addcost.Text}, {complex_cost.Text} )", con);

            if (res1 >= 0 && res2 >= 0)
            {
                if (complex_status.Text == "План" || complex_status.Text == "Строительство" || complex_status.Text == "Реализация")
                {
                    com.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Нет такого статуса!");
            }    
            else
                MessageBox.Show("Сумма денег не может быть отрицательной!");
            MessageBox.Show("Добавлено");
            con.Close();
            Clear();
        }

        public void Clear()
        {
            complex_name.Clear();
            complex_city.Clear();
            complex_status.Text = "";
            complex_cost.Clear();
            complex_addcost.Clear();
        }
    }
}
