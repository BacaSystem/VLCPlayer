using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;

namespace VLCPlayer
{
    public partial class Form1 : Form
    {

        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public Media media;

        public bool isFullscreen = false;
        public bool isPlaying = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;

        public Form1()
        {
            InitializeComponent();

            Core.Initialize();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ShortcutEvent);
            oldVideoSize = videoView1.Size;
            oldFormSize = this.Size;
            oldVideoLocation = videoView1.Location;

            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;
        }

        public void ShortcutEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F && !isFullscreen)
            {
                fullscreenToolStripMenuItem_Click(sender, e);
            }

            if(e.KeyCode == Keys.Escape  && isFullscreen)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Size = oldFormSize;

                menuStrip1.Visible = true;
                videoView1.Size = oldVideoSize;
                videoView1.Location = oldVideoLocation;
                isFullscreen = false;
            }

            if(isPlaying)
            {
                if(e.KeyCode == Keys.Space)
                {
                    if (_mp.State == VLCState.Playing)
                        _mp.Pause();
                    else
                        _mp.Play();
                }
            }

            if (e.KeyCode == Keys.J)
                _mp.Position -= .01f;
            if (e.KeyCode == Keys.L)
                _mp.Position += .01f;
        }

        public void PlayFile(string file)
        {
            _mp.Play(new Media(_libVLC, file));
            isPlaying = true;
        }

        public void PlayURI(string file)
        {
            _mp.Play(new Media(_libVLC, new Uri(file)));
            isPlaying = true;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                PlayFile(fd.FileName);
        }

        private void openURIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 url_fd = new Form2();
            url_fd.Show();  
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            videoView1.Size = this.Size;
            videoView1.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            isFullscreen = true;
        }
    }
}
