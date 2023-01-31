
namespace VLCPlayer
{
    partial class NormalView
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
            this.tcpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tcpToolStripMenuItem,
            this.uDPToolStripMenuItem,
            this.rTMPToolStripMenuItem,
            this.rTSPToolStripMenuItem,
            this.sRTToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.viewToolStripMenuItem.Text = "Protocol";
            // 
            // tcpToolStripMenuItem
            // 
            this.tcpToolStripMenuItem.Name = "tcpToolStripMenuItem";
            this.tcpToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.tcpToolStripMenuItem.Text = "TCP";
            this.tcpToolStripMenuItem.Click += new System.EventHandler(this.tcpToolStripMenuItem_Click);
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
            this.rTMPToolStripMenuItem.Click += new System.EventHandler(this.rTMPToolStripMenuItem_Click_1);
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
            this.fullToolStripMenuItem1,
            this.cascadeToolStripMenuItem1});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // fullToolStripMenuItem1
            // 
            this.fullToolStripMenuItem1.Name = "fullToolStripMenuItem1";
            this.fullToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.fullToolStripMenuItem1.Text = "Full";
            this.fullToolStripMenuItem1.Click += new System.EventHandler(this.fullToolStripMenuItem1_Click);
            // 
            // cascadeToolStripMenuItem1
            // 
            this.cascadeToolStripMenuItem1.Name = "cascadeToolStripMenuItem1";
            this.cascadeToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.cascadeToolStripMenuItem1.Text = "Cascade";
            this.cascadeToolStripMenuItem1.Click += new System.EventHandler(this.cascadeToolStripMenuItem1_Click);
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
            // NormalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NormalView";
            this.Text = "NormalView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tcpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sRTToolStripMenuItem;
    }
}