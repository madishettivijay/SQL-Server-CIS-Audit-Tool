namespace BENCHMARK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.scan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UNAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HOST = new System.Windows.Forms.TextBox();
            this.STOP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 91);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Benchmark: ";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Microsoft SQL Server 2008 Benchmark",
            "Microsoft SQL Server 2012 Benchmark",
            "Microsoft SQL Server 2014 Benchmark",
            "Microsoft SQL Server 2016 Benchmark"});
            this.comboBox1.Location = new System.Drawing.Point(151, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(642, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PASSWORD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.scan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.UNAME);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.HOST);
            this.panel2.Controls.Add(this.STOP);
            this.panel2.Location = new System.Drawing.Point(1, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 145);
            this.panel2.TabIndex = 4;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Location = new System.Drawing.Point(440, 91);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(236, 27);
            this.PASSWORD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password: ";
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(682, 51);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(111, 69);
            this.scan.TabIndex = 9;
            this.scan.Text = "SCAN";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.Scan);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hostname or IP: ";
            // 
            // UNAME
            // 
            this.UNAME.Location = new System.Drawing.Point(151, 91);
            this.UNAME.Name = "UNAME";
            this.UNAME.Size = new System.Drawing.Size(181, 27);
            this.UNAME.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username: ";
            // 
            // HOST
            // 
            this.HOST.Location = new System.Drawing.Point(151, 51);
            this.HOST.Name = "HOST";
            this.HOST.Size = new System.Drawing.Size(525, 27);
            this.HOST.TabIndex = 5;
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(682, 51);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(111, 69);
            this.STOP.TabIndex = 10;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.Stop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(804, 404);
            this.dataGridView1.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 651);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(805, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(806, 669);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(824, 716);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(824, 716);
            this.Name = "Form1";
            this.Text = "SQL SERVER BENCHMARK";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox HOST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

