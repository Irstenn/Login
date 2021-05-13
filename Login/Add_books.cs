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

namespace Login
{
    public partial class Add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=lenovo;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");

        public Add_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into books_info values('"+ textBox1.Text +"','"+ textBox2.Text +"','"+ textBox3.Text +"','"+ dateTimePicker1.Text +"',"+ textBox5.Text +","+ textBox6.Text +", '"+textBox6.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("books added successfully...!");
        }
    }
}
