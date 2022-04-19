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
    
    public partial class Form2 : Form
    {
        const string path = "C:\\Work\\Studia\\inz\\Dane\\";

        const string TCP_URL = "tcp://127.0.0.1:3333";
        const string UDP_URL = "udp://@127.0.0.1:3333?pkt_size=1024";
        const string RTP_URL = "C:\\Work\\Studia\\inz\\Server\\video.sdp";
        const string RTMP_URL = "rtmp://127.0.0.1:3333";
        const string SRT_URL = "srt://127.0.0.1:3333";

        LibVLC _libVLC;
        MediaPlayer _mp;

        public System.Windows.Forms.Timer startTimer = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer playTimer = new System.Windows.Forms.Timer();
        Stopwatch stopWatch = new Stopwatch();

        public Media media;

        protocol protocol = protocol.none;

        public Form2()
        {
            InitializeComponent();

            startTimer.Interval = 1000;
            startTimer.Tick += new EventHandler(StartTimerTick);
            playTimer.Interval = 1000;
            playTimer.Tick += new EventHandler(PlayTimerTick);

            _libVLC = new LibVLC();


            _mp = new MediaPlayer(_libVLC);
            _mp.TimeChanged += mpTimeChanged;
            

            videoView1.MediaPlayer = _mp;
            
            //startTimer.Start();

        }

        void PlayTimerTick(object sender, EventArgs e)
        {
            if (!_mp.IsPlaying)
                return;

            switch (protocol)
            {
                case protocol.tpc:
                    using (StreamWriter w = File.AppendText(path + "TCP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToLongTimeString()}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate*8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.udp:
                    using (StreamWriter w = File.AppendText(path + "UDP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToLongTimeString()}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.rtp:
                    using (StreamWriter w = File.AppendText(path + "RTP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToLongTimeString()}");
                        w.WriteLine($"{stopWatch.Elapsed}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.rtmp:
                    using (StreamWriter w = File.AppendText(path + "RTMP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToLongTimeString()}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                        w.WriteLine($"{_mp.Media.Statistics.InputBitrate * 8000}");
                        w.WriteLine($"{_mp.Media.Statistics.ReadBytes} ");
                    }
                    break;
                case protocol.srt:
                    using (StreamWriter w = File.AppendText(path + "SRT_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToLongTimeString()}");
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
                        PlayURI(TCP_URL);
                        break;
                    case protocol.udp:
                        PlayURI(UDP_URL);
                        break;
                    case protocol.rtp:
                        PlayURI(RTP_URL);
                        break;
                    case protocol.rtmp:
                        PlayURI(RTMP_URL);
                        break;
                    case protocol.srt:
                        PlayURI(SRT_URL);
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
            if (protocol == protocol.rtp)
            {
                textBox1.Invoke(new Action(delegate ()
                {
                    textBox1.Text = (stopWatch.Elapsed.ToString());
                }));
            }
            else
            {
                textBox1.Invoke(new Action(delegate ()
                {
                    textBox1.Text = (TimeSpan.FromMilliseconds(_mp.Time).ToString());
                }));
            }
        }

        bool PlayURI(string file)
        {
            return _mp.Play(new Media(_libVLC, new Uri(file)));
        }

        private void tCPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.tpc)
                return;
            protocol = protocol.tpc;
            this.UseWaitCursor = true;


            if (_mp != null)
            {
                _mp.Dispose();
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
            }

            using (StreamWriter w = File.CreateText(path + "TCP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void uDPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.udp)
                return;
            protocol = protocol.udp;
            this.UseWaitCursor = true;

            if (_mp != null)
            {
                _mp.Dispose();
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
            }

            using (StreamWriter w = File.CreateText(path + "UDP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void rTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (protocol == protocol.rtp)
                return;
            protocol = protocol.rtp;
            this.UseWaitCursor = true;

            if (_mp != null)
            {
                _mp.Dispose();
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
            }

            using (StreamWriter w = File.CreateText(path + "RTP_Client_LOG.txt"))
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
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
            }

            using (StreamWriter w = File.CreateText(path + "RTMP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void hLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (protocol == protocol.srt)
                return;
            protocol = protocol.srt;
            this.UseWaitCursor = true;

            if (_mp != null)
            {
                _mp.Dispose();
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
            }

            using (StreamWriter w = File.CreateText(path + "SRT_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }
    }
}
