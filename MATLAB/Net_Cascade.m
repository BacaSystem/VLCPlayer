figure(1)
data_tcp_cascade = readmatrix("Data/TCP_Cascade.csv", NumHeaderLines=1);
x_tcp_cascade = data_tcp_cascade(:, 1);
y_tcp_cascade = data_tcp_cascade(:, 2);
plot(x_tcp_cascade/60,y_tcp_cascade/1e6, 'LineWidth',1.2)
avg_tcp_cascade = mean(y_tcp_cascade/1e6)
hold on

data_udp_cascade = readmatrix("Data/UDP_Cascade.csv", NumHeaderLines=1);
x_udp_cascade = data_udp_cascade(:, 1);
y_udp_cascade = data_udp_cascade(:, 2);
plot(x_udp_cascade/60,y_udp_cascade/1e6, 'LineWidth',1.2)
avg_udp_cascade = mean(y_udp_cascade/1e6)
hold on

data_rtsp_cascade = readmatrix("Data/RTSP_Cascade.csv", NumHeaderLines=1);
x_rtsp_cascade = data_rtsp_cascade(:, 1);
y_rtsp_cascade = data_rtsp_cascade(:, 2);
plot(x_rtsp_cascade/60,y_rtsp_cascade/1e6, 'LineWidth',1.2)
avg_rtsp_cascade = mean(y_rtsp_cascade/1e6)
hold on

data_rtmp_cascade = readmatrix("Data/RTMP_Cascade.csv", NumHeaderLines=1);
x_rtmp_cascade = data_rtmp_cascade(:, 1);
y_rtmp_cascade = data_rtmp_cascade(:, 2);
plot(x_rtmp_cascade/60,y_rtmp_cascade/1e6, 'LineWidth',1.2)
n = ceil(numel(y_rtmp_cascade)/2);
avg_rtmp_cascade = mean(y_rtmp_cascade(1:n)/1e6)
hold on

data_srt_cascade = readmatrix("Data/SRT_Cascade.csv", NumHeaderLines=1);
x_srt_cascade = data_srt_cascade(:, 1);
y_srt_cascade = data_srt_cascade(:, 2);
plot(x_srt_cascade/60,y_srt_cascade/1e6, 'LineWidth',2.0)
avg_srt_cascade = mean(y_srt_cascade/1e6)
hold on

title('Bandwith cascade stream', 'FontSize', 20)
xlim([0 5])
xlabel('Time [min]', 'FontSize', 20)
ylabel('Bandwith [Mb/s]', 'FontSize', 20)
grid;
legend('TCP', 'UDP', 'RTSP', 'RTMP', 'SRT', 'FontSize', 16)
%% 



figure(2)
data_tcp_cascade_p = readmatrix("Data/TCP_Cascade_Packets.csv", NumHeaderLines=1);
x_tcp_cascade_p = data_tcp_cascade_p(:, 1);
y_tcp_cascade_p = data_tcp_cascade_p(:, 2);
plot(x_tcp_cascade_p/60,y_tcp_cascade_p, 'LineWidth',1.2)
avg_tcp_cascade_p = mean(y_tcp_cascade_p)

hold on

data_udp_cascade_p = readmatrix("Data/UDP_Cascade_Packets.csv", NumHeaderLines=1);
x_udp_cascade_p = data_udp_cascade_p(:, 1);
y_udp_cascade_p = data_udp_cascade_p(:, 2);
plot(x_udp_cascade_p/60,y_udp_cascade_p, 'LineWidth',1.2)
avg_udp_cascade_p = mean(y_udp_cascade_p)
hold on

data_rtsp_cascade_p = readmatrix("Data/RTSP_Cascade_Packets.csv", NumHeaderLines=1);
x_rtsp_cascade_p = data_rtsp_cascade_p(:, 1);
y_rtsp_cascade_p = data_rtsp_cascade_p(:, 2);
plot(x_rtsp_cascade_p/60,y_rtsp_cascade_p, 'LineWidth',1.2)
avg_rtsp_cascade_p = mean(y_rtsp_cascade_p)
hold on

data_rtmp_cascade_p = readmatrix("Data/RTMP_Cascade_Packets.csv", NumHeaderLines=1);
x_rtmp_cascade_p = data_rtmp_cascade_p(:, 1);
y_rtmp_cascade_p = data_rtmp_cascade_p(:, 2);
plot(x_rtmp_cascade_p/60,y_rtmp_cascade_p, 'LineWidth',1.2)
avg_rtmp_cascade_p = mean(y_rtmp_cascade_p)
hold on

data_srt_cascade_p = readmatrix("Data/SRT_Cascade_Packets.csv", NumHeaderLines=1);
x_srt_cascade_p = data_srt_cascade_p(:, 1);
y_srt_cascade_p = data_srt_cascade_p(:, 2);
plot(x_srt_cascade_p/60,y_srt_cascade_p, 'LineWidth',1.2)
avg_srt_cascade_p = mean(y_srt_cascade_p)
hold on

title('Packets cascade stream', 'FontSize', 20)
xlim([0 5])
xlabel('Time [min]', 'FontSize', 20)
ylabel('Packets/s', 'FontSize', 20)
grid;
legend('TCP', 'UDP', 'RTSP', 'RTMP', 'SRT', 'FontSize', 16)