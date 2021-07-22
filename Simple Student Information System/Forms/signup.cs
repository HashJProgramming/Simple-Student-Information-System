﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Simple_Student_Information_System
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        // Firebase Config
        IFirebaseConfig firebaseConnection = new FirebaseConfig()
        {
            // Check https://console.firebase.google.com
            AuthSecret = "LfmNoEXifdcFNXU0eB4xcDxxqdfGXkXpa0WwQszu",
            BasePath = "https://hashjdatabase-default-rtdb.asia-southeast1.firebasedatabase.app/"

        };
        IFirebaseClient firebaseClient;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {
            // Startup 
            try
            {
                firebaseClient = new FireSharp.FirebaseClient(firebaseConnection);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect to the database");
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // User Sign up button
           // NEED TO IMPROVE THE SECURITY - Sorry Can't fix the problem yet i will try find a way later guys HEHE
            if (textBox4.Text == textBox3.Text)
            {
                AdminDatabase db = new AdminDatabase()
                {
                    username = textBox1.Text,
                    password = textBox4.Text,
                    email = textBox2.Text,
                };
                var dbset = firebaseClient.Set("Csharp/Users/" + textBox1.Text, db);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                Hide();
                MessageBox.Show("Done!");

            }
            else
            {
                MessageBox.Show("Confirm your password!");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // User already have account button
            signup Signup = new signup();
            Signup.Close();
        }
    }
}
