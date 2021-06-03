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
    public partial class formView : Form
    {
        public formView()
        {
            InitializeComponent();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            var formSubmit = new formSubmit();
            this.Hide();
            formSubmit.Show();
        }

        private void bttnView_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtResponse.Clear();
                StreamReader inputFile;
                inputFile = File.OpenText(openFileDialog1.FileName);

                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string Enter = "\r\n";
                    txtResponse.Text = txtResponse.Text + line + Enter;
                }
            }
            
        }
    }
}
