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
        public MediaPlayer _mp, _mp2, _mp3, _mp4, _mp5, _mp6, _mp7, _mp8, _mp9;
        public Media media;

        public Form1()
        {
            InitializeComponent();

            Core.Initialize();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ShortcutEvent);

            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            _mp2 = new MediaPlayer(_libVLC);
            _mp3 = new MediaPlayer(_libVLC);
            _mp4 = new MediaPlayer(_libVLC);
            _mp5 = new MediaPlayer(_libVLC);
            _mp6 = new MediaPlayer(_libVLC);
            _mp7 = new MediaPlayer(_libVLC);
            _mp8 = new MediaPlayer(_libVLC);
            _mp9 = new MediaPlayer(_libVLC);

            videoView1.MediaPlayer = _mp;
            videoView2.MediaPlayer = _mp2;
            videoView3.MediaPlayer = _mp3;
            videoView4.MediaPlayer = _mp4;
            videoView5.MediaPlayer = _mp5;
            videoView6.MediaPlayer = _mp6;
            videoView7.MediaPlayer = _mp7;
            videoView8.MediaPlayer = _mp8;
            videoView9.MediaPlayer = _mp9;

            //PlayURI("tcp://127.0.0.1:3333");
            PlayURI("https://www.rmp-streaming.com/media/big-buck-bunny-360p.mp4");
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

            if (e.KeyCode == Keys.J)
                _mp.Position -= .01f;
            if (e.KeyCode == Keys.L)
                _mp.Position += .01f;
        }

        public void PlayFile(string file)
        {
            _mp.Play(new Media(_libVLC, file));
        }

        public void PlayURI(string file)
        {
            _mp.Play(new Media(_libVLC, new Uri(file)));
            _mp2.Play(new Media(_libVLC, new Uri(file)));
            _mp3.Play(new Media(_libVLC, new Uri(file)));
            _mp4.Play(new Media(_libVLC, new Uri(file)));
            _mp5.Play(new Media(_libVLC, new Uri(file)));
            _mp6.Play(new Media(_libVLC, new Uri(file)));
            _mp7.Play(new Media(_libVLC, new Uri(file)));
            _mp8.Play(new Media(_libVLC, new Uri(file)));
            _mp9.Play(new Media(_libVLC, new Uri(file)));
        }
    }
}
