
namespace VLCPlayer
{
    partial class CascadeView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCPToolStripMenuItem,
            this.uDPToolStripMenuItem,
            this.rTMPToolStripMenuItem,
            this.rTSPToolStripMenuItem,
            this.sRTToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.viewToolStripMenuItem.Text = "Protocol";
            // 
            // tCPToolStripMenuItem
            // 
            this.tCPToolStripMenuItem.Name = "tCPToolStripMenuItem";
            this.tCPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.tCPToolStripMenuItem.Text = "TCP";
            this.tCPToolStripMenuItem.Click += new System.EventHandler(this.tCPToolStripMenuItem_Click);
            // 
            // uDPToolStripMenuItem
            // 
            this.uDPToolStripMenuItem.Name = "uDPToolStripMenuItem";
            this.uDPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.uDPToolStripMenuItem.Text = "UDP";
            this.uDPToolStripMenuItem.Click += new System.EventHandler(this.uDPToolStripMenuItem_Click);
            // 
            // rTMPToolStripMenuItem
            // 
            this.rTMPToolStripMenuItem.Name = "rTMPToolStripMenuItem";
            this.rTMPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.rTMPToolStripMenuItem.Text = "RTMP";
            this.rTMPToolStripMenuItem.Click += new System.EventHandler(this.rTMPToolStripMenuItem_Click);
            // 
            // rTSPToolStripMenuItem
            // 
            this.rTSPToolStripMenuItem.Name = "rTSPToolStripMenuItem";
            this.rTSPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.rTSPToolStripMenuItem.Text = "RTSP";
            this.rTSPToolStripMenuItem.Click += new System.EventHandler(this.rTSPToolStripMenuItem_Click);
            // 
            // sRTToolStripMenuItem
            // 
            this.sRTToolStripMenuItem.Name = "sRTToolStripMenuItem";
            this.sRTToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sRTToolStripMenuItem.Text = "SRT";
            this.sRTToolStripMenuItem.Click += new System.EventHandler(this.sRTToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem1,
            this.fullToolStripMenuItem1});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // cascadeToolStripMenuItem1
            // 
            this.cascadeToolStripMenuItem1.Name = "cascadeToolStripMenuItem1";
            this.cascadeToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.cascadeToolStripMenuItem1.Text = "Cascade";
            this.cascadeToolStripMenuItem1.Click += new System.EventHandler(this.cascadeToolStripMenuItem1_Click);
            // 
            // fullToolStripMenuItem1
            // 
            this.fullToolStripMenuItem1.Name = "fullToolStripMenuItem1";
            this.fullToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.fullToolStripMenuItem1.Text = "Full";
            this.fullToolStripMenuItem1.Click += new System.EventHandler(this.fullToolStripMenuItem1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.videoView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.videoView8, 1, 4);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 507);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(3, 3);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(260, 142);
            this.videoView1.TabIndex = 0;
            this.videoView1.Text = "videoView1";
            // 
            // videoView2
            // 
            this.videoView2.BackColor = System.Drawing.Color.Black;
            this.videoView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView2.Location = new System.Drawing.Point(269, 3);
            this.videoView2.MediaPlayer = null;
            this.videoView2.Name = "videoView2";
            this.videoView2.Size = new System.Drawing.Size(260, 142);
            this.videoView2.TabIndex = 1;
            this.videoView2.Text = "videoView2";
            // 
            // videoView3
            // 
            this.videoView3.BackColor = System.Drawing.Color.Black;
            this.videoView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView3.Location = new System.Drawing.Point(535, 3);
            this.videoView3.MediaPlayer = null;
            this.videoView3.Name = "videoView3";
            this.videoView3.Size = new System.Drawing.Size(262, 142);
            this.videoView3.TabIndex = 2;
            this.videoView3.Text = "videoView3";
            // 
            // videoView4
            // 
            this.videoView4.BackColor = System.Drawing.Color.Black;
            this.videoView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView4.Location = new System.Drawing.Point(3, 171);
            this.videoView4.MediaPlayer = null;
            this.videoView4.Name = "videoView4";
            this.videoView4.Size = new System.Drawing.Size(260, 143);
            this.videoView4.TabIndex = 3;
            this.videoView4.Text = "videoView4";
            // 
            // videoView5
            // 
            this.videoView5.BackColor = System.Drawing.Color.Black;
            this.videoView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView5.Location = new System.Drawing.Point(269, 171);
            this.videoView5.MediaPlayer = null;
            this.videoView5.Name = "videoView5";
            this.videoView5.Size = new System.Drawing.Size(260, 143);
            this.videoView5.TabIndex = 4;
            this.videoView5.Text = "videoView5";
            // 
            // videoView6
            // 
            this.videoView6.BackColor = System.Drawing.Color.Black;
            this.videoView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView6.Location = new System.Drawing.Point(535, 171);
            this.videoView6.MediaPlayer = null;
            this.videoView6.Name = "videoView6";
            this.videoView6.Size = new System.Drawing.Size(262, 143);
            this.videoView6.TabIndex = 5;
            this.videoView6.Text = "videoView6";
            // 
            // videoView7
            // 
            this.videoView7.BackColor = System.Drawing.Color.Black;
            this.videoView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView7.Location = new System.Drawing.Point(3, 340);
            this.videoView7.MediaPlayer = null;
            this.videoView7.Name = "videoView7";
            this.videoView7.Size = new System.Drawing.Size(260, 142);
            this.videoView7.TabIndex = 6;
            this.videoView7.Text = "videoView7";
            // 
            // videoView8
            // 
            this.videoView8.BackColor = System.Drawing.Color.Black;
            this.videoView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView8.Location = new System.Drawing.Point(269, 340);
            this.videoView8.MediaPlayer = null;
            this.videoView8.Name = "videoView8";
            this.videoView8.Size = new System.Drawing.Size(260, 142);
            this.videoView8.TabIndex = 7;
            this.videoView8.Text = "videoView8";
            // 
            // videoView9
            // 
            this.videoView9.BackColor = System.Drawing.Color.Black;
            this.videoView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView9.Location = new System.Drawing.Point(535, 340);
            this.videoView9.MediaPlayer = null;
            this.videoView9.Name = "videoView9";
            this.videoView9.Size = new System.Drawing.Size(262, 142);
            this.videoView9.TabIndex = 8;
            this.videoView9.Text = "videoView9";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 13);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0:00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(269, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(260, 13);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0:00:00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(535, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(262, 13);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0:00:00";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(3, 320);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(260, 13);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "0:00:00";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(269, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(260, 13);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "0:00:00";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(535, 320);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(262, 13);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "0:00:00";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 488);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(260, 13);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "0:00:00";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(269, 488);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(260, 13);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "0:00:00";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(535, 488);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(262, 13);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "0:00:00";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CascadeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CascadeView";
            this.Text = "CascadeView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CascadeView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private LibVLCSharp.WinForms.VideoView videoView2;
        private LibVLCSharp.WinForms.VideoView videoView3;
        private LibVLCSharp.WinForms.VideoView videoView4;
        private LibVLCSharp.WinForms.VideoView videoView5;
        private LibVLCSharp.WinForms.VideoView videoView6;
        private LibVLCSharp.WinForms.VideoView videoView7;
        private LibVLCSharp.WinForms.VideoView videoView8;
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
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem1;
    }
}