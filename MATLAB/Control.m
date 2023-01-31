%% TCP
time_s_tcp_control = duration([ 
"00:00:17.62"
"00:00:18.12"
"00:00:39.12"
"00:01:01.12"
"00:01:22.12"
"00:01:22.62"
"00:01:45.62"
"00:01:46.12"
"00:02:08.62"
"00:02:31.62"
"00:02:54.62"
"00:02:55.12"
"00:03:17.12"
"00:03:37.62"
"00:03:58.62"
"00:04:20.62"
"00:04:43.12"
"00:05:34.16"
"00:05:57.16"
"00:06:42.16"
"00:07:29.16"
"00:07:52.20"
"00:08:17.16"
"00:08:39.16"
"00:09:27.20"
"00:09:51.20"
]);
time_c_tcp_control = duration([
"00:00:16.4170000"
"00:00:16.9590000"
"00:00:38.0410000"
"00:01:00.0410000"
"00:01:20.9560000"
"00:01:21.4990000"
"00:01:44.3330000"
"00:01:44.8740000"
"00:02:07.4440000"
"00:02:30.4080000"
"00:02:53.3660000"
"00:02:53.9550000"
"00:03:15.8720000"
"00:03:36.5400000"
"00:03:57.3210000"
"00:04:19.4150000"
"00:04:42.0400000"
"00:05:32.9160000"
"00:05:55.9040000"
"00:06:40.9520000"
"00:07:27.9110000"
"00:07:50.9880000"
"00:08:16.0750000"
"00:08:38.0840000"
"00:09:26.0270000"
"00:09:49.9580000"
]);

delay_tcp_control = time_s_tcp_control - time_c_tcp_control;
y_tcp_control =  milliseconds(delay_tcp_control);
x_tcp_control = minutes(time_c_tcp_control);
avg_delay_tcp_control = mean(y_tcp_control)

