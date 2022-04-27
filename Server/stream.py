import sys
import pexpect
from datetime import date, datetime
from pexpect import popen_spawn

#TCP_CMD = "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts tcp://127.0.0.1:3333?listen
#UDP_CMD = "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts -flush_packets 0 udp://127.0.0.1:3333?pkt_size=1024"
#RTSP_CMD ="ffmpeg -re -fflags +genpts -i stream.mp4 -an -f rtsp rtsp://localhost:8554/mystream"
#RTMP_CMD ="ffmpeg -re -fflags +genpts -i stream.mp4 -an -f flv -listen 1 rtmp://127.0.0.1:3333"
#SRT_CMD = "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts srt://127.0.0.1:3333?mode=listener"
TCP_CMD = 'ffmpeg -re -fflags +genpts -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -filter_complex "[0:v] setpts=PTS-STARTPTS, scale=qvga [a0]; [1:v] setpts=PTS-STARTPTS, scale=qvga [a1]; [2:v] setpts=PTS-STARTPTS, scale=qvga [a2]; [3:v] setpts=PTS-STARTPTS, scale=qvga [a3]; [4:v] setpts=PTS-STARTPTS, scale=qvga [a4]; [5:v] setpts=PTS-STARTPTS, scale=qvga [a5]; [6:v] setpts=PTS-STARTPTS, scale=qvga [a6]; [7:v] setpts=PTS-STARTPTS, scale=qvga [a7]; [8:v] setpts=PTS-STARTPTS, scale=qvga [a8]; [a0][a1][a2][a3][a4][a5][a6][a7][a8]xstack=inputs=9:layout=0_0|0_h0|0_h0+h1|w0_0|w0_h0|w0_h0+h1|w0+w1_0|w0+w1_h0|w0+w1_h0+h1[out]" -map "[out]" -an -c:v libx264 -preset ultrafast -f mpegts tcp://127.0.0.1:3333?listen'#"ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts tcp://127.0.0.1:3333?listen
UDP_CMD = 'ffmpeg -re -fflags +genpts -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -filter_complex "[0:v] setpts=PTS-STARTPTS, scale=qvga [a0]; [1:v] setpts=PTS-STARTPTS, scale=qvga [a1]; [2:v] setpts=PTS-STARTPTS, scale=qvga [a2]; [3:v] setpts=PTS-STARTPTS, scale=qvga [a3]; [4:v] setpts=PTS-STARTPTS, scale=qvga [a4]; [5:v] setpts=PTS-STARTPTS, scale=qvga [a5]; [6:v] setpts=PTS-STARTPTS, scale=qvga [a6]; [7:v] setpts=PTS-STARTPTS, scale=qvga [a7]; [8:v] setpts=PTS-STARTPTS, scale=qvga [a8]; [a0][a1][a2][a3][a4][a5][a6][a7][a8]xstack=inputs=9:layout=0_0|0_h0|0_h0+h1|w0_0|w0_h0|w0_h0+h1|w0+w1_0|w0+w1_h0|w0+w1_h0+h1[out]" -map "[out]" -an -c:v libx264 -preset ultrafast -f mpegts -flush_packets 0 udp://127.0.0.1:3333?pkt_size=1024'#"ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts -flush_packets 0 udp://127.0.0.1:3333?pkt_size=1024"
RTSP_CMD ='ffmpeg -re -fflags +genpts -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -filter_complex "[0:v] setpts=PTS-STARTPTS, scale=qvga [a0]; [1:v] setpts=PTS-STARTPTS, scale=qvga [a1]; [2:v] setpts=PTS-STARTPTS, scale=qvga [a2]; [3:v] setpts=PTS-STARTPTS, scale=qvga [a3]; [4:v] setpts=PTS-STARTPTS, scale=qvga [a4]; [5:v] setpts=PTS-STARTPTS, scale=qvga [a5]; [6:v] setpts=PTS-STARTPTS, scale=qvga [a6]; [7:v] setpts=PTS-STARTPTS, scale=qvga [a7]; [8:v] setpts=PTS-STARTPTS, scale=qvga [a8]; [a0][a1][a2][a3][a4][a5][a6][a7][a8]xstack=inputs=9:layout=0_0|0_h0|0_h0+h1|w0_0|w0_h0|w0_h0+h1|w0+w1_0|w0+w1_h0|w0+w1_h0+h1[out]" -map "[out]" -an -c:v libx264 -preset ultrafast -f rtsp rtsp://localhost:8554/mystream'#"ffmpeg -re -fflags +genpts -i stream.mp4 -an -f rtsp rtsp://localhost:8554/mystream"
RTMP_CMD ='ffmpeg -re -fflags +genpts -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -filter_complex "[0:v] setpts=PTS-STARTPTS, scale=qvga [a0]; [1:v] setpts=PTS-STARTPTS, scale=qvga [a1]; [2:v] setpts=PTS-STARTPTS, scale=qvga [a2]; [3:v] setpts=PTS-STARTPTS, scale=qvga [a3]; [4:v] setpts=PTS-STARTPTS, scale=qvga [a4]; [5:v] setpts=PTS-STARTPTS, scale=qvga [a5]; [6:v] setpts=PTS-STARTPTS, scale=qvga [a6]; [7:v] setpts=PTS-STARTPTS, scale=qvga [a7]; [8:v] setpts=PTS-STARTPTS, scale=qvga [a8]; [a0][a1][a2][a3][a4][a5][a6][a7][a8]xstack=inputs=9:layout=0_0|0_h0|0_h0+h1|w0_0|w0_h0|w0_h0+h1|w0+w1_0|w0+w1_h0|w0+w1_h0+h1[out]" -map "[out]" -an -c:v libx264 -preset ultrafast -f flv -listen 1 rtmp://127.0.0.1:3333'#"ffmpeg -re -fflags +genpts -i stream.mp4 -an -f flv -listen 1 rtmp://127.0.0.1:3333"
SRT_CMD = 'ffmpeg -re -fflags +genpts -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -i stream.mp4 -filter_complex "[0:v] setpts=PTS-STARTPTS, scale=qvga [a0]; [1:v] setpts=PTS-STARTPTS, scale=qvga [a1]; [2:v] setpts=PTS-STARTPTS, scale=qvga [a2]; [3:v] setpts=PTS-STARTPTS, scale=qvga [a3]; [4:v] setpts=PTS-STARTPTS, scale=qvga [a4]; [5:v] setpts=PTS-STARTPTS, scale=qvga [a5]; [6:v] setpts=PTS-STARTPTS, scale=qvga [a6]; [7:v] setpts=PTS-STARTPTS, scale=qvga [a7]; [8:v] setpts=PTS-STARTPTS, scale=qvga [a8]; [a0][a1][a2][a3][a4][a5][a6][a7][a8]xstack=inputs=9:layout=0_0|0_h0|0_h0+h1|w0_0|w0_h0|w0_h0+h1|w0+w1_0|w0+w1_h0|w0+w1_h0+h1[out]" -map "[out]" -an -c:v libx264 -preset ultrafast -f mpegts srt://127.0.0.1:3333?mode=listener'#"ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts srt://127.0.0.1:3333?mode=listener"

