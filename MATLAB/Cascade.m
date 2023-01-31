%% TCP
time_s_tcp_cascade = duration([ 
"00:00:16.36"
"00:00:16.86"
"00:00:40.86"
"00:01:00.86"
"00:01:01.36"
"00:01:26.40"
"00:01:48.40"
"00:02:11.40"
"00:02:11.93"
"00:02:31.93"
"00:02:53.43"
"00:03:16.43"
"00:03:41.93"
"00:04:04.40"
"00:04:27.93"
"00:04:53.43"
"00:05:16.93"
"00:06:01.43"
"00:06:01.93"
"00:06:24.43"
"00:06:24.93"
"00:06:49.43"
"00:06:49.96"
"00:07:11.93"
"00:07:12.46"
"00:07:34.93"
"00:07:35.46"
"00:07:58.43"
"00:08:22.93"
"00:08:23.46"
"00:08:23.96"
"00:08:43.93"
"00:09:05.96"
"00:09:30.43"
"00:09:30.96"
]);
time_c_tcp_cascade = duration([
"00:00:15.0890000"
"00:00:15.6170000"
"00:00:39.6010000"
"00:00:59.7000000"
"00:01:00.2550000"
"00:01:25.2890000"
"00:01:47.0800000"
"00:02:10.3200000"
"00:02:10.5850000"
"00:02:30.6890000"
"00:02:52.1550000"
"00:03:15.1420000"
"00:03:40.5790000"
"00:04:03.2120000"
"00:04:26.6810000"
"00:04:52.2750000"
"00:05:15.8440000"
"00:06:00.2900000"
"00:06:00.8220000"
"00:06:23.2010000"
"00:06:23.7440000"
"00:06:48.2450000"
"00:06:48.7550000"
"00:07:10.6490000"
"00:07:11.1740000"
"00:07:33.6530000"
"00:07:34.1780000"
"00:07:57.1830000"
"00:08:21.7010000"
"00:08:22.2530000"
"00:08:22.7800000"
"00:08:42.6190000"
"00:09:04.6000000"
"00:09:29.1170000"
"00:09:29.6480000"
]);

delay_tcp_cascade = time_s_tcp_cascade - time_c_tcp_cascade;
y_tcp_cascade =  milliseconds(delay_tcp_cascade);
x_tcp_cascade = minutes(time_c_tcp_cascade);
avg_delay_tcp_cascade = mean(y_tcp_cascade)

