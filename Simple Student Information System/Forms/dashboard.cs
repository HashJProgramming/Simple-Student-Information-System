using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Student_Information_System
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Refresh button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add Student button
            addstudent Addstudent = new addstudent();
            Addstudent.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Modify Student button
            modifystudent Modifystudent = new modifystudent();
            Modifystudent.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Remove Student button
            removestudent Removestudent = new removestudent();
            Removestudent.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            signin Signin = new signin();
            Signin.Show();
            Hide();
            // Sign out button
        }
    }
}
