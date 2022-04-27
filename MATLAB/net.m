
figure(1)
data_tcp_concat = readmatrix("Data/TCP_Full_9x9.csv", NumHeaderLines=1);
x_tcp_concat = data_tcp_concat(:, 1);
y_tcp_concat = data_tcp_concat(:, 2);
plot(x_tcp_concat/60,y_tcp_concat/10e6)
hold on

data_udp_concat = readmatrix("Data/UDP_Full_9x9.csv", NumHeaderLines=1);
x_udp_concat = data_udp_concat(:, 1);
y_udp_concat = data_udp_concat(:, 2);
plot(x_udp_concat/60,y_udp_concat/10e6)
hold on

data_rtsp_concat = readmatrix("Data/RTSP_Full_9x9.csv", NumHeaderLines=1);
x_rtsp_concat = data_rtsp_concat(:, 1);
y_rtsp_concat = data_rtsp_concat(:, 2);
plot(x_rtsp_concat/60,y_rtsp_concat/10e6)
hold on

data_rtmp_concat = readmatrix("Data/RTMP_Full_9x9.csv", NumHeaderLines=1);
x_rtmp_concat = data_rtmp_concat(:, 1);
y_rtmp_concat = data_rtmp_concat(:, 2);
plot(x_rtmp_concat/60,y_rtmp_concat/10e6)
hold on

data_srt_concat = readmatrix("Data/SRT_Full_9x9.csv", NumHeaderLines=1);
x_srt_concat = data_srt_concat(:, 1);
y_srt_concat = data_srt_concat(:, 2);
plot(x_srt_concat/60,y_srt_concat/10e6)
hold on


xlabel('Time [min]')
ylabel('Bandwith [Mb/s]')
grid;
legend('TCP Con', 'UDP Con', 'RTSP Con', 'RTMP Con', 'SRT Con')
%% 




figure(2)
data_tcp_concat_p = readmatrix("Data/TCP_Full_9x9_packets.csv", NumHeaderLines=1);
x_tcp_concat_p = data_tcp_concat_p(:, 1);
y_tcp_concat_p = data_tcp_concat_p(:, 2);
plot(x_tcp_concat_p,y_tcp_concat_p)
hold on

data_udp_concat_p = readmatrix("Data/UDP_Full_9x9_packets.csv", NumHeaderLines=1);
x_udp_concat_p = data_udp_concat_p(:, 1);
y_udp_concat_p = data_udp_concat_p(:, 2);
plot(x_udp_concat_p,y_udp_concat_p)
hold on

data_rtsp_concat_p = readmatrix("Data/RTSP_Full_9x9_packets.csv", NumHeaderLines=1);
x_rtsp_concat_p = data_rtsp_concat_p(:, 1);
y_rtsp_concat_p = data_rtsp_concat_p(:, 2);
plot(x_rtsp_concat_p,y_rtsp_concat_p)
hold on

data_rtmp_concat_p = readmatrix("Data/RTMP_Full_9x9_packets.csv", NumHeaderLines=1);
x_rtmp_concat_p = data_rtmp_concat_p(:, 1);
y_rtmp_concat_p = data_rtmp_concat_p(:, 2);
plot(x_rtmp_concat_p,y_rtmp_concat_p)
hold on

data_srt_concat_p = readmatrix("Data/SRT_Full_9x9_packets.csv", NumHeaderLines=1);
x_srt_concat_p = data_srt_concat_p(:, 1);
y_srt_concat_p = data_srt_concat_p(:, 2);
plot(x_srt_concat_p,y_srt_concat_p)
hold on


xlabel('Time [min]')
ylabel('Packets')
grid;
legend('TCP Con', 'UDP Con', 'RTSP Con', 'RTMP Con', 'SRT Con')