p_tcp_cascade = polyfit(x_tcp_cascade, y_tcp_cascade, 1);
y_avg_tcp_cascade = polyval(p_tcp_cascade, x_tcp_cascade);
figure(Name="Cascade")
subplot(2,3,1)
plot (x_tcp_cascade, y_tcp_cascade, '-b');
hold on
plot(x_tcp_cascade, y_avg_tcp_cascade, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('TCP Protocol')

%% UDP
time_s_udp_cascade = duration([
"00:00:16.86"
"00:00:17.36"
"00:00:40.86"
"00:01:02.86"
"00:01:03.36"
"00:01:24.86"
"00:01:25.36"
"00:01:48.40"
"00:02:12.86"
"00:02:36.86"
"00:02:59.36"
"00:02:59.90"
"00:03:22.36"
"00:03:22.86"
"00:03:46.90"
"00:04:10.43"
"00:04:10.93"
"00:05:00.43"
"00:05:23.96"
"00:05:48.96"
"00:06:13.50"
"00:06:14.00"
"00:06:36.50"
"00:06:37.00"
"00:07:01.00"
"00:07:22.53"
"00:07:49.03"
"00:08:14.03"
"00:08:37.03"
"00:08:37.53"
"00:09:01.03"
"00:09:23.53"
"00:09:24.03"
"00:09:48.03"
"00:09:48.53"

]);
time_c_udp_cascade = duration([
"00:00:15.6280000"
"00:00:16.1540000"
"00:00:39.6510000"
"00:01:01.5860000"
"00:01:02.1160000"
"00:01:23.7570000"
"00:01:24.0200000"
"00:01:47.2510000"
"00:02:11.5590000"
"00:02:35.5520000"
"00:02:58.1880000"
"00:02:58.7180000"
"00:03:21.1570000"
"00:03:21.6880000"
"00:03:45.6490000"
"00:04:09.1580000"
"00:04:09.6870000"
"00:04:59.3150000"
"00:05:22.8200000"
"00:05:47.6590000"
"00:06:12.1810000"
"00:06:12.7220000"
"00:06:35.3810000"
"00:06:35.9170000"
"00:06:59.8820000"
"00:07:21.2880000"
"00:07:47.7250000"
"00:08:12.7930000"
"00:08:35.7210000"
"00:08:36.2810000"
"00:08:59.7620000"
"00:09:22.1940000"
"00:09:22.7230000"
"00:09:46.7260000"
"00:09:47.2550000"
]);

delay_udp_cascade = time_s_udp_cascade - time_c_udp_cascade;
y_udp_cascade =  milliseconds(delay_udp_cascade);
x_udp_cascade = minutes(time_c_udp_cascade);
avg_delay_udp_cascade = mean(y_udp_cascade)

p_udp_cascade = polyfit(x_udp_cascade, y_udp_cascade, 1);
y_avg_udp_cascade = polyval(p_udp_cascade, x_udp_cascade);
subplot(2,3,2)
plot (x_udp_cascade, y_udp_cascade, '-b');
hold on
plot(x_udp_cascade, y_avg_udp_cascade, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('UDP Protocol')

%% RTMP
time_s_rtmp_cascade = duration([ 
"00:00:20.90"
"00:00:21.40"
"00:00:48.40"
"00:00:48.90"
"00:00:58.90"
"00:01:30.43"
"00:01:35.40"
"00:01:35.93"
"00:02:22.96"
"00:03:00.50"
"00:03:01.00"
"00:03:44.53"
"00:04:55.56"
"00:06:35.56"
"00:07:26.56"
"00:07:41.56"
"00:09:15.60"
"00:09:39.60"
"00:09:40.60"
]);
time_c_rtmp_cascade = duration([
"00:00:15.5680000"
"00:00:16.1010000"
"00:00:43.0330000"
"00:00:43.5690000"
"00:00:53.7010000"
"00:01:25.1670000"
"00:01:30.2330000"
"00:01:30.7680000"
"00:02:17.7010000"
"00:02:55.3000000"
"00:02:55.8340000"
"00:03:39.3000000"
"00:04:50.2340000"
"00:06:30.2340000"
"00:07:21.1670000"
"00:07:36.3680000"
"00:09:10.2340000"
"00:09:34.2330000"
"00:09:35.3010000"
]);

delay_rtmp_cascade = time_s_rtmp_cascade - time_c_rtmp_cascade;
y_rtmp_cascade =  milliseconds(delay_rtmp_cascade);
x_rtmp_cascade = minutes(time_c_rtmp_cascade);
avg_delay_rtmp_cascade = mean(y_rtmp_cascade)

p_rtmp_cascade = polyfit(x_rtmp_cascade, y_rtmp_cascade, 1);
y_avg_rtmp_cascade = polyval(p_rtmp_cascade, x_rtmp_cascade);
subplot(2,3,3)
plot (x_rtmp_cascade, y_rtmp_cascade, '-b');
hold on
plot(x_rtmp_cascade, y_avg_rtmp_cascade, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('RTMP Protocol')


%% RTSP
time_s_rtsp_cascade = duration ([
"00:00:14.80"
"00:00:39.80"
"00:01:03.80"
"00:01:49.80"
"00:01:50.80"
"00:02:36.83"
"00:03:44.33"
"00:03:44.86"
"00:04:05.33"
"00:04:05.86"
"00:04:27.36"
"00:04:50.83"
"00:04:51.36"
"00:05:11.83"
"00:05:12.86"
"00:05:38.40"
"00:06:00.90"
"00:06:47.93"
"00:06:48.43"
"00:07:10.43"
"00:07:11.43"
"00:07:11.93"
"00:07:33.93"
"00:07:56.43"
"00:08:18.46"
"00:08:37.96"
"00:09:00.46"
"00:09:23.00"
"00:09:46.00"
"00:09:46.50"
]);

time_c_rtsp_cascade = duration([
"00:00:13.3140000"
"00:00:38.2110000"
"00:01:02.2370000"
"00:01:48.2020000"
"00:01:49.2780000"
"00:02:35.4070000"
"00:03:42.7470000"
"00:03:43.2870000"
"00:04:03.8700000"
"00:04:04.4150000"
"00:04:25.8100000"
"00:04:49.3420000"
"00:04:49.8800000"
"00:05:10.4430000"
"00:05:11.2390000"
"00:05:36.8470000"
"00:05:59.2490000"
"00:06:46.5020000"
"00:06:46.7680000"
"00:07:08.9430000"
"00:07:10.0150000"
"00:07:10.5390000"
"00:07:32.4070000"
"00:07:54.8440000"
"00:08:16.8090000"
"00:08:36.4840000"
"00:08:58.8720000"
"00:09:21.3480000"
"00:09:44.5870000"
"00:09:44.8810000"
]);

delay_rtsp_cascade = time_s_rtsp_cascade - time_c_rtsp_cascade;
y_rtsp_cascade =  milliseconds(delay_rtsp_cascade);
x_rtsp_cascade = minutes(time_c_rtsp_cascade);
avg_delay_rtsp_cascade = mean(y_rtsp_cascade)

p_rtsp_cascade = polyfit(x_rtsp_cascade, y_rtsp_cascade, 1);
y_avg_rtsp_cascade = polyval(p_rtsp_cascade, x_rtsp_cascade);
subplot(2,3,4)
plot (x_rtsp_cascade, y_rtsp_cascade, '-b');
hold on
plot(x_rtsp_cascade, y_avg_rtsp_cascade, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');

title('RTSP Protocol')

%% SRT

time_s_srt_cascade = duration([
"00:00:17.90"
"00:00:38.90"
"00:00:39.40"
"00:01:44.40"
"00:02:08.40"
"00:02:08.90"
"00:02:31.40"
"00:02:53.40"
"00:03:14.40"
"00:03:36.40"
"00:03:58.90"
"00:03:59.40"
"00:04:21.40"
"00:04:43.90"
"00:04:44.40"
"00:05:06.40"
"00:05:06.90"
"00:05:28.90"
"00:05:29.40"
"00:05:50.40"
"00:05:50.93"
"00:07:02.00"
"00:07:46.53"
"00:08:12.53"
"00:08:37.56"
"00:09:00.56"
"00:09:23.56"
"00:09:47.56"
]);
time_c_srt_cascade = duration([
"00:00:16.4220000"
"00:00:37.6720000"
"00:00:38.2010000"
"00:01:43.0700000"
"00:02:07.0290000"
"00:02:07.5690000"
"00:02:30.1420000"
"00:02:52.1330000"
"00:03:13.1240000"
"00:03:35.1030000"
"00:03:57.6730000"
"00:03:58.1980000"
"00:04:20.0410000"
"00:04:42.5890000"
"00:04:43.1060000"
"00:05:05.0950000"
"00:05:05.6420000"
"00:05:27.7070000"
"00:05:27.9690000"
"00:05:49.1720000"
"00:05:49.6950000"
"00:07:00.6040000"
"00:07:45.2240000"
"00:08:11.0920000"
"00:08:36.1270000"
"00:08:59.1920000"
"00:09:22.3660000"
"00:09:46.2610000"
]);

delay_srt_cascade = time_s_srt_cascade - time_c_srt_cascade;
y_srt_cascade =  milliseconds(delay_srt_cascade);
x_srt_cascade = minutes(time_c_srt_cascade);
avg_delay_srt_cascade = mean(y_srt_cascade)

p_srt_cascade = polyfit(x_srt_cascade, y_srt_cascade, 1);
y_avg_srt_cascade = polyval(p_srt_cascade, x_srt_cascade);
subplot(2,3,5)
plot (x_srt_cascade, y_srt_cascade, '-b');
hold on
plot(x_srt_cascade, y_avg_srt_cascade, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('SRT Protocol')


subplot(2,3,6)
plot(x_tcp_cascade, y_avg_tcp_cascade);
hold on
plot(x_udp_cascade, y_avg_udp_cascade);
hold on
plot(x_rtsp_cascade, y_avg_rtsp_cascade);
hold on
plot(x_srt_cascade, y_avg_srt_cascade);
hold on
plot(x_rtmp_cascade, y_avg_rtmp_cascade);
hold on

xlabel('Stream time [min]');
ylabel('Delay [ms]');
title('Mean Delay');
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP');


figure(2)
plot(x_tcp_cascade, y_avg_tcp_cascade,'LineWidth',3);
hold on
plot(x_udp_cascade, y_avg_udp_cascade,'LineWidth',3);
hold on
plot(x_rtsp_cascade, y_avg_rtsp_cascade,'LineWidth',3);
hold on
plot(x_srt_cascade, y_avg_srt_cascade,'LineWidth',3);
hold on
plot(x_rtmp_cascade, y_avg_rtmp_cascade,'LineWidth',3);
hold on

xlabel('Stream time [min]', 'FontSize', 20);
ylabel('Delay [ms]', 'FontSize', 20);
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP', 'FontSize', 16);
title('Mean delay cascade stream', 'FontSize', 20)


