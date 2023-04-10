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

//Jake Sanford
//04/08/2023
//This program allows for the user to convert number values into words
//And words into number values
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
            txtInput.Focus();
        }

        private void btnCovert_Click(object sender, EventArgs e)
        {
            if (rdoN2S.Checked) //If Number to String
            { 
                txtOutput.Text = NumberToWords.Convert(txtInput.Text);
            }
            else //If String to Number
            {
                long setVal = WordsToNumber.Convert(txtInput.Text);
                txtOutput.Text = Convert.ToString(setVal);
            }
            txtInput.Focus();
            txtInput.SelectAll();
        }
        
        private void rdoN2S_CheckedChanged(object sender, EventArgs e)
        {
            lblInput.Text = "Number:";
            lblOutput.Text = "String:";
            txtInput.Focus();
        }

        private void rdoS2N_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "Number:";
            lblInput.Text = "String:";
            txtInput.Focus();
        }
    }
}
