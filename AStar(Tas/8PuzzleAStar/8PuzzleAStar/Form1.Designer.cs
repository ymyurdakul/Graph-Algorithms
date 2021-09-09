namespace _8PuzzleAStar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnÇöz = new System.Windows.Forms.Button();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtout9 = new System.Windows.Forms.TextBox();
            this.txtout8 = new System.Windows.Forms.TextBox();
            this.txtout7 = new System.Windows.Forms.TextBox();
            this.txtout4 = new System.Windows.Forms.TextBox();
            this.txtout5 = new System.Windows.Forms.TextBox();
            this.txtout6 = new System.Windows.Forms.TextBox();
            this.txtout3 = new System.Windows.Forms.TextBox();
            this.txtOut2 = new System.Windows.Forms.TextBox();
            this.txtOut1 = new System.Windows.Forms.TextBox();
            this.groupBoxGiris = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtUzay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxGiris.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBoxGiris);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(980, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puzzle Giriş/Çıkış";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bilgisiz(Sezgisel olmayan ) arama yötemlerinde program stack over flow veya zaman" +
                " aşımına uğrayabilir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnÇöz);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Location = new System.Drawing.Point(488, 66);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(472, 167);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arama Yöntemi";
            // 
            // btnÇöz
            // 
            this.btnÇöz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇöz.ForeColor = System.Drawing.Color.Black;
            this.btnÇöz.Location = new System.Drawing.Point(256, 133);
            this.btnÇöz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnÇöz.Name = "btnÇöz";
            this.btnÇöz.Size = new System.Drawing.Size(205, 28);
            this.btnÇöz.TabIndex = 2;
            this.btnÇöz.Text = "Çöz";
            this.btnÇöz.UseVisualStyleBackColor = true;
            this.btnÇöz.Click += new System.EventHandler(this.btnÇöz_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(256, 103);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(165, 21);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "Depth Limited Search";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(256, 75);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(201, 21);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.Text = "Iterative Depth Fisrt Search";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(256, 41);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(43, 21);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "A*";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 123);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(137, 21);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "Best Frist Search";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 95);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(159, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Uniform Cost Search";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 66);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(178, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Dfs(Depth First Search)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 38);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(189, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Bfs(Breadth First Search)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boşluk yerine 0 kullan.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtout9);
            this.groupBox3.Controls.Add(this.txtout8);
            this.groupBox3.Controls.Add(this.txtout7);
            this.groupBox3.Controls.Add(this.txtout4);
            this.groupBox3.Controls.Add(this.txtout5);
            this.groupBox3.Controls.Add(this.txtout6);
            this.groupBox3.Controls.Add(this.txtout3);
            this.groupBox3.Controls.Add(this.txtOut2);
            this.groupBox3.Controls.Add(this.txtOut1);
            this.groupBox3.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Location = new System.Drawing.Point(252, 66);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(213, 167);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çıkış";
            // 
            // txtout9
            // 
            this.txtout9.Location = new System.Drawing.Point(137, 103);
            this.txtout9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtout9.Name = "txtout9";
            this.txtout9.Size = new System.Drawing.Size(48, 22);
            this.txtout9.TabIndex = 0;
            this.txtout9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtout8
            // 
            this.txtout8.Location = new System.Drawing.Point(80, 103);
            this.txtout8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtout8.Name = "txtout8";
            this.txtout8.Size = new System.Drawing.Size(48, 22);
            this.txtout8.TabIndex = 0;
            this.txtout8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtout7
            // 
            this.txtout7.Location = new System.Drawing.Point(23, 103);
            this.txtout7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtout7.Name = "txtout7";
            this.txtout7.Size = new System.Drawing.Size(48, 22);
            this.txtout7.TabIndex = 0;
            this.txtout7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtout4
            // 
            this.txtout4.Location = new System.Drawing.Point(23, 71);
            this.txtout4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtout4.Name = "txtout4";
            this.txtout4.Size = new System.Drawing.Size(48, 22);
            this.txtout4.TabIndex = 0;
            this.txtout4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtout5
            // 
            this.txtout5.Location = new System.Drawing.Point(80, 71);
            this.txtout5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtout5.Name = "txtout5";
            this.txtout5.Size = new System.Drawing.Size(48, 22);
            this.txtout5.TabIndex = 0;
            this.txtout5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtout6
            // 
            this.txtout6.Location = new System.Drawing.Point(137, 71);
            this.txtout6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtout6.Name = "txtout6";
            this.txtout6.Size = new System.Drawing.Size(48, 22);
            this.txtout6.TabIndex = 0;
            this.txtout6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtout3
            // 
            this.txtout3.Location = new System.Drawing.Point(137, 39);
            this.txtout3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtout3.Name = "txtout3";
            this.txtout3.Size = new System.Drawing.Size(48, 22);
            this.txtout3.TabIndex = 0;
            this.txtout3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOut2
            // 
            this.txtOut2.Location = new System.Drawing.Point(80, 39);
            this.txtOut2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOut2.Name = "txtOut2";
            this.txtOut2.Size = new System.Drawing.Size(48, 22);
            this.txtOut2.TabIndex = 0;
            this.txtOut2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOut1
            // 
            this.txtOut1.Location = new System.Drawing.Point(23, 39);
            this.txtOut1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOut1.Name = "txtOut1";
            this.txtOut1.Size = new System.Drawing.Size(48, 22);
            this.txtOut1.TabIndex = 0;
            this.txtOut1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.Controls.Add(this.textBox9);
            this.groupBoxGiris.Controls.Add(this.textBox8);
            this.groupBoxGiris.Controls.Add(this.textBox7);
            this.groupBoxGiris.Controls.Add(this.textBox6);
            this.groupBoxGiris.Controls.Add(this.textBox5);
            this.groupBoxGiris.Controls.Add(this.textBox4);
            this.groupBoxGiris.Controls.Add(this.textBox3);
            this.groupBoxGiris.Controls.Add(this.textBox2);
            this.groupBoxGiris.Controls.Add(this.textBox1);
            this.groupBoxGiris.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBoxGiris.Location = new System.Drawing.Point(19, 66);
            this.groupBoxGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGiris.Size = new System.Drawing.Size(213, 167);
            this.groupBoxGiris.TabIndex = 0;
            this.groupBoxGiris.TabStop = false;
            this.groupBoxGiris.Text = "Giriş";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(137, 103);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(48, 22);
            this.textBox9.TabIndex = 0;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(80, 103);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(48, 22);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(23, 103);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(48, 22);
            this.textBox7.TabIndex = 0;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(137, 71);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(48, 22);
            this.textBox6.TabIndex = 0;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 71);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 22);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 74);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 22);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 39);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 22);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtUzay);
            this.groupBox5.Location = new System.Drawing.Point(17, 281);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(979, 201);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Uzay";
            // 
            // txtUzay
            // 
            this.txtUzay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUzay.Location = new System.Drawing.Point(4, 19);
            this.txtUzay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUzay.Multiline = true;
            this.txtUzay.Name = "txtUzay";
            this.txtUzay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUzay.Size = new System.Drawing.Size(971, 178);
            this.txtUzay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1015, 496);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxGiris;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtout9;
        private System.Windows.Forms.TextBox txtout8;
        private System.Windows.Forms.TextBox txtout7;
        private System.Windows.Forms.TextBox txtout4;
        private System.Windows.Forms.TextBox txtout5;
        private System.Windows.Forms.TextBox txtout6;
        private System.Windows.Forms.TextBox txtout3;
        private System.Windows.Forms.TextBox txtOut2;
        private System.Windows.Forms.TextBox txtOut1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtUzay;
        private System.Windows.Forms.Button btnÇöz;
    }
}

