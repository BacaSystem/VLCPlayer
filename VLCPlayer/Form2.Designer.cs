
namespace VLCPlayer
{
    partial class Form2
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
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rTMPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullToolStripMenuItem,
            this.cascadeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCPToolStripMenuItem1,
            this.uDPToolStripMenuItem1,
            this.rTPToolStripMenuItem,
            this.rTMPToolStripMenuItem,
            this.hLSToolStripMenuItem});
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.fullToolStripMenuItem.Text = "Full";
            // 
            // tCPToolStripMenuItem1
            // 
            this.tCPToolStripMenuItem1.Name = "tCPToolStripMenuItem1";
            this.tCPToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.tCPToolStripMenuItem1.Text = "TCP";
            this.tCPToolStripMenuItem1.Click += new System.EventHandler(this.tCPToolStripMenuItem1_Click);
            // 
            // uDPToolStripMenuItem1
            // 
            this.uDPToolStripMenuItem1.Name = "uDPToolStripMenuItem1";
            this.uDPToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.uDPToolStripMenuItem1.Text = "UDP";
            this.uDPToolStripMenuItem1.Click += new System.EventHandler(this.uDPToolStripMenuItem1_Click);
            // 
            // rTPToolStripMenuItem
            // 
            this.rTPToolStripMenuItem.Name = "rTPToolStripMenuItem";
            this.rTPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.rTPToolStripMenuItem.Text = "RTP";
            this.rTPToolStripMenuItem.Click += new System.EventHandler(this.rTPToolStripMenuItem_Click);
            // 
            // rTMPToolStripMenuItem
            // 
            this.rTMPToolStripMenuItem.Name = "rTMPToolStripMenuItem";
            this.rTMPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.rTMPToolStripMenuItem.Text = "RTMP";
            this.rTMPToolStripMenuItem.Click += new System.EventHandler(this.rTMPToolStripMenuItem_Click);
            // 
            // hLSToolStripMenuItem
            // 
            this.hLSToolStripMenuItem.Name = "hLSToolStripMenuItem";
            this.hLSToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.hLSToolStripMenuItem.Text = "SRT";
            this.hLSToolStripMenuItem.Click += new System.EventHandler(this.hLSToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCPToolStripMenuItem,
            this.uDPToolStripMenuItem,
            this.rTPToolStripMenuItem1,
            this.rTMPToolStripMenuItem1,
            this.sRTToolStripMenuItem});
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // tCPToolStripMenuItem
            // 
            this.tCPToolStripMenuItem.Name = "tCPToolStripMenuItem";
            this.tCPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.tCPToolStripMenuItem.Text = "TCP";
            // 
            // uDPToolStripMenuItem
            // 
            this.uDPToolStripMenuItem.Name = "uDPToolStripMenuItem";
            this.uDPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.uDPToolStripMenuItem.Text = "UDP";
            // 
            // rTPToolStripMenuItem1
            // 
            this.rTPToolStripMenuItem1.Name = "rTPToolStripMenuItem1";
            this.rTPToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.rTPToolStripMenuItem1.Text = "RTP";
            // 
            // rTMPToolStripMenuItem1
            // 
            this.rTMPToolStripMenuItem1.Name = "rTMPToolStripMenuItem1";
            this.rTMPToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.rTMPToolStripMenuItem1.Text = "RTMP";
            // 
            // sRTToolStripMenuItem
            // 
            this.sRTToolStripMenuItem.Name = "sRTToolStripMenuItem";
            this.sRTToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sRTToolStripMenuItem.Text = "SRT";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(794, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0:00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(3, 3);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(794, 400);
            this.videoView1.TabIndex = 1;
            this.videoView1.Text = "videoView1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uDPToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private System.Windows.Forms.ToolStripMenuItem rTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rTMPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sRTToolStripMenuItem;
    }
}