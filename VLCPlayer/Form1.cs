using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;

namespace VLCPlayer
{
    public partial class Form1 : Form
    {
        const string VIDEO_URL = "tcp://127.0.0.1:333";

        const string TCP_URL = "tcp://127.0.0.1:3333";
        const string UDP_URL = "udp://@127.0.0.1:3333?pkt_size=1024";
        const string RTP_URL = "C:\\Work\\Studia\\inz\\Server\\video.sdp";
        const string RTMP_URL = "rtmp://127.0.0.1:1935";
        const string HLS_URL = "";

        LibVLC _libVLC;
        MediaPlayer _mp, _mp2, _mp3, _mp4, _mp5, _mp6, _mp7, _mp8, _mp9;
        TextBox _txt1, _txt2, _txt3, _txt4, _txt5, _txt6, _txt7, _txt8, _txt9;


        public System.Windows.Forms.Timer startTimer = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer playTimer = new System.Windows.Forms.Timer();

        public Media media;


        public Form1()
        {
            InitializeComponent();

            Core.Initialize();
            this.KeyPreview = true;

            startTimer.Interval = 1000;
            startTimer.Tick += new EventHandler(StartTimerTick);
            playTimer.Interval = 1000;
            playTimer.Tick += new EventHandler(PlayTimerTick);

          

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


            _mp.Mute = true;
            _mp2.Mute = true;
            _mp3.Mute = true;
            _mp4.Mute = true;
            _mp5.Mute = true;
            _mp6.Mute = true;
            _mp7.Mute = true;
            _mp8.Mute = true;
            _mp9.Mute = true;


            videoView1.MediaPlayer = _mp;
            videoView2.MediaPlayer = _mp2;
            videoView3.MediaPlayer = _mp3;
            videoView4.MediaPlayer = _mp4;
            videoView5.MediaPlayer = _mp5;
            videoView6.MediaPlayer = _mp6;
            videoView7.MediaPlayer = _mp7;
            videoView8.MediaPlayer = _mp8;
            videoView9.MediaPlayer = _mp9;

            _mp.TimeChanged += mpTimeChanged;

            //_mp.Media.Statistics.ReadBytes()

            //_mp.Play(new Media(_libVLC, new Uri("http://localhost:8080")));
            //_mp.Play(new Media(_libVLC, new Uri("rtsp://localhost:8554/stream")));
            //_mp.Play(new Media(_libVLC, new Uri("http://localhost:8888/stream/index.m3u8")));

            startTimer.Start();
            //PlayURI("rtp://127.0.0.1:5004");
            //PlayURI("udp://@127.0.0.1:1234");
            //PlayURI("http://localhost:8080");
            //PlayStream(VIDEO_URL);
            //StartStream("http://localhost:8080");
            //PlayURI("http://localhost:8080");
            //PlayURI("https://www.rmp-streaming.com/media/big-buck-bunny-360p.mp4");
            //PlayURI("http://localhost:8888/stream/index.m3u8");
        }

        void PlayTimerTick(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine($"{DateTime.Now.ToLongTimeString()}");
                w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                w.WriteLine($"{_mp.Media.Statistics.InputBitrate}");
                w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                //w.WriteLine($"{_mp.Media.Statistics.}");
            }
        }

        void StartTimerTick(object sender, EventArgs e)
        {
            if(_mp.State != VLCState.Opening && _mp.State != VLCState.Playing)
                PlayURI("rtmp://127.0.0.1:1935");
            System.Console.WriteLine("TIMER: " + DateTime.Now.TimeOfDay);
            System.Console.WriteLine("STATE: " + _mp.State);
            System.Console.WriteLine(_mp.Time);
            if (_mp.State == VLCState.Playing)
            {
                playTimer.Start();
                startTimer.Stop();
                startTimer.Enabled = false;
            }
        }

        void mpTimeChanged(object sender, MediaPlayerTimeChangedEventArgs e)
        {
                textBox1.Invoke(new Action(delegate ()
                {
                    textBox1.Text = (TimeSpan.FromMilliseconds(_mp.Time).ToString());
                    textBox2.Text = (TimeSpan.FromMilliseconds(_mp2.Time).ToString());
                    textBox3.Text = (TimeSpan.FromMilliseconds(_mp3.Time).ToString());
                    textBox4.Text = (TimeSpan.FromMilliseconds(_mp4.Time).ToString());
                    textBox5.Text = (TimeSpan.FromMilliseconds(_mp5.Time).ToString());
                    textBox6.Text = (TimeSpan.FromMilliseconds(_mp6.Time).ToString());
                    textBox7.Text = (TimeSpan.FromMilliseconds(_mp7.Time).ToString());
                    textBox8.Text = (TimeSpan.FromMilliseconds(_mp8.Time).ToString());
                    textBox9.Text = (TimeSpan.FromMilliseconds(_mp9.Time).ToString());
                }));
        }

        bool PlayURI(string file)
        {
            bool play = _mp.Play(new Media(_libVLC, new Uri(file)));
            //_mp2.Play(new Media(_libVLC, new Uri(file)));
            //_mp3.Play(new Media(_libVLC, new Uri(file)));
            //_mp4.Play(new Media(_libVLC, new Uri(file)));
            //_mp5.Play(new Media(_libVLC, new Uri(file)));
            //_mp6.Play(new Media(_libVLC, new Uri(file)));
            //_mp7.Play(new Media(_libVLC, new Uri(file)));
            //_mp8.Play(new Media(_libVLC, new Uri(file)));
            //_mp9.Play(new Media(_libVLC, new Uri(file)));
            return play;
        }

        bool PlayStream(string file)
        {
            bool play = _mp.Play(new Media(_libVLC, new Uri(file+"0")));
            _mp2.Play(new Media(_libVLC, new Uri(file+"1")));
            _mp3.Play(new Media(_libVLC, new Uri(file+"2")));
            _mp4.Play(new Media(_libVLC, new Uri(file+"3")));
            _mp5.Play(new Media(_libVLC, new Uri(file+"4")));
            _mp6.Play(new Media(_libVLC, new Uri(file+"5")));
            _mp7.Play(new Media(_libVLC, new Uri(file+"6")));
            _mp8.Play(new Media(_libVLC, new Uri(file+"7")));
            _mp9.Play(new Media(_libVLC, new Uri(file+"8")));
            return play;
        }
    }
}
