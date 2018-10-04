﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Log_In
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(); //Inside the () will go the directory where the database is located at.
            SqlDataAdapter sda = new SqlDataAdapter(); // This will be where you will access the data table.
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if(dt.Rows[0][0] = "1")
            {
                this.Hide();
                MainStudent ss = new MainStudent();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please enter your Username and Password correctly.");
            }
        }
    }
}
