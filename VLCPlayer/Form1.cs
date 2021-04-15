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
        public MediaPlayer _mp, _mp2, _mp3, _mp4;
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
            _mp2 = new MediaPlayer(_libVLC);
            _mp3 = new MediaPlayer(_libVLC);
            _mp4 = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;
            videoView2.MediaPlayer = _mp2;
            videoView3.MediaPlayer = _mp3;
            videoView4.MediaPlayer = _mp4;

            PlayURI("tcp://127.0.0.1:3333");
        }

        public void ShortcutEvent(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //    _mp.Volume += 1;
            //if (e.KeyCode == Keys.Down)
            //    _mp.Volume -= 1;

            //if(isPlaying)
            //{
            //    if(e.KeyCode == Keys.Space)
            //    {
            //        if (_mp.State == VLCState.Playing)
            //            _mp.Pause();
            //        else
            //            _mp.Play();
            //    }
            //}

            //if (e.KeyCode == Keys.J)
            //    _mp.Position -= .01f;
            //if (e.KeyCode == Keys.L)
            //    _mp.Position += .01f;
        }

        public void PlayFile(string file)
        {
            _mp.Play(new Media(_libVLC, file));
            isPlaying = true;
        }

        public void PlayURI(string file)
        {
            _mp.Play(new Media(_libVLC, new Uri(file)));
            _mp2.Play(new Media(_libVLC, new Uri(file)));
            _mp3.Play(new Media(_libVLC, new Uri(file)));
            _mp4.Play(new Media(_libVLC, new Uri(file)));

            isPlaying = true;
        }
    }
}
