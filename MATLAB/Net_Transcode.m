figure(1)
data_tcp_transcode = readmatrix("Data/TCP_Transcode.csv", NumHeaderLines=1);
x_tcp_transcode = data_tcp_transcode(:, 1);
y_tcp_transcode = data_tcp_transcode(:, 2);
plot(x_tcp_transcode/60,y_tcp_transcode/1e6, 'LineWidth',1.2)
avg_tcp_transcode = mean(y_tcp_transcode/1e6)
hold on

data_udp_transcode = readmatrix("Data/UDP_Transcode.csv", NumHeaderLines=1);
x_udp_transcode = data_udp_transcode(:, 1);
y_udp_transcode = data_udp_transcode(:, 2);
plot(x_udp_transcode/60,y_udp_transcode/1e6, 'LineWidth',1.2)
avg_udp_transcode = mean(y_udp_transcode/1e6)
hold on

data_rtsp_transcode = readmatrix("Data/RTSP_Transcode.csv", NumHeaderLines=1);
x_rtsp_transcode = data_rtsp_transcode(:, 1);
y_rtsp_transcode = data_rtsp_transcode(:, 2);
plot(x_rtsp_transcode/60,y_rtsp_transcode/1e6, 'LineWidth',1.2)
avg_rtsp_transcode = mean(y_rtsp_transcode/1e6)
hold on

data_rtmp_transcode = readmatrix("Data/RTMP_Transcode.csv", NumHeaderLines=1);
x_rtmp_transcode = data_rtmp_transcode(:, 1);
y_rtmp_transcode = data_rtmp_transcode(:, 2);
plot(x_rtmp_transcode/60,y_rtmp_transcode/1e6, 'LineWidth',1.2)
avg_rtmp_transcode = mean(y_rtmp_transcode(1:300)/1e6)
hold on

data_srt_transcode = readmatrix("Data/SRT_Transcode.csv", NumHeaderLines=1);
x_srt_transcode = data_srt_transcode(:, 1);
y_srt_transcode = data_srt_transcode(:, 2);
plot(x_srt_transcode/60,y_srt_transcode/1e6, 'LineWidth',2.0)
avg_srt_transcode = mean(y_srt_transcode/1e6)
hold on

title('Bandwith transcode stream', 'FontSize', 20)
xlim([0 5])
xlabel('Time [min]', 'FontSize', 20)
ylabel('Bandwith [Mb/s]', 'FontSize', 20)
grid;
legend('TCP', 'UDP', 'RTSP', 'RTMP', 'SRT', 'FontSize', 16)
%% 



figure(2)
data_tcp_transcode_p = readmatrix("Data/TCP_Transcode_Packets.csv", NumHeaderLines=1);
x_tcp_transcode_p = data_tcp_transcode_p(:, 1);
y_tcp_transcode_p = data_tcp_transcode_p(:, 2);
plot(x_tcp_transcode_p/60,y_tcp_transcode_p, 'LineWidth',1.2)
avg_tcp_transcode_p = mean(y_tcp_transcode_p)

hold on

data_udp_transcode_p = readmatrix("Data/UDP_Transcode_Packets.csv", NumHeaderLines=1);
x_udp_transcode_p = data_udp_transcode_p(:, 1);
y_udp_transcode_p = data_udp_transcode_p(:, 2);
plot(x_udp_transcode_p/60,y_udp_transcode_p, 'LineWidth',1.2)
avg_udp_transcode_p = mean(y_udp_transcode_p)
hold on

data_rtsp_transcode_p = readmatrix("Data/RTSP_Transcode_Packets.csv", NumHeaderLines=1);
x_rtsp_transcode_p = data_rtsp_transcode_p(:, 1);
y_rtsp_transcode_p = data_rtsp_transcode_p(:, 2);
plot(x_rtsp_transcode_p/60,y_rtsp_transcode_p, 'LineWidth',1.2)
avg_rtsp_transcode_p = mean(y_rtsp_transcode_p)
hold on

data_rtmp_transcode_p = readmatrix("Data/RTMP_Transcode_Packets.csv", NumHeaderLines=1);
x_rtmp_transcode_p = data_rtmp_transcode_p(:, 1);
y_rtmp_transcode_p = data_rtmp_transcode_p(:, 2);
plot(x_rtmp_transcode_p/60,y_rtmp_transcode_p, 'LineWidth',1.2)
avg_rtmp_transcode_p = mean(y_rtmp_transcode_p(1:300))
hold on

data_srt_transcode_p = readmatrix("Data/SRT_Transcode_Packets.csv", NumHeaderLines=1);
x_srt_transcode_p = data_srt_transcode_p(:, 1);
y_srt_transcode_p = data_srt_transcode_p(:, 2);
plot(x_srt_transcode_p/60,y_srt_transcode_p, 'LineWidth',1.2)
avg_srt_transcode_p = mean(y_srt_transcode_p)
hold on

title('Packets transcode stream', 'FontSize', 20)
xlim([0 5])
xlabel('Time [min]', 'FontSize', 20)
ylabel('Packets/s', 'FontSize', 20)
grid;
legend('TCP', 'UDP', 'RTSP',  'RTMP', 'SRT', 'FontSize', 16)