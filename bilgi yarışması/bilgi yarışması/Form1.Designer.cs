namespace bilgi_yarışması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btna = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.lblcevap1 = new System.Windows.Forms.Label();
            this.lblcevap = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblpuandegeri = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsüre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.Color.Gray;
            this.btna.Location = new System.Drawing.Point(88, 286);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(121, 55);
            this.btna.TabIndex = 0;
            this.btna.Text = "a";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.Gray;
            this.btnc.Location = new System.Drawing.Point(88, 369);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(121, 48);
            this.btnc.TabIndex = 1;
            this.btnc.Text = "c";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnb
            // 
            this.btnb.BackColor = System.Drawing.Color.Gray;
            this.btnb.Location = new System.Drawing.Point(295, 286);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(125, 51);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "b";
            this.btnb.UseVisualStyleBackColor = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnd
            // 
            this.btnd.BackColor = System.Drawing.Color.Gray;
            this.btnd.Location = new System.Drawing.Point(295, 369);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(125, 48);
            this.btnd.TabIndex = 3;
            this.btnd.Text = "d";
            this.btnd.UseVisualStyleBackColor = false;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnbaslat
            // 
            this.btnbaslat.BackColor = System.Drawing.Color.Gray;
            this.btnbaslat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbaslat.Location = new System.Drawing.Point(617, 39);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(144, 59);
            this.btnbaslat.TabIndex = 4;
            this.btnbaslat.Text = "BAŞLAT";
            this.btnbaslat.UseVisualStyleBackColor = false;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // lblcevap1
            // 
            this.lblcevap1.AutoSize = true;
            this.lblcevap1.Location = new System.Drawing.Point(577, 321);
            this.lblcevap1.Name = "lblcevap1";
            this.lblcevap1.Size = new System.Drawing.Size(50, 20);
            this.lblcevap1.TabIndex = 6;
            this.lblcevap1.Text = "label2";
            this.lblcevap1.Visible = false;
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Location = new System.Drawing.Point(577, 369);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(50, 20);
            this.lblcevap.TabIndex = 7;
            this.lblcevap.Text = "label3";
            this.lblcevap.Visible = false;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpuan.Location = new System.Drawing.Point(565, 183);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(107, 38);
            this.lblpuan.TabIndex = 8;
            this.lblpuan.Text = "PUAN :";
            // 
            // lblpuandegeri
            // 
            this.lblpuandegeri.AutoSize = true;
            this.lblpuandegeri.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpuandegeri.Location = new System.Drawing.Point(675, 183);
            this.lblpuandegeri.Name = "lblpuandegeri";
            this.lblpuandegeri.Size = new System.Drawing.Size(33, 38);
            this.lblpuandegeri.TabIndex = 9;
            this.lblpuandegeri.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(88, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 177);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 71);
            this.label1.TabIndex = 11;
            this.label1.Text = "BİLGİ YARIŞMASI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsüre.Location = new System.Drawing.Point(659, 233);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(49, 38);
            this.lblsüre.TabIndex = 13;
            this.lblsüre.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(565, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "SÜRE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblpuandegeri);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.lblcevap1);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btna);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btna;
        private Button btnc;
        private Button btnb;
        private Button btnd;
        private Button btnbaslat;
        private Label lblcevap1;
        private Label lblcevap;
        private Label lblpuan;
        private Label lblpuandegeri;
        private RichTextBox richTextBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label lblsüre;
        private Label label3;
    }
}