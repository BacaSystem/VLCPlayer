using LibVLCSharp.Shared;
using System;
using System.Windows.Forms;

namespace VLCPlayer
{
    public partial class App : Form
    {
        LibVLC _libVLC;
        MediaPlayer _mp, _mp2, _mp3, _mp4, _mp5, _mp6, _mp7, _mp8, _mp9;

        public App()
        {
            InitializeComponent();
            Core.Initialize();

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

            PlayStream("tcp://127.0.0.1:333");
        }

        void PlayStream(string file)
        {
            _mp.Play(new Media(_libVLC, new Uri(file + "0")));
            _mp2.Play(new Media(_libVLC, new Uri(file + "1")));
            _mp3.Play(new Media(_libVLC, new Uri(file + "2")));
            _mp4.Play(new Media(_libVLC, new Uri(file + "3")));
            _mp5.Play(new Media(_libVLC, new Uri(file + "4")));
            _mp6.Play(new Media(_libVLC, new Uri(file + "5")));
            _mp7.Play(new Media(_libVLC, new Uri(file + "6")));
            _mp8.Play(new Media(_libVLC, new Uri(file + "7")));
            _mp9.Play(new Media(_libVLC, new Uri(file + "8")));
        }
    }
}
