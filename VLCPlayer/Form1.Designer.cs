namespace VLCPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.videoView2 = new LibVLCSharp.WinForms.VideoView();
            this.videoView3 = new LibVLCSharp.WinForms.VideoView();
            this.videoView4 = new LibVLCSharp.WinForms.VideoView();
            this.videoView5 = new LibVLCSharp.WinForms.VideoView();
            this.videoView6 = new LibVLCSharp.WinForms.VideoView();
            this.videoView7 = new LibVLCSharp.WinForms.VideoView();
            this.videoView8 = new LibVLCSharp.WinForms.VideoView();
            this.videoView9 = new LibVLCSharp.WinForms.VideoView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView9)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.videoView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.videoView6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.videoView7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 441);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(3, 3);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(228, 121);
            this.videoView1.TabIndex = 0;
            this.videoView1.Text = "videoView1";
            // 
            // videoView2
            // 
            this.videoView2.BackColor = System.Drawing.Color.Black;
            this.videoView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView2.Location = new System.Drawing.Point(237, 3);
            this.videoView2.MediaPlayer = null;
            this.videoView2.Name = "videoView2";
            this.videoView2.Size = new System.Drawing.Size(228, 121);
            this.videoView2.TabIndex = 1;
            this.videoView2.Text = "videoView2";
            // 
            // videoView3
            // 
            this.videoView3.BackColor = System.Drawing.Color.Black;
            this.videoView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView3.Location = new System.Drawing.Point(3, 150);
            this.videoView3.MediaPlayer = null;
            this.videoView3.Name = "videoView3";
            this.videoView3.Size = new System.Drawing.Size(228, 121);
            this.videoView3.TabIndex = 2;
            this.videoView3.Text = "videoView3";
            // 
            // videoView4
            // 
            this.videoView4.BackColor = System.Drawing.Color.Black;
            this.videoView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView4.Location = new System.Drawing.Point(237, 150);
            this.videoView4.MediaPlayer = null;
            this.videoView4.Name = "videoView4";
            this.videoView4.Size = new System.Drawing.Size(228, 121);
            this.videoView4.TabIndex = 3;
            this.videoView4.Text = "videoView4";
            // 
            // videoView5
            // 
            this.videoView5.BackColor = System.Drawing.Color.Black;
            this.videoView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView5.Location = new System.Drawing.Point(3, 297);
            this.videoView5.MediaPlayer = null;
            this.videoView5.Name = "videoView5";
            this.videoView5.Size = new System.Drawing.Size(228, 121);
            this.videoView5.TabIndex = 4;
            this.videoView5.Text = "videoView5";
            // 
            // videoView6
            // 
            this.videoView6.BackColor = System.Drawing.Color.Black;
            this.videoView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView6.Location = new System.Drawing.Point(237, 297);
            this.videoView6.MediaPlayer = null;
            this.videoView6.Name = "videoView6";
            this.videoView6.Size = new System.Drawing.Size(228, 121);
            this.videoView6.TabIndex = 5;
            this.videoView6.Text = "videoView6";
            // 
            // videoView7
            // 
            this.videoView7.BackColor = System.Drawing.Color.Black;
            this.videoView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView7.Location = new System.Drawing.Point(471, 3);
            this.videoView7.MediaPlayer = null;
            this.videoView7.Name = "videoView7";
            this.videoView7.Size = new System.Drawing.Size(230, 121);
            this.videoView7.TabIndex = 6;
            this.videoView7.Text = "videoView7";
            // 
            // videoView8
            // 
            this.videoView8.BackColor = System.Drawing.Color.Black;
            this.videoView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView8.Location = new System.Drawing.Point(471, 150);
            this.videoView8.MediaPlayer = null;
            this.videoView8.Name = "videoView8";
            this.videoView8.Size = new System.Drawing.Size(230, 121);
            this.videoView8.TabIndex = 7;
            this.videoView8.Text = "videoView8";
            // 
            // videoView9
            // 
            this.videoView9.BackColor = System.Drawing.Color.Black;
            this.videoView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView9.Location = new System.Drawing.Point(471, 297);
            this.videoView9.MediaPlayer = null;
            this.videoView9.Name = "videoView9";
            this.videoView9.Size = new System.Drawing.Size(230, 121);
            this.videoView9.TabIndex = 8;
            this.videoView9.Text = "videoView9";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 13);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0:00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(237, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 13);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0:00:00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(471, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 13);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0:00:00";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(3, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 13);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "0:00:00";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(237, 277);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(228, 13);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "0:00:00";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(471, 277);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(230, 13);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "0:00:00";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 424);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(228, 13);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "0:00:00";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(237, 424);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(228, 13);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "0:00:00";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(471, 424);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(230, 13);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "0:00:00";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LibVLCSharp.WinForms.VideoView videoView2;
        private LibVLCSharp.WinForms.VideoView videoView3;
        private LibVLCSharp.WinForms.VideoView videoView4;
        private LibVLCSharp.WinForms.VideoView videoView5;
        private LibVLCSharp.WinForms.VideoView videoView6;
        private LibVLCSharp.WinForms.VideoView videoView7;
        private LibVLCSharp.WinForms.VideoView videoView8;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private LibVLCSharp.WinForms.VideoView videoView9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}

