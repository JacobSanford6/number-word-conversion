
namespace Number_String_Conversion
{
    partial class frmConvert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCovert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoS2N = new System.Windows.Forms.RadioButton();
            this.rdoN2S = new System.Windows.Forms.RadioButton();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCovert
            // 
            this.btnCovert.Location = new System.Drawing.Point(127, 293);
            this.btnCovert.Name = "btnCovert";
            this.btnCovert.Size = new System.Drawing.Size(141, 23);
            this.btnCovert.TabIndex = 0;
            this.btnCovert.Text = "&Convert";
            this.btnCovert.UseVisualStyleBackColor = true;
            this.btnCovert.Click += new System.EventHandler(this.btnCovert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoS2N);
            this.groupBox1.Controls.Add(this.rdoN2S);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(20, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Type";
            // 
            // rdoS2N
            // 
            this.rdoS2N.AutoSize = true;
            this.rdoS2N.Location = new System.Drawing.Point(197, 19);
            this.rdoS2N.Name = "rdoS2N";
            this.rdoS2N.Size = new System.Drawing.Size(104, 17);
            this.rdoS2N.TabIndex = 1;
            this.rdoS2N.TabStop = true;
            this.rdoS2N.Text = "String to Number";
            this.rdoS2N.UseVisualStyleBackColor = true;
            this.rdoS2N.CheckedChanged += new System.EventHandler(this.rdoS2N_CheckedChanged);
            // 
            // rdoN2S
            // 
            this.rdoN2S.AutoSize = true;
            this.rdoN2S.Location = new System.Drawing.Point(37, 19);
            this.rdoN2S.Name = "rdoN2S";
            this.rdoN2S.Size = new System.Drawing.Size(104, 17);
            this.rdoN2S.TabIndex = 0;
            this.rdoN2S.TabStop = true;
            this.rdoN2S.Text = "Number to String";
            this.rdoN2S.UseVisualStyleBackColor = true;
            this.rdoN2S.CheckedChanged += new System.EventHandler(this.rdoN2S_CheckedChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInput.Location = new System.Drawing.Point(14, 108);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(47, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Number:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOutput.Location = new System.Drawing.Point(14, 166);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(37, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "String:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(75, 108);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(281, 20);
            this.txtInput.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOutput.Location = new System.Drawing.Point(75, 166);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(281, 121);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(368, 328);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCovert);
            this.Name = "frmConvert";
            this.Text = "Number Words";
            this.Load += new System.EventHandler(this.frmConvert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCovert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RadioButton rdoS2N;
        private System.Windows.Forms.RadioButton rdoN2S;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

