@echo off
set protocol=%1

if %protocol%==tcp FOR /L %%i IN (0,1,8) DO (start cmd /c "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts tcp://127.0.0.1:333%%i?listen")
if %protocol%==udp FOR /L %%i IN (0,1,8) DO (start cmd /c "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts -flush_packets 0 udp://127.0.0.1:333%%i?pkt_size=1024")
if %protocol%==rtsp FOR /L %%i IN (0,1,8) DO (start cmd /c "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f rtsp rtsp://localhost:8554/mystream%%i")
if %protocol%==rtmp FOR /L %%i IN (0,1,8) DO (start cmd /c "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f flv -listen 1 rtmp://127.0.0.1:333%%i")
if %protocol%==srt FOR /L %%i IN (0,1,8) DO (start cmd /c "ffmpeg -re -fflags +genpts -i stream.mp4 -an -f mpegts srt://127.0.0.1:333%%i?mode=listener")
