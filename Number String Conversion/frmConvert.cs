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
            txtInput.Focus();
            
         
        }

        private void btnCovert_Click(object sender, EventArgs e)
        {
            if (rdoN2S.Checked) //If Number to String
            {
               
                txtOutput.Text = numberToString.Convert( txtInput.Text );
               
                
            }
            else //If String to Number
            {
                long setVal = stringToNumber.Convert(txtInput.Text);
                txtOutput.Text = Convert.ToString(setVal);
                


            }
            txtInput.Focus();
            txtInput.SelectAll();
        }
        
        private void rdoN2S_CheckedChanged(object sender, EventArgs e)
        {
            lblInput.Text = "String:";
            lblOutput.Text = "Number:";
            txtInput.Focus();
        }

        private void rdoS2N_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "String:";
            lblInput.Text = "Number:";
            txtInput.Focus();
        }

        
    }
}
