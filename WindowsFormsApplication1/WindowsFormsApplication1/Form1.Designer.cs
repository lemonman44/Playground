using System;

namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.send = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.subtractAccount = new System.Windows.Forms.Button();
            this.addAccount = new System.Windows.Forms.Button();
            this.checkAllAccounts = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(290, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Compile/View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Send Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.button2);
            this.Panel1.Controls.Add(this.button1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(137, 119);
            this.Panel1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.send);
            this.Panel2.Controls.Add(this.dataGridView1);
            this.Panel2.Controls.Add(this.button3);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(137, 119);
            this.Panel2.TabIndex = 0;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(100, 0);
            this.send.Margin = new System.Windows.Forms.Padding(2);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(60, 41);
            this.send.TabIndex = 1;
            this.send.Text = "Browse";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27});
            this.dataGridView1.Location = new System.Drawing.Point(808, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(411, 157);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Column20";
            this.Column20.Name = "Column20";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Column21";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Column22";
            this.Column22.Name = "Column22";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Column23";
            this.Column23.Name = "Column23";
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Column24";
            this.Column24.Name = "Column24";
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Column25";
            this.Column25.Name = "Column25";
            // 
            // Column26
            // 
            this.Column26.HeaderText = "Column26";
            this.Column26.Name = "Column26";
            // 
            // Column27
            // 
            this.Column27.HeaderText = "Column27";
            this.Column27.Name = "Column27";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.subtractAccount);
            this.Panel3.Controls.Add(this.addAccount);
            this.Panel3.Controls.Add(this.checkAllAccounts);
            this.Panel3.Controls.Add(this.checkedListBox1);
            this.Panel3.Controls.Add(this.button4);
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(618, 410);
            this.Panel3.TabIndex = 0;
            // 
            // subtractAccount
            // 
            this.subtractAccount.Location = new System.Drawing.Point(410, 142);
            this.subtractAccount.Margin = new System.Windows.Forms.Padding(2);
            this.subtractAccount.Name = "subtractAccount";
            this.subtractAccount.Size = new System.Drawing.Size(38, 12);
            this.subtractAccount.TabIndex = 6;
            this.subtractAccount.Text = "Subtract Account";
            this.subtractAccount.UseVisualStyleBackColor = true;
            this.subtractAccount.Click += new System.EventHandler(this.subtractAccount_Click);
            // 
            // addAccount
            // 
            this.addAccount.Location = new System.Drawing.Point(369, 142);
            this.addAccount.Margin = new System.Windows.Forms.Padding(2);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(38, 12);
            this.addAccount.TabIndex = 5;
            this.addAccount.Text = "Add Account";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // checkAllAccounts
            // 
            this.checkAllAccounts.Location = new System.Drawing.Point(328, 142);
            this.checkAllAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.checkAllAccounts.Name = "checkAllAccounts";
            this.checkAllAccounts.Size = new System.Drawing.Size(38, 12);
            this.checkAllAccounts.TabIndex = 4;
            this.checkAllAccounts.Text = "Select All";
            this.checkAllAccounts.UseVisualStyleBackColor = true;
            this.checkAllAccounts.Click += new System.EventHandler(this.checkAllAccounts_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(328, 157);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(232, 139);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Back2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 386);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(403, 396);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button subtractAccount;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.Button checkAllAccounts;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

