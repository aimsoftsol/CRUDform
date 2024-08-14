﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OUEVVGU\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ut values(@id,@name,@age)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successefully Saved");

        }

        private void button2_Click(object sender, EventArgs e)

        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OUEVVGU\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update ut set name=@name, age=@age where id=@id", con);

            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successefully Updated");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OUEVVGU\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ut where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successefully Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OUEVVGU\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ut", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
