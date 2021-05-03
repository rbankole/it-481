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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        string output = "";

        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=DESKTOP-RMMFSO1;Initial Catalog=Northwind;User Id="+ textBox1.Text+";Password="+ textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = @"Data Source = DESKTOP-RMMFSO1;Initial Catalog=Northwind;User Id="+ textBox1.Text+"; Password="+ textBox2.Text;
            cnn = new SqlConnection(connetionString);

            try {
                cnn.Open();
                MessageBox.Show("Login is successful!");
                cnn.Close();
                }
            catch
                {
                MessageBox.Show("Login failed for user " + textBox1.Text);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            try
            {
                cmd.CommandText = "SELECT [ContactName] FROM[Northwind].[dbo].[Customers]";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    output = output + dr.GetValue(0) + "\n";
                }
                MessageBox.Show(output);
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Access to Customers table denied to user " + textBox1.Text);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            try
            {
                cmd.CommandText = "SELECT [LastName] FROM[Northwind].[dbo].[Employees]";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    output = output + dr.GetValue(0) + "\n";
                }
                MessageBox.Show("Employee list are " + output + "\n");
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Access to Employees table denied to user " + textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = @"Data Source = DESKTOP-RMMFSO1;Initial Catalog=Northwind;User Id=" + textBox1.Text + "; Password=" + textBox2.Text;
            cnn = new SqlConnection(connetionString);

            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            try
            {

                cmd.CommandText = "SELECT * FROM[Northwind].[dbo].[Orders]";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    output = output + dr.GetValue(0) + "\n";
                }
                MessageBox.Show(output, "Orders");
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Access to Orders table denied to user " + textBox1.Text);
            }
        }
    }
}
