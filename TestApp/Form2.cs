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

namespace TestApp
{
    public partial class Form2 : Form
    {
        public string LogContent { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Close the log file?","", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            this.Close();
            //}
            //else
            //{

            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtLogFile.Text = LogContent;
        }
    }
}
