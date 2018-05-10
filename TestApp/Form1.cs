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
    public partial class DispenceCountForm : Form
    {
        int AcetaminCount = 0;
        int OxyCotinCount = 0;
        int IbuprofenCount = 0;

        String FileNametime = DateTime.Now.ToString("yyyyMMddHHmm");


        public DispenceCountForm()
        {
            InitializeComponent();
        }

        private void btnAcetamPlus_Click(object sender, EventArgs e)
        {
            AcetaminCount ++;
            //MessageBox.Show("Dispence one Acetaminophen tablet?");
            txtAcetaminCount.Text = AcetaminCount.ToString();

            String ActionTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
            string[] action = { ActionTime + "  Acetaminophen  " + "Previous Count:" +
                    (AcetaminCount - 1) +",  New Count:" + AcetaminCount };

            System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", action);


        }

        private void btnOxyPlus_Click(object sender, EventArgs e)
        {
            OxyCotinCount++;
            txtOxyCotinCount.Text = OxyCotinCount.ToString();

            String ActionTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
            string[] action = { ActionTime + "  OxyCotin       " + "Previous Count:" +
                    (OxyCotinCount - 1) +",  New Count:" + OxyCotinCount };

            System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", action);

        }

        private void btnIbuprPlus_Click(object sender, EventArgs e)
        {
            IbuprofenCount++;
            txtIbuprCount.Text = IbuprofenCount.ToString();

            String ActionTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
            string[] action = { ActionTime + "  Ibuprofen      " + "Previous Count:" +
                    (IbuprofenCount - 1) +",  New Count:" + IbuprofenCount };

            System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", action);

        }


        private void btnViewLogForm_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText(FileNametime + " DrugIncrementTest.log");

            Form2 LogForm = new Form2();
            LogForm.LogContent = content;
            LogForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show("Do you really want to exit?","", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                String EndTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
                string[] end = { EndTime + " EXIT" + "    Acetaminophen:"+AcetaminCount+Environment.NewLine+
                        "                          OxyCotin:     " + OxyCotinCount + Environment.NewLine +
                        "                          Ibuprofen:    " + IbuprofenCount};
                System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", end);


                Environment.Exit(0);
                }
                else
                {
                    
                }
           
            
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to reset all count?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                String ActionTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
                string[] action = { ActionTime + " RESET"+ Environment.NewLine+
                        "                          Acetaminophen:"+AcetaminCount+Environment.NewLine+
                        "                          OxyCotin:     " + OxyCotinCount + Environment.NewLine +
                        "                          Ibuprofen:    " + IbuprofenCount};
                System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", action);

                AcetaminCount = 0;
                OxyCotinCount = 0;
                IbuprofenCount = 0;
                txtAcetaminCount.Text = AcetaminCount.ToString();
                txtOxyCotinCount.Text = OxyCotinCount.ToString();
                txtIbuprCount.Text = IbuprofenCount.ToString();

            }
            else
            {

            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    String EndTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
                    string[] end = { EndTime + " EXIT" + "    Acetaminophen:"+AcetaminCount+Environment.NewLine+
                        "                          OxyCotin:     " + OxyCotinCount + Environment.NewLine +
                        "                          Ibuprofen:    " + IbuprofenCount};
                    System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", end);

                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DispenceCountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIbuprMinus_Click(object sender, EventArgs e)
        {
            if (IbuprofenCount >=1)
            { 
            IbuprofenCount--;
            txtIbuprCount.Text = IbuprofenCount.ToString();

            String ActionTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
            string[] action = { ActionTime + "  Ibuprofen      " + "Previous Count:" +
                    (IbuprofenCount + 1) +",  New Count:" + IbuprofenCount };

            System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", action);
            }
            else
            {

            }
        }

        private void btnAcetamMinus_Click(object sender, EventArgs e)
        {

            if (AcetaminCount >= 1)
            {

            AcetaminCount--;
            txtAcetaminCount.Text = AcetaminCount.ToString();

            String ActionTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
            string[] action = { ActionTime + "  Acetaminophen  " + "Previous Count:" +
                    (AcetaminCount + 1) +",  New Count:" + AcetaminCount };

            System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", action);

            }
            else
            {

            }

        }

        private void btnOxyMinus_Click(object sender, EventArgs e)
        {
            if (OxyCotinCount >=1)
            { 
            OxyCotinCount--;
            txtOxyCotinCount.Text = OxyCotinCount.ToString();

            String ActionTime = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
            string[] action = { ActionTime + "  OxyCotin       " + "Previous Count:" +
                    (OxyCotinCount + 1) +",  New Count:" + OxyCotinCount };

            System.IO.File.AppendAllLines(FileNametime + " DrugIncrementTest.log", action);
            }
            else
            {

            }
        }
    }
    
}