TCP_Path = "../Dane/TCP/TCP_Server_LOG.txt"
UDP_Path = "../Dane/UDP/UDP_Server_LOG.txt"
RTSP_Path= "../Dane/RTSP/RTSP_Server_LOG.txt"
SRT_Path = "../Dane/SRT/SRT_Server_LOG.txt"
RTMP_Path= "../Dane/RTMP/RTMP_Server_LOG.txt"

cmd = ""
out = ""

def stream(arg):
    match arg:
        case "tcp":
            cmd = TCP_CMD
            out = TCP_Path
        case "udp":
            cmd = UDP_CMD
            out = UDP_Path
        case "rtsp":
            cmd = RTSP_CMD
            out = RTSP_Path
        case "rtmp":
            cmd = RTMP_CMD
            out = RTMP_Path
        case "srt":
            cmd = SRT_CMD
            out = SRT_Path
        case _:
            print ("Invalid Protocol: " + arg)
            return

    outFile = open(out, 'w')
    #cmd = 'ffmpeg -re -fflags +genpts -i stream0.ts -an -f mpegts tcp://127.0.0.1:3333?listen'
    thread = popen_spawn.PopenSpawn(cmd)
    print ("started %s" % cmd)
    cpl = thread.compile_pattern_list([
        pexpect.EOF,
        "time=(?P<time>\S+)"

    ])
    while True:
        i = thread.expect_list(cpl, timeout=None)
        if i == 0: # EOF
            print ("the sub process exited")
            break
        elif i == 1:
            time = thread.match.group(0).decode('utf-8')
            t = datetime.now()
            tms = '%s.%i' % (t.strftime("%H:%M:%S"), t.microsecond/1000)
            print (time + " " + tms[:-1])
            outFile.write(time + "\n")
            outFile.write(tms[:-1] + "\n")
        elif i == 2:
            #unknown_line = thread.match.group(0)
            #print unknown_line
            pass

if __name__ == "__main__":
    if(len(sys.argv) != 2):
        print("Must specify protocol")
    else:
        stream(sys.argv[1])
