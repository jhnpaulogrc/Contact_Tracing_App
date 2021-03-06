using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Application
{
    public partial class formSubmit : Form
    {
        public formSubmit()
        {
            InitializeComponent();
        }
        private void bttnSubmit_Click(object sender, EventArgs e)
        {
                StreamWriter outputFile;

                String createDate = DateTime.Now.ToLongDateString();

                outputFile = File.AppendText(createDate);
                outputFile.WriteLine("Name: " + txtName.Text);
                outputFile.WriteLine("Age: " + txtAge.Text);
                outputFile.WriteLine("Address: " + txtAddress.Text);
                outputFile.WriteLine("Contact Number: " + txtContactNumber.Text);
                outputFile.WriteLine("Email Address: " + txtEmail.Text);
                outputFile.WriteLine();
                outputFile.WriteLine();
                outputFile.Close();

                MessageBox.Show("Response Submitted!");

                txtName.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                txtContactNumber.Text = "";
                txtEmail.Text = "";
            
        }
        private void bttnView_Click(object sender, EventArgs e)
        {
            var formView = new formView();
            this.Hide();
            formView.Show();
        }
    }
}