p_tcp_control = polyfit(x_tcp_control, y_tcp_control, 1);
y_avg_tcp_control = polyval(p_tcp_control, x_tcp_control);
figure(Name="control")
subplot(2,3,1)
plot (x_tcp_control, y_tcp_control, '-b');
hold on
plot(x_tcp_control, y_avg_tcp_control, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('TCP Protocol')

%% UDP
time_s_udp_control = duration([
"00:00:06.37"
"00:00:06.87"
"00:00:31.87"
"00:01:16.87"
"00:01:39.37"
"00:02:02.87"
"00:02:49.87"
"00:03:13.87"
"00:03:37.87"
"00:03:59.87"
"00:04:00.37"
"00:04:23.37"
"00:04:45.87"
"00:05:08.37"
"00:05:56.95"
"00:05:57.45"
"00:06:22.95"
"00:06:23.50"
"00:06:46.45"
"00:07:08.95"
"00:07:30.45"
"00:07:31.00"
"00:07:31.50"
"00:07:52.50"
"00:07:53.00"
"00:08:17.00"
"00:08:17.50"
"00:08:41.04"
"00:08:41.54"
"00:09:04.04"
"00:09:51.04"
"00:09:51.54"
]);
time_c_udp_control = duration([
"00:00:05.0740000"
"00:00:05.6140000"
"00:00:30.6860000"
"00:01:15.6860000"
"00:01:38.2340000"
"00:02:01.6460000"
"00:02:48.6160000"
"00:03:12.7700000"
"00:03:36.7690000"
"00:03:58.6120000"
"00:03:59.1980000"
"00:04:22.1580000"
"00:04:44.6880000"
"00:05:07.3210000"
"00:05:55.8540000"
"00:05:56.3670000"
"00:06:21.7780000"
"00:06:22.3170000"
"00:06:45.2280000"
"00:07:07.8610000"
"00:07:29.2840000"
"00:07:29.8240000"
"00:07:30.3650000"
"00:07:51.3120000"
"00:07:51.8670000"
"00:08:15.9060000"
"00:08:16.1990000"
"00:08:39.9370000"
"00:08:40.2340000"
"00:09:02.7400000"
"00:09:49.7330000"
"00:09:50.3220000"
]);

delay_udp_control = time_s_udp_control - time_c_udp_control;
y_udp_control =  milliseconds(delay_udp_control);
x_udp_control = minutes(time_c_udp_control);
avg_delay_udp_control = mean(y_udp_control)

p_udp_control = polyfit(x_udp_control, y_udp_control, 1);
y_avg_udp_control = polyval(p_udp_control, x_udp_control);
subplot(2,3,2)
plot (x_udp_control, y_udp_control, '-b');
hold on
plot(x_udp_control, y_avg_udp_control, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('UDP Protocol')

%% RTMP
time_s_rtmp_control = duration([ 
"00:00:09.58"
"00:00:10.12"
"00:00:25.08"
"00:00:25.62"
"00:00:38.58"
"00:00:39.12"
"00:00:49.08"
"00:00:51.12"
"00:01:12.58"
"00:01:40.08"
"00:01:40.62"
"00:02:07.08"
"00:02:33.08"
"00:02:33.62"
"00:03:00.58"
"00:03:26.12"
"00:03:26.62"
"00:03:49.62"
"00:04:27.12"
"00:04:54.12"
"00:05:15.12"
"00:05:15.62"
"00:05:39.62"
"00:05:40.12"
"00:06:22.66"
"00:06:23.16"
"00:06:49.16"
"00:06:49.66"
"00:07:32.16"
"00:07:56.66"
"00:08:19.66"
"00:08:49.16"
"00:09:45.66"
"00:09:46.16"
]);

time_c_rtmp_control = duration([
"00:00:04.4430000"
"00:00:04.9430000"
"00:00:19.7340000"
"00:00:20.2340000"
"00:00:33.2340000"
"00:00:33.7760000"
"00:00:43.7340000"
"00:00:45.7760000"
"00:01:07.3180000"
"00:01:34.8180000"
"00:01:35.3180000"
"00:02:01.8180000"
"00:02:27.8590000"
"00:02:28.4020000"
"00:02:55.3590000"
"00:03:20.9440000"
"00:03:21.2340000"
"00:03:44.4430000"
"00:04:21.9010000"
"00:04:48.8180000"
"00:05:09.9010000"
"00:05:10.1930000"
"00:05:34.3590000"
"00:05:34.9010000"
"00:06:17.3180000"
"00:06:17.9010000"
"00:06:43.9430000"
"00:06:44.4430000"
"00:07:26.8590000"
"00:07:51.4840000"
"00:08:14.2760000"
"00:08:43.7760000"
"00:09:40.3590000"
"00:09:40.8590000"
]);

delay_rtmp_control = time_s_rtmp_control - time_c_rtmp_control;
y_rtmp_control =  milliseconds(delay_rtmp_control);
x_rtmp_control = minutes(time_c_rtmp_control);
avg_delay_rtmp_control = mean(y_rtmp_control)

p_rtmp_control = polyfit(x_rtmp_control, y_rtmp_control, 1);
y_avg_rtmp_control = polyval(p_rtmp_control, x_rtmp_control);
subplot(2,3,3)
plot (x_rtmp_control, y_rtmp_control, '-b');
hold on
plot(x_rtmp_control, y_avg_rtmp_control, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('RTMP Protocol')


%% RTSP
time_s_rtsp_control = duration ([
"00:00:21.16"
"00:00:44.16"
"00:00:44.66"
"00:01:05.16"
"00:01:27.16"
"00:01:27.66"
"00:01:28.16"
"00:01:50.66"
"00:01:51.16"
"00:02:12.66"
"00:02:34.66"
"00:02:35.16"
"00:02:57.16"
"00:02:57.66"
"00:03:20.66"
"00:03:44.66"
"00:04:08.66"
"00:04:09.16"
"00:04:33.66"
"00:04:55.16"
"00:05:16.16"
"00:05:39.16"
"00:05:39.70"
"00:06:02.70"
"00:06:25.66"
"00:06:26.20"
"00:06:51.20"
"00:07:14.20"
"00:07:58.70"
"00:07:59.20"
"00:08:20.70"
"00:08:43.20"
"00:09:08.75"
"00:09:09.25"
"00:09:09.75"
"00:09:10.25"
"00:09:33.75"
]);

time_c_rtsp_control = duration([
"00:00:19.6080000"
"00:00:42.7750000"
"00:00:43.0700000"
"00:01:03.5270000"
"00:01:25.6480000"
"00:01:26.1500000"
"00:01:26.7380000"
"00:01:49.1530000"
"00:01:49.6980000"
"00:02:11.0709999"
"00:02:33.2260000"
"00:02:33.7380000"
"00:02:55.5250000"
"00:02:56.1010000"
"00:03:19.2800000"
"00:03:43.2290000"
"00:04:07.0720000"
"00:04:07.6310000"
"00:04:32.0720000"
"00:04:53.7350000"
"00:05:14.6510000"
"00:05:37.7370000"
"00:05:38.3100000"
"00:06:01.1890000"
"00:06:24.1140000"
"00:06:24.6560000"
"00:06:49.6490000"
"00:07:12.6560000"
"00:07:57.1040000"
"00:07:57.6919999"
"00:08:19.3090000"
"00:08:41.6520000"
"00:09:07.2000000"
"00:09:07.7280000"
"00:09:08.2290000"
"00:09:08.7590000"
"00:09:32.1830000"
]);

delay_rtsp_control = time_s_rtsp_control - time_c_rtsp_control;
y_rtsp_control =  milliseconds(delay_rtsp_control);
x_rtsp_control = minutes(time_c_rtsp_control);
avg_delay_rtsp_control = mean(y_rtsp_control)

p_rtsp_control = polyfit(x_rtsp_control, y_rtsp_control, 1);
y_avg_rtsp_control = polyval(p_rtsp_control, x_rtsp_control);
subplot(2,3,4)
plot (x_rtsp_control, y_rtsp_control, '-b');
hold on
plot(x_rtsp_control, y_avg_rtsp_control, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');

title('RTSP Protocol')

%% SRT

time_s_srt_control = duration([
"00:00:19.12"
"00:00:43.12"
"00:01:06.62"
"00:01:30.16"
"00:01:30.66"
"00:01:52.66"
"00:01:53.16"
"00:02:15.66"
"00:02:16.16"
"00:02:37.16"
"00:02:37.66"
"00:02:58.66"
"00:03:23.16"
"00:03:23.70"
"00:03:46.70"
"00:04:10.16"
"00:04:10.70"
"00:04:55.16"
"00:04:55.70"
"00:05:20.70"
"00:05:21.20"
"00:05:44.20"
"00:06:06.70"
"00:06:07.20"
"00:06:30.70"
"00:07:16.20"
"00:07:39.70"
"00:08:02.75"
"00:08:29.25"
"00:08:29.75"
"00:09:17.25"
"00:09:17.75"
]);
time_c_srt_control = duration([
"00:00:17.7100000"
"00:00:41.8780000"
"00:01:05.3350000"
"00:01:28.8650000"
"00:01:29.4160000"
"00:01:51.2930000"
"00:01:51.8350000"
"00:02:14.1980000"
"00:02:14.7560000"
"00:02:35.7930000"
"00:02:36.3360000"
"00:02:57.3770000"
"00:03:21.7930000"
"00:03:22.3340000"
"00:03:45.2410000"
"00:04:08.9990000"
"00:04:09.2930000"
"00:04:53.8740000"
"00:04:54.4440000"
"00:05:19.4180000"
"00:05:19.9930000"
"00:05:43.0030000"
"00:06:05.4480000"
"00:06:06.0340000"
"00:06:29.4600000"
"00:07:15.0340000"
"00:07:38.3750000"
"00:08:01.3350000"
"00:08:28.0420000"
"00:08:28.3340000"
"00:09:15.9930000"
"00:09:16.5370000"
]);

delay_srt_control = time_s_srt_control - time_c_srt_control;
y_srt_control =  milliseconds(delay_srt_control);
x_srt_control = minutes(time_c_srt_control);
avg_delay_srt_control = mean(y_srt_control)

p_srt_control = polyfit(x_srt_control, y_srt_control, 1);
y_avg_srt_control = polyval(p_srt_control, x_srt_control);
subplot(2,3,5)
plot (x_srt_control, y_srt_control, '-b');
hold on
plot(x_srt_control, y_avg_srt_control, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('SRT Protocol')


subplot(2,3,6)
plot(x_tcp_control, y_avg_tcp_control);
hold on
plot(x_udp_control, y_avg_udp_control);
hold on
plot(x_rtsp_control, y_avg_rtsp_control);
hold on
plot(x_srt_control, y_avg_srt_control);
hold on
plot(x_rtmp_control, y_avg_rtmp_control);
hold on

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP');
title('Mean Delay')


figure(2)
plot(x_tcp_control, y_avg_tcp_control,'LineWidth',3);
hold on
plot(x_udp_control, y_avg_udp_control,'LineWidth',3);
hold on
plot(x_rtsp_control, y_avg_rtsp_control,'LineWidth',3);
hold on
plot(x_srt_control, y_avg_srt_control,'LineWidth',3);
hold on
plot(x_rtmp_control, y_avg_rtmp_control,'LineWidth',3);
hold on

xlabel('Stream time [min]', 'FontSize', 20);
ylabel('Delay [ms]', 'FontSize', 20);
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP', 'FontSize', 16);
title('Mean delay control stream', 'FontSize', 20)

