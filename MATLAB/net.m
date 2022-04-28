
subplot(2,2,1)
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

title('Bandwith concatenated stream')
xlim([0 10])
xlabel('Time [min]')
ylabel('Bandwith [Mb/s]')
grid;
legend('TCP 1', 'UDP 1', 'RTSP 1', 'RTMP 1', 'SRT 1')
%% 




subplot(2,2,2)
data_tcp_concat_p = readmatrix("Data/TCP_Full_9x9_packets.csv", NumHeaderLines=1);
x_tcp_concat_p = data_tcp_concat_p(:, 1);
y_tcp_concat_p = data_tcp_concat_p(:, 2);
plot(x_tcp_concat_p/60,y_tcp_concat_p)
hold on

data_udp_concat_p = readmatrix("Data/UDP_Full_9x9_packets.csv", NumHeaderLines=1);
x_udp_concat_p = data_udp_concat_p(:, 1);
y_udp_concat_p = data_udp_concat_p(:, 2);
plot(x_udp_concat_p/60,y_udp_concat_p)
hold on

data_rtsp_concat_p = readmatrix("Data/RTSP_Full_9x9_packets.csv", NumHeaderLines=1);
x_rtsp_concat_p = data_rtsp_concat_p(:, 1);
y_rtsp_concat_p = data_rtsp_concat_p(:, 2);
plot(x_rtsp_concat_p/60,y_rtsp_concat_p)
hold on

data_rtmp_concat_p = readmatrix("Data/RTMP_Full_9x9_packets.csv", NumHeaderLines=1);
x_rtmp_concat_p = data_rtmp_concat_p(:, 1);
y_rtmp_concat_p = data_rtmp_concat_p(:, 2);
plot(x_rtmp_concat_p/60,y_rtmp_concat_p)
hold on

data_srt_concat_p = readmatrix("Data/SRT_Full_9x9_packets.csv", NumHeaderLines=1);
x_srt_concat_p = data_srt_concat_p(:, 1);
y_srt_concat_p = data_srt_concat_p(:, 2);
plot(x_srt_concat_p/60,y_srt_concat_p)
hold on

title('Packets concatenated stream')
xlim([0 10])
xlabel('Time [min]')
ylabel('Packets')
grid;
legend('TCP 1', 'UDP 1', 'RTSP 1', 'RTMP 1', 'SRT 1')

%%%%%%%%%%%%%%%%%%%%%%%%%%%%

subplot(2,2,3)
data_tcp_cascade = readmatrix("Data/TCP_Cascade_network.csv", NumHeaderLines=1);
x_tcp_cascade = data_tcp_cascade(:, 1);
y_tcp_cascade = data_tcp_cascade(:, 2);
plot(x_tcp_cascade/60,y_tcp_cascade/10e6)
hold on

data_udp_cascade = readmatrix("Data/UDP_Cascade_network.csv", NumHeaderLines=1);
x_udp_cascade = data_udp_cascade(:, 1);
y_udp_cascade = data_udp_cascade(:, 2);
plot(x_udp_cascade/60,y_udp_cascade/10e6)
hold on

data_rtsp_cascade = readmatrix("Data/RTSP_Cascade_network.csv", NumHeaderLines=1);
x_rtsp_cascade = data_rtsp_cascade(:, 1);
y_rtsp_cascade = data_rtsp_cascade(:, 2);
plot(x_rtsp_cascade/60,y_rtsp_cascade/10e6)
hold on

data_rtmp_cascade = readmatrix("Data/RTMP_Cascade_network.csv", NumHeaderLines=1);
x_rtmp_cascade = data_rtmp_cascade(:, 1);
y_rtmp_cascade = data_rtmp_cascade(:, 2);
plot(x_rtmp_cascade/60,y_rtmp_cascade/10e6)
hold on

data_srt_cascade = readmatrix("Data/SRT_Cascade_network.csv", NumHeaderLines=1);
x_srt_cascade = data_srt_cascade(:, 1);
y_srt_cascade = data_srt_cascade(:, 2);
plot(x_srt_cascade/60,y_srt_cascade/10e6)
hold on

title('Bandwith 9 cascade streams')
xlim([0 10])
xlabel('Time [min]')
ylabel('Bandwith [Mb/s]')
grid;
legend('TCP 9', 'UDP 9', 'RTSP 9', 'RTMP 9', 'SRT 9')
%% 




subplot(2,2,4)
data_tcp_cascade_p = readmatrix("Data/TCP_Cascade_network_packets.csv", NumHeaderLines=1);
x_tcp_cascade_p = data_tcp_cascade_p(:, 1);
y_tcp_cascade_p = data_tcp_cascade_p(:, 2);
plot(x_tcp_cascade_p/60,y_tcp_cascade_p)
hold on

data_udp_cascade_p = readmatrix("Data/UDP_Cascade_network_packets.csv", NumHeaderLines=1);
x_udp_cascade_p = data_udp_cascade_p(:, 1);
y_udp_cascade_p = data_udp_cascade_p(:, 2);
plot(x_udp_cascade_p/60,y_udp_cascade_p)
hold on

data_rtsp_cascade_p = readmatrix("Data/RTSP_Cascade_network_packets.csv", NumHeaderLines=1);
x_rtsp_cascade_p = data_rtsp_cascade_p(:, 1);
y_rtsp_cascade_p = data_rtsp_cascade_p(:, 2);
plot(x_rtsp_cascade_p/60,y_rtsp_cascade_p)
hold on

data_rtmp_cascade_p = readmatrix("Data/RTMP_Cascade_network_packets.csv", NumHeaderLines=1);
x_rtmp_cascade_p = data_rtmp_cascade_p(:, 1);
y_rtmp_cascade_p = data_rtmp_cascade_p(:, 2);
plot(x_rtmp_cascade_p/60,y_rtmp_cascade_p)
hold on

data_srt_cascade_p = readmatrix("Data/SRT_Cascade_network_packets.csv", NumHeaderLines=1);
x_srt_cascade_p = data_srt_cascade_p(:, 1);
y_srt_cascade_p = data_srt_cascade_p(:, 2);
plot(x_srt_cascade_p/60,y_srt_cascade_p)
hold on

title('Packets 9 cascade streams')
xlim([0 10])
xlabel('Time [min]')
ylabel('Packets')
grid;
legend('TCP 9', 'UDP 9', 'RTSP 9', 'RTMP 9', 'SRT 9')

