using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Number_String_Conversion
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
        }
        
        private void frmConvert_Load(object sender, EventArgs e)
        {
            rdoN2S.Checked = true;

            
         
        }

        private void btnCovert_Click(object sender, EventArgs e)
        {
            if (rdoN2S.Checked) //If Number to String
            {

                txtOutput.Text = numberToString.convertStringToNumberWords( txtInput.Text );
               
                
            }
            else //If String to Number
            {
                long setVal = stringToNumber.wordsToNumber(txtInput.Text);
                MessageBox.Show(Convert.ToString(setVal));
                


            }
        }
        
        private void rdoN2S_CheckedChanged(object sender, EventArgs e)
        {
            lblInput.Text = "String:";
            lblOutput.Text = "Number:";
        }

        private void rdoS2N_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "String:";
            lblInput.Text = "Number:";
        }

        private void btnTestOutput_Click(object sender, EventArgs e)
        {
            
            for (long i = 0; i< 9223372036854775806; i++)
            {
                string numberInWords = numberToString.convertStringToNumberWords(Convert.ToString(i));
                if (stringToNumber.wordsToNumber(numberInWords) != i)
                {
                    Console.WriteLine("Error at: " + i);
                }
                
            }
            Console.WriteLine("Test Completed!");
            
        }
    }
}
