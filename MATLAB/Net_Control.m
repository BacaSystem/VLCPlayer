figure(1)
data_tcp_control = readmatrix("Data/TCP_Control.csv", NumHeaderLines=1);
x_tcp_control = data_tcp_control(:, 1);
y_tcp_control = data_tcp_control(:, 2);
plot(x_tcp_control/60,y_tcp_control/1e6, 'LineWidth',1.2)
avg_tcp_control = mean(y_tcp_control/1e6)
hold on

data_udp_control = readmatrix("Data/UDP_Control.csv", NumHeaderLines=1);
x_udp_control = data_udp_control(:, 1);
y_udp_control = data_udp_control(:, 2);
plot(x_udp_control/60,y_udp_control/1e6, 'LineWidth',1.2)
avg_udp_control = mean(y_udp_control/1e6)
hold on

data_rtsp_control = readmatrix("Data/RTSP_Control.csv", NumHeaderLines=1);
x_rtsp_control = data_rtsp_control(:, 1);
y_rtsp_control = data_rtsp_control(:, 2);
plot(x_rtsp_control/60,y_rtsp_control/1e6, 'LineWidth',1.2)
avg_rtsp_control = mean(y_rtsp_control/1e6)
hold on

data_rtmp_control = readmatrix("Data/RTMP_Control.csv", NumHeaderLines=1);
x_rtmp_control = data_rtmp_control(:, 1);
y_rtmp_control = data_rtmp_control(:, 2);
plot(x_rtmp_control/60,y_rtmp_control/1e6, 'LineWidth',1.2)
avg_rtmp_control = mean(y_rtmp_control(1:420)/1e6)
hold on

data_srt_control = readmatrix("Data/SRT_Control.csv", NumHeaderLines=1);
x_srt_control = data_srt_control(:, 1);
y_srt_control = data_srt_control(:, 2);
plot(x_srt_control/60,y_srt_control/1e6, 'LineWidth',2.0)
avg_srt_control = mean(y_srt_control/1e6)
hold on

title('Bandwith control stream', 'FontSize', 20)
xlim([0 10])
xlabel('Time [min]', 'FontSize', 20)
ylabel('Bandwith [Mb/s]', 'FontSize', 20)
grid;
legend('TCP', 'UDP', 'RTSP', 'RTMP', 'SRT', 'FontSize', 16)
%% 



figure(2)
data_tcp_control_p = readmatrix("Data/TCP_Control_Packets.csv", NumHeaderLines=1);
x_tcp_control_p = data_tcp_control_p(:, 1);
y_tcp_control_p = data_tcp_control_p(:, 2);
plot(x_tcp_control_p/60,y_tcp_control_p, 'LineWidth',1.2)
avg_tcp_control_p = mean(y_tcp_control_p)

hold on

data_udp_control_p = readmatrix("Data/UDP_Control_Packets.csv", NumHeaderLines=1);
x_udp_control_p = data_udp_control_p(:, 1);
y_udp_control_p = data_udp_control_p(:, 2);
plot(x_udp_control_p/60,y_udp_control_p, 'LineWidth',1.2)
avg_udp_control_p = mean(y_udp_control_p)
hold on

data_rtsp_control_p = readmatrix("Data/RTSP_Control_Packets.csv", NumHeaderLines=1);
x_rtsp_control_p = data_rtsp_control_p(:, 1);
y_rtsp_control_p = data_rtsp_control_p(:, 2);
plot(x_rtsp_control_p/60,y_rtsp_control_p, 'LineWidth',1.2)
avg_rtsp_control_p = mean(y_rtsp_control_p)
hold on

data_rtmp_control_p = readmatrix("Data/RTMP_Control_Packets.csv", NumHeaderLines=1);
x_rtmp_control_p = data_rtmp_control_p(:, 1);
y_rtmp_control_p = data_rtmp_control_p(:, 2);
plot(x_rtmp_control_p/60,y_rtmp_control_p, 'LineWidth',1.2)
avg_rtmp_control_p = mean(y_rtmp_control_p)
hold on

data_srt_control_p = readmatrix("Data/SRT_Control_Packets.csv", NumHeaderLines=1);
x_srt_control_p = data_srt_control_p(:, 1);
y_srt_control_p = data_srt_control_p(:, 2);
plot(x_srt_control_p/60,y_srt_control_p, 'LineWidth',1.2)
avg_srt_control_p = mean(y_srt_control_p)
hold on

title('Packets control stream', 'FontSize', 20)
xlim([0 10])
xlabel('Time [min]', 'FontSize', 20)
ylabel('Packets/s', 'FontSize', 20)
grid;
legend('TCP', 'UDP', 'RTSP', 'RTMP', 'SRT', 'FontSize', 16)