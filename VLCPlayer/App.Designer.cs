
namespace VLCPlayer
{
    partial class App
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.protocolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.videoView2 = new LibVLCSharp.WinForms.VideoView();
            this.videoView3 = new LibVLCSharp.WinForms.VideoView();
            this.videoView4 = new LibVLCSharp.WinForms.VideoView();
            this.videoView5 = new LibVLCSharp.WinForms.VideoView();
            this.videoView6 = new LibVLCSharp.WinForms.VideoView();
            this.videoView7 = new LibVLCSharp.WinForms.VideoView();
            this.videoView8 = new LibVLCSharp.WinForms.VideoView();
            this.videoView9 = new LibVLCSharp.WinForms.VideoView();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.videoView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoView4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoView5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoView6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoView7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoView9, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.protocolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // protocolToolStripMenuItem
            // 
            this.protocolToolStripMenuItem.Name = "protocolToolStripMenuItem";
            this.protocolToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.protocolToolStripMenuItem.Text = "Protocol";
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(3, 3);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(260, 135);
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
            this.videoView2.Size = new System.Drawing.Size(260, 135);
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
            this.videoView3.Size = new System.Drawing.Size(262, 135);
            this.videoView3.TabIndex = 2;
            this.videoView3.Text = "videoView3";
            // 
            // videoView4
            // 
            this.videoView4.BackColor = System.Drawing.Color.Black;
            this.videoView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView4.Location = new System.Drawing.Point(3, 144);
            this.videoView4.MediaPlayer = null;
            this.videoView4.Name = "videoView4";
            this.videoView4.Size = new System.Drawing.Size(260, 135);
            this.videoView4.TabIndex = 3;
            this.videoView4.Text = "videoView4";
            // 
            // videoView5
            // 
            this.videoView5.BackColor = System.Drawing.Color.Black;
            this.videoView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView5.Location = new System.Drawing.Point(269, 144);
            this.videoView5.MediaPlayer = null;
            this.videoView5.Name = "videoView5";
            this.videoView5.Size = new System.Drawing.Size(260, 135);
            this.videoView5.TabIndex = 4;
            this.videoView5.Text = "videoView5";
            // 
            // videoView6
            // 
            this.videoView6.BackColor = System.Drawing.Color.Black;
            this.videoView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView6.Location = new System.Drawing.Point(535, 144);
            this.videoView6.MediaPlayer = null;
            this.videoView6.Name = "videoView6";
            this.videoView6.Size = new System.Drawing.Size(262, 135);
            this.videoView6.TabIndex = 5;
            this.videoView6.Text = "videoView6";
            // 
            // videoView7
            // 
            this.videoView7.BackColor = System.Drawing.Color.Black;
            this.videoView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView7.Location = new System.Drawing.Point(3, 285);
            this.videoView7.MediaPlayer = null;
            this.videoView7.Name = "videoView7";
            this.videoView7.Size = new System.Drawing.Size(260, 138);
            this.videoView7.TabIndex = 6;
            this.videoView7.Text = "videoView7";
            // 
            // videoView8
            // 
            this.videoView8.BackColor = System.Drawing.Color.Black;
            this.videoView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView8.Location = new System.Drawing.Point(269, 285);
            this.videoView8.MediaPlayer = null;
            this.videoView8.Name = "videoView8";
            this.videoView8.Size = new System.Drawing.Size(260, 138);
            this.videoView8.TabIndex = 7;
            this.videoView8.Text = "videoView8";
            // 
            // videoView9
            // 
            this.videoView9.BackColor = System.Drawing.Color.Black;
            this.videoView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView9.Location = new System.Drawing.Point(535, 285);
            this.videoView9.MediaPlayer = null;
            this.videoView9.Name = "videoView9";
            this.videoView9.Size = new System.Drawing.Size(262, 138);
            this.videoView9.TabIndex = 8;
            this.videoView9.Text = "videoView9";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.Text = "Application";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem protocolToolStripMenuItem;
    }
}