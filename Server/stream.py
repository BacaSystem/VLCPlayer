import sys
import pexpect
from datetime import datetime
from pexpect import popen_spawn

TCP_CMD = "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts tcp://127.0.0.1:3333?listen"
UDP_CMD = "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts -flush_packets 0 udp://127.0.0.1:3333?pkt_size=1024"
RTP_CMD = "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f rtp -sdp_file video.sdp rtp://127.0.0.1:3333"
RTMP_CMD ="ffmpeg -re -fflags +genpts -i stream.mp4 -an -f flv -listen 1 rtmp://127.0.0.1:3333"
SRT_CMD = "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts srt://127.0.0.1:3333?mode=listener"

TCP_Path = "TCP_Server_LOG.txt"
UDP_Path = "UDP_Server_LOG.txt"
RTP_Path = "RTP_Server_LOG.txt"
SRT_Path = "SRT_Server_LOG.txt"
RTMP_Path="RTMP_Server_LOG.txt"

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
        case "rtp":
            cmd = RTP_CMD
            out = RTP_Path
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
            print (time + " " + datetime.now().strftime("%H:%M:%S"))
            outFile.write(time + "\n")
            outFile.write(datetime.now().strftime("%H:%M:%S") + "\n")
        elif i == 2:
            #unknown_line = thread.match.group(0)
            #print unknown_line
            pass

if __name__ == "__main__":
    if(len(sys.argv) != 2):
        print("Must specify protocol")
    else:
        stream(sys.argv[1])
