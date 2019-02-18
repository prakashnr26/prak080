namespace MyWindowsFormsApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdigitalFingerprint = new System.Windows.Forms.Label();
            this.lbdigitalsig = new System.Windows.Forms.Label();
            this.tbdfpvalue = new System.Windows.Forms.TextBox();
            this.tbdsvalue = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbhash = new System.Windows.Forms.Label();
            this.lbthvalue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload certificate here to make transaction in blockchain";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(35, 160);
            this.openfile.Name = "openfile";
            this.openfile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.openfile.Size = new System.Drawing.Size(365, 20);
            this.openfile.TabIndex = 1;
            this.openfile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(400, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(35, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(34, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 41);
            this.label3.TabIndex = 7;
            // 
            // lbdigitalFingerprint
            // 
            this.lbdigitalFingerprint.AutoSize = true;
            this.lbdigitalFingerprint.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdigitalFingerprint.Location = new System.Drawing.Point(32, 259);
            this.lbdigitalFingerprint.Name = "lbdigitalFingerprint";
            this.lbdigitalFingerprint.Size = new System.Drawing.Size(139, 19);
            this.lbdigitalFingerprint.TabIndex = 8;
            this.lbdigitalFingerprint.Text = "Digital Finger Print:";
            // 
            // lbdigitalsig
            // 
            this.lbdigitalsig.AutoSize = true;
            this.lbdigitalsig.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdigitalsig.Location = new System.Drawing.Point(31, 296);
            this.lbdigitalsig.Name = "lbdigitalsig";
            this.lbdigitalsig.Size = new System.Drawing.Size(124, 19);
            this.lbdigitalsig.TabIndex = 9;
            this.lbdigitalsig.Text = "Digital Signature:";
            // 
            // tbdfpvalue
            // 
            this.tbdfpvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdfpvalue.Location = new System.Drawing.Point(171, 259);
            this.tbdfpvalue.Multiline = true;
            this.tbdfpvalue.Name = "tbdfpvalue";
            this.tbdfpvalue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbdfpvalue.Size = new System.Drawing.Size(344, 20);
            this.tbdfpvalue.TabIndex = 12;
            // 
            // tbdsvalue
            // 
            this.tbdsvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdsvalue.Location = new System.Drawing.Point(171, 296);
            this.tbdsvalue.Multiline = true;
            this.tbdsvalue.Name = "tbdsvalue";
            this.tbdsvalue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbdsvalue.Size = new System.Drawing.Size(344, 20);
            this.tbdsvalue.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.linkLabel1.Location = new System.Drawing.Point(35, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(513, 25);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to upload digital finger print and signature to blockchain network.";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbhash
            // 
            this.lbhash.AutoSize = true;
            this.lbhash.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhash.Location = new System.Drawing.Point(37, 469);
            this.lbhash.Name = "lbhash";
            this.lbhash.Size = new System.Drawing.Size(0, 19);
            this.lbhash.TabIndex = 18;
            // 
            // lbthvalue
            // 
            this.lbthvalue.AutoSize = true;
            this.lbthvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthvalue.Location = new System.Drawing.Point(161, 473);
            this.lbthvalue.Name = "lbthvalue";
            this.lbthvalue.Size = new System.Drawing.Size(0, 15);
            this.lbthvalue.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.lbthvalue);
            this.Controls.Add(this.lbhash);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbdsvalue);
            this.Controls.Add(this.tbdfpvalue);
            this.Controls.Add(this.lbdigitalsig);
            this.Controls.Add(this.lbdigitalFingerprint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Upload Certificate Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox openfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbdigitalFingerprint;
        private System.Windows.Forms.Label lbdigitalsig;
        private System.Windows.Forms.TextBox tbdfpvalue;
        private System.Windows.Forms.TextBox tbdsvalue;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbhash;
        private System.Windows.Forms.Label lbthvalue;
    }
}

