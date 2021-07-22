using System;
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
    public partial class removestudent : Form
    {
        public removestudent()
        {
            InitializeComponent();
        }

        // Firebase Config
        IFirebaseConfig firebaseConnection = new FirebaseConfig()
        {
            // Check https://console.firebase.google.com
            AuthSecret = "DATABASE SECRET",
            BasePath = "DATABASE PATH"

        };
        IFirebaseClient firebaseClient;

        private void button1_Click(object sender, EventArgs e)
        {
            // Search button
            var dbget = firebaseClient.Get("Csharp/Students/" + textBox1.Text);
            StudentDatabase dbread = dbget.ResultAs<StudentDatabase>();
            MessageBox.Show("Student Name: " + dbread.firstname + " " + dbread.middlename + " " + dbread.lastname);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove button
            var dbdelete = firebaseClient.Delete("Csharp/Students/" + textBox1.Text);
            MessageBox.Show("Done!");
        }

        private void removestudent_Load(object sender, EventArgs e)
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
    }
}
