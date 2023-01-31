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
    
    public partial class NormalView : Form
    {
        private CascadeView callingForm = null;

        const string path = "C:\\Work\\Studia\\inz\\Dane\\";

        const string TCP_URL = "tcp://127.0.0.1:3333";
        const string UDP_URL = "udp://@127.0.0.1:3333?pkt_size=1024";
        const string RTSP_URL = "rtsp://127.0.0.1:8554/mystream";
        const string RTMP_URL = "rtmp://127.0.0.1:3333";
        const string SRT_URL = "srt://127.0.0.1:3333";

        LibVLC _libVLC;
        MediaPlayer _mp;

        public System.Windows.Forms.Timer startTimer = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Timer playTimer = new System.Windows.Forms.Timer();

        public Media media;

        protocol protocol = protocol.none;

        public NormalView(CascadeView callingForm):this()
        {
            this.callingForm = callingForm;
        }

        public NormalView()
        {
            InitializeComponent();

            fullToolStripMenuItem1.Checked = true;
            cascadeToolStripMenuItem1.Checked = false;

            startTimer.Interval = 1000;
            startTimer.Tick += new EventHandler(StartTimerTick);
            playTimer.Interval = 500;
            playTimer.Tick += new EventHandler(PlayTimerTick);

            _libVLC = new LibVLC();

            _mp = new MediaPlayer(_libVLC);
            _mp.TimeChanged += mpTimeChanged;

            videoView1.MediaPlayer = _mp;
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
                    }
                    break;
                case protocol.udp:
                    using (StreamWriter w = File.AppendText(path + "UDP\\UDP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                    }
                    break;
                case protocol.rtsp:
                    using (StreamWriter w = File.AppendText(path + "RTSP\\RTSP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                    }
                    break;
                case protocol.rtmp:
                    using (StreamWriter w = File.AppendText(path + "RTMP\\RTMP_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
                    }
                    break;
                case protocol.srt:
                    using (StreamWriter w = File.AppendText(path + "SRT\\SRT_Client_LOG.txt"))
                    {
                        w.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.ff")}");
                        w.WriteLine($"{TimeSpan.FromMilliseconds(_mp.Time)}");
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
                    case protocol.rtsp:
                        PlayURI(RTSP_URL);
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

            if (_mp.State == VLCState.Playing)
            {
                this.UseWaitCursor = false;
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
            }));
        }

        bool PlayURI(string file)
        {
            return _mp.Play(new Media(_libVLC, new Uri(file)));
        }

        private void tcpToolStripMenuItem_Click(object sender, EventArgs e)
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
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
            }

            using (StreamWriter w = File.CreateText(path + "UDP\\UDP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void rTMPToolStripMenuItem_Click_1(object sender, EventArgs e)
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

            using (StreamWriter w = File.CreateText(path + "RTMP\\RTMP_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void rTSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (protocol == protocol.rtsp)
                return;
            protocol = protocol.rtsp;
            this.UseWaitCursor = true;

            if (_mp != null)
            {
                _mp.Dispose();
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
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
                _mp = new MediaPlayer(_libVLC);
                _mp.TimeChanged += mpTimeChanged;
                videoView1.MediaPlayer = _mp;
            }

            using (StreamWriter w = File.CreateText(path + "SRT\\SRT_Client_LOG.txt"))
                w.WriteLine("");

            startTimer.Start();
        }

        private void fullToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void cascadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_mp != null)
                _mp.Dispose();
            startTimer.Enabled = false;
            playTimer.Enabled = false;
            startTimer.Dispose();
            playTimer.Dispose();

            CascadeView cascadeView = new CascadeView(this);
            cascadeView.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.callingForm != null)
                this.callingForm.Close();
        }
    }
}
