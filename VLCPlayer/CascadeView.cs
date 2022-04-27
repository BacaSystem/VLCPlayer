using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLCPlayer
{
    public partial class CascadeView : Form
    {
        private Form2 callingForm = null;

        const string path = "C:\\Work\\Studia\\inz\\Dane\\";

        const string TCP_URL = "tcp://127.0.0.1:333";
        const string UDP_URL = "udp://@127.0.0.1:333";
        const string RTSP_URL = "rtsp://127.0.0.1:8554/mystream";
        const string RTMP_URL = "rtmp://127.0.0.1:333";
        const string SRT_URL = "srt://127.0.0.1:333";

        LibVLC _libVLC;
        MediaPlayer _mp, _mp2, _mp3, _mp4, _mp5, _mp6, _mp7, _mp8, _mp9;

        public System.Windows.Forms.Timer startTimer = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer playTimer = new System.Windows.Forms.Timer();

        Stopwatch stopWatch = new Stopwatch();

        public Media media;

        protocol protocol = protocol.none;
        public CascadeView()
        {
            InitializeComponent();

            cascadeToolStripMenuItem1.Checked = true;
            fullToolStripMenuItem1.Checked = false;

            startTimer.Interval = 1000;
            startTimer.Tick += new EventHandler(StartTimerTick);
            playTimer.Interval = 500;
            playTimer.Tick += new EventHandler(PlayTimerTick);

            _libVLC = new LibVLC();

            LoadView();
        }

        public CascadeView(Form2 callingForm) : this()
        {
            this.callingForm = callingForm;
        }

        void PlayTimerTick(object sender, EventArgs e)
        {
            if (!_mp.IsPlaying)
                return;

            switch (protocol)
            {
                case protocol.tpc:
                    using (StreamWriter w = File.AppendText(path + "TCP\\TCP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.udp:
                    using (StreamWriter w = File.AppendText(path + "UDP\\UDP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.rtsp:
                    using (StreamWriter w = File.AppendText(path + "RTSP\\RTSP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.rtmp:
                    using (StreamWriter w = File.AppendText(path + "RTMP\\RTMP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.srt:
                    using (StreamWriter w = File.AppendText(path + "SRT\\SRT_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.none:
                    break;
            }


        }

        void StartTimerTick(object sender, EventArgs e)
        {
            if (_mp.State != VLCState.Opening && _mp.State != VLCState.Playing)
            {
                switch (protocol)
                {
                    case protocol.tpc:
                        PlayStream(TCP_URL);
                        break;
                    case protocol.udp:
                        PlayStream(UDP_URL);
                        break;
                    case protocol.rtsp:
                        PlayStream(RTSP_URL);
                        break;
                    case protocol.rtmp:
                        PlayStream(RTMP_URL);
                        break;
                    case protocol.srt:
                        PlayStream(SRT_URL);
                        break;
                    case protocol.none:
                        break;
                }
            }

            System.Console.WriteLine("TIMER: " + DateTime.Now.TimeOfDay);
            System.Console.WriteLine("STATE: " + _mp.State);
            System.Console.WriteLine(_mp.Time);
            if (_mp.State == VLCState.Playing)
            {
                this.UseWaitCursor = false;
                playTimer.Start();
                startTimer.Stop();
                startTimer.Enabled = false;
                stopWatch.Start();
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

        private void CascadeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.callingForm != null)
                this.callingForm.Close();
        }

        void LoadView()
        {
            _mp = new MediaPlayer(_libVLC);
            _mp2 = new MediaPlayer(_libVLC);
            _mp3 = new MediaPlayer(_libVLC);
            _mp4 = new MediaPlayer(_libVLC);
            _mp5 = new MediaPlayer(_libVLC);
            _mp6 = new MediaPlayer(_libVLC);
            _mp7 = new MediaPlayer(_libVLC);
            _mp8 = new MediaPlayer(_libVLC);
            _mp9 = new MediaPlayer(_libVLC);

            _mp.TimeChanged += mpTimeChanged;

            videoView1.MediaPlayer = _mp;
            videoView2.MediaPlayer = _mp2;
            videoView3.MediaPlayer = _mp3;
            videoView4.MediaPlayer = _mp4;
            videoView5.MediaPlayer = _mp5;
            videoView6.MediaPlayer = _mp6;
            videoView7.MediaPlayer = _mp7;
            videoView8.MediaPlayer = _mp8;
            videoView9.MediaPlayer = _mp9;
        }

        private void tCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.tpc)
                return;
            protocol = protocol.tpc;
            this.UseWaitCursor = true;


            if (_mp != null)
            {
                _mp.Dispose();
                _mp2.Dispose();
                _mp3.Dispose();
                _mp4.Dispose(); 
                _mp5.Dispose();
                _mp6.Dispose();
                _mp7.Dispose();
                _mp8.Dispose();
                _mp9.Dispose();

                LoadView();
            }

            using (StreamWriter w = File.CreateText(path + "TCP\\TCP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void uDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.udp)
                return;
            protocol = protocol.udp;
            this.UseWaitCursor = true;


            if (_mp != null)
            {
                _mp.Dispose();
                _mp2.Dispose();
                _mp3.Dispose();
                _mp4.Dispose();
                _mp5.Dispose();
                _mp6.Dispose();
                _mp7.Dispose();
                _mp8.Dispose();
                _mp9.Dispose();

                LoadView();
            }

            using (StreamWriter w = File.CreateText(path + "UDP\\UDP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void rTMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.rtmp)
                return;
            protocol = protocol.rtmp;
            this.UseWaitCursor = true;


            if (_mp != null)
            {
                _mp.Dispose();
                _mp2.Dispose();
                _mp3.Dispose();
                _mp4.Dispose();
                _mp5.Dispose();
                _mp6.Dispose();
                _mp7.Dispose();
                _mp8.Dispose();
                _mp9.Dispose();

                LoadView();
            }

            using (StreamWriter w = File.CreateText(path + "RTMP\\RTMP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void rTSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.rtsp)
                return;
            protocol = protocol.rtsp;
            this.UseWaitCursor = true;


            if (_mp != null)
            {
                _mp.Dispose();
                _mp2.Dispose();
                _mp3.Dispose();
                _mp4.Dispose();
                _mp5.Dispose();
                _mp6.Dispose();
                _mp7.Dispose();
                _mp8.Dispose();
                _mp9.Dispose();

                LoadView();
            }

            using (StreamWriter w = File.CreateText(path + "RTSP\\RTSP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void sRTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.srt)
                return;
            protocol = protocol.srt;
            this.UseWaitCursor = true;


            if (_mp != null)
            {
                _mp.Dispose();
                _mp2.Dispose();
                _mp3.Dispose();
                _mp4.Dispose();
                _mp5.Dispose();
                _mp6.Dispose();
                _mp7.Dispose();
                _mp8.Dispose();
                _mp9.Dispose();

                LoadView();
            }
            using (StreamWriter w = File.CreateText(path + "SRT\\SRT_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void cascadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void fullToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_mp != null)
            {
                _mp.Dispose();
                _mp2.Dispose();
                _mp3.Dispose();
                _mp4.Dispose();
                _mp5.Dispose();
                _mp6.Dispose();
                _mp7.Dispose();
                _mp8.Dispose();
                _mp9.Dispose();
            }
            startTimer.Enabled = false;
            playTimer.Enabled = false;
            startTimer.Dispose();
            playTimer.Dispose();

            Form2 fullView = new Form2(this);
            fullView.Show();
            this.Hide();
        }
    }


}
