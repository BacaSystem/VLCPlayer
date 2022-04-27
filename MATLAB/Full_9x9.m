%% TCP
time_s_tcp_concat = duration([ 
"00:00:19.16"
"00:00:19.66"
"00:00:51.66"
"00:01:22.66"
"00:01:48.16"
"00:02:15.66"
"00:02:16.66"
"00:02:18.20"
"00:02:46.16"
"00:03:19.66"
"00:03:20.20"
"00:03:48.66"
"00:03:49.66"
"00:04:23.66"
"00:04:24.16"
"00:04:24.66"
"00:04:56.66"
"00:05:28.16"
"00:06:00.66"
"00:06:29.16"
"00:06:29.70"
"00:06:53.16"
"00:07:21.16"
"00:07:47.16"
"00:08:16.16"
"00:08:47.66"
"00:09:22.16"
"00:09:22.66"
"00:09:48.66"]);
time_c_tcp_concat = duration([
"00:00:17.9800000"
"00:00:18.4950000"
"00:00:50.4030000"
"00:01:21.4580000"
"00:01:47.0320000"
"00:02:14.4560000"
"00:02:15.5430000"
"00:02:16.9170000"
"00:02:44.9550000"
"00:03:18.5350000"
"00:03:19.0370000"
"00:03:47.5800000"
"00:03:48.3960000"
"00:04:22.4980000"
"00:04:23.0330000"
"00:04:23.5830000"
"00:04:55.4510000"
"00:05:26.9120000"
"00:05:59.4800000"
"00:06:27.9090000"
"00:06:28.4500000"
"00:06:51.9530000"
"00:07:20.1170000"
"00:07:45.9480000"
"00:08:14.9830000"
"00:08:46.4830000"
"00:09:20.9950000"
"00:09:21.5290000"
"00:09:47.5360000"]);

delay_tcp_concat = time_s_tcp_concat - time_c_tcp_concat;
y_tcp_concat =  milliseconds(delay_tcp_concat);
x_tcp_concat = minutes(time_c_tcp_concat);
avg_delay_tcp_concat = mean(y_tcp_concat)

p_tcp_concat = polyfit(x_tcp_concat, y_tcp_concat, 1);
y_avg_tcp_concat = polyval(p_tcp_concat, x_tcp_concat);
figure(Name="Concatenate")
subplot(2,3,1)
plot (x_tcp_concat, y_tcp_concat, '-b');
hold on
plot(x_tcp_concat, y_avg_tcp_concat, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('TCP Protocol')

%% UDP
time_s_udp_concat = duration([ ...
"00:00:10.00"
"00:00:11.04"
"00:01:42.54"
"00:02:12.58"
"00:02:37.58"
"00:04:00.62"
"00:04:57.12"
"00:05:30.62"
"00:05:59.66"
"00:06:28.16"
"00:06:54.16"
"00:06:54.66"
"00:07:18.66"
"00:07:45.16"
"00:08:11.66"
"00:08:12.20"
"00:08:40.20"
"00:08:40.75"
"00:08:41.20"
"00:09:14.75"
"00:09:46.25"
"00:09:46.75"
]);
time_c_udp_concat = duration([ ...
"00:00:08.7430000"
"00:00:09.9130000"
"00:01:41.2880000"
"00:02:11.5370000"
"00:02:36.5410000"
"00:03:59.5260000"
"00:04:56.0060000"
"00:05:29.3690000"
"00:05:58.3740000"
"00:06:26.8710000"
"00:06:53.0690000"
"00:06:53.6220000"
"00:07:17.4050000"
"00:07:44.0800000"
"00:08:10.6170000"
"00:08:10.9100000"
"00:08:39.1630000"
"00:08:39.4510000"
"00:08:39.9960000"
"00:09:13.4460000"
"00:09:45.1920000"
"00:09:45.4550000"]);

delay_udp_concat = time_s_udp_concat - time_c_udp_concat;
y_udp_concat =  milliseconds(delay_udp_concat);
x_udp_concat = minutes(time_c_udp_concat);
avg_delay_udp_concat = mean(y_udp_concat)

p_udp_concat = polyfit(x_udp_concat, y_udp_concat, 1);
y_avg_udp_concat = polyval(p_udp_concat, x_udp_concat);
subplot(2,3,2)
plot (x_udp_concat, y_udp_concat, '-b');
hold on
plot(x_udp_concat, y_avg_udp_concat, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('UDP Protocol')

%% RTMP
time_s_rtmp_concat = duration([ ...
"00:00:14.16"
"00:00:40.33"
"00:01:11.58"
"00:01:12.08"
"00:01:12.58"
"00:01:44.58"
"00:01:45.08"
"00:01:45.58"
"00:01:46.08"
"00:02:15.08"
"00:02:48.62"
"00:02:49.12"
"00:02:49.62"
"00:02:50.12"
"00:03:47.12"
"00:04:23.16"
"00:04:23.66"
"00:04:33.66"
"00:04:34.16"
"00:04:34.66"
"00:05:02.66"
"00:05:33.16"
"00:05:33.66"
"00:06:18.16"
"00:06:18.66"
"00:06:48.70"
"00:07:54.70"
]);
time_c_rtmp_concat = duration([ ...
"00:00:10.1520000"
"00:00:36.7350000"
"00:01:06.2350000"
"00:01:06.8190000"
"00:01:07.3600000"
"00:01:39.2340000"
"00:01:39.7760000"
"00:01:40.2760000"
"00:01:40.7760000"
"00:02:09.8180000"
"00:02:43.3180000"
"00:02:43.8600000"
"00:02:44.4430000"
"00:02:44.6940000"
"00:03:41.8590000"
"00:04:17.7350000"
"00:04:18.2760000"
"00:04:28.3180000"
"00:04:28.8180000"
"00:04:29.3600000"
"00:04:57.4010000"
"00:05:27.8190000"
"00:05:28.3590000"
"00:06:12.9010000"
"00:06:13.4430000"
"00:06:43.4840000"
"00:07:49.4850000"
]);

delay_rtmp_concat = time_s_rtmp_concat - time_c_rtmp_concat;
y_rtmp_concat =  milliseconds(delay_rtmp_concat);
x_rtmp_concat = minutes(time_c_rtmp_concat);
avg_delay_rtmp_concat = mean(y_rtmp_concat)

p_rtmp_concat = polyfit(x_rtmp_concat, y_rtmp_concat, 1);
y_avg_rtmp_concat = polyval(p_rtmp_concat, x_rtmp_concat);
subplot(2,3,3)
plot (x_rtmp_concat, y_rtmp_concat, '-b');
hold on
plot(x_rtmp_concat, y_avg_rtmp_concat, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('RTMP Protocol')

%% RTSP
time_s_rtsp_concat = duration ([ ...
"00:00:09.95"
"00:00:10.45"
"00:00:39.45"
"00:00:40.45"
"00:01:10.45"
"00:01:11.50"
"00:02:03.50"
"00:02:27.50"
"00:02:54.50"
"00:03:24.04"
"00:03:45.04"
"00:04:11.54"
"00:04:38.54"
"00:04:39.04"
"00:04:39.54"
"00:05:03.54"
"00:05:04.04"
"00:05:33.54"
"00:05:59.04"
"00:06:23.04"
"00:06:23.54"
"00:06:24.04"
"00:06:24.54"
"00:06:50.54"
"00:06:51.54"
"00:06:52.04"
"00:06:53.08"
"00:07:48.08"
"00:07:49.08"
"00:08:16.08"
"00:08:40.08"
"00:09:10.58"
"00:09:33.08"
"00:09:34.08"
]);

time_c_rtsp_concat = duration([ ...
"00:00:07.3490000"
"00:00:07.8930000"
"00:00:36.9020000"
"00:00:38.0160000"
"00:01:08.0670000"
"00:01:08.9050000"
"00:02:00.8630000"
"00:02:25.0600000"
"00:02:52.1110000"
"00:03:21.5200000"
"00:03:42.6080000"
"00:04:09.0580000"
"00:04:36.1530000"
"00:04:36.4440000"
"00:04:36.9800000"
"00:05:01.1530000"
"00:05:01.4470000"
"00:05:30.9070000"
"00:05:56.4050000"
"00:06:20.5230000"
"00:06:21.0240000"
"00:06:21.6030000"
"00:06:22.1560000"
"00:06:48.1470000"
"00:06:49.0240000"
"00:06:49.6080000"
"00:06:50.4900000"
"00:07:45.5690000"
"00:07:46.6540000"
"00:08:13.5690000"
"00:08:37.4420000"
"00:09:07.9430000"
"00:09:30.5700000"
"00:09:31.4460000"
]);

delay_rtsp_concat = time_s_rtsp_concat - time_c_rtsp_concat;
y_rtsp_concat =  milliseconds(delay_rtsp_concat);
x_rtsp_concat = minutes(time_c_rtsp_concat);
avg_delay_rtsp_concat = mean(y_rtsp_concat)

p_rtsp_concat = polyfit(x_rtsp_concat, y_rtsp_concat, 1);
y_avg_rtsp_concat = polyval(p_rtsp_concat, x_rtsp_concat);
subplot(2,3,4)
plot (x_rtsp_concat, y_rtsp_concat, '-b');
hold on
plot(x_rtsp_concat, y_avg_rtsp_concat, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('RTSP Protocol')

%% SRT

time_s_srt_concat = duration([ ...
"00:00:27.37"
"00:01:47.87"
"00:02:13.37"
"00:02:38.87"
"00:03:04.87"
"00:03:30.41"
"00:03:59.41"
"00:04:27.41"
"00:04:27.91"
"00:04:53.41"
"00:04:53.91"
"00:05:18.41"
"00:05:42.41"
"00:06:06.41"
"00:06:34.91"
"00:06:57.41"
"00:06:57.91"
"00:07:52.95"
"00:08:41.00"
"00:09:09.00"
"00:09:35.04"
]);
time_c_srt_concat = duration([ ...
"00:00:25.9480000"
"00:01:46.6580000"
"00:02:12.1540000"
"00:02:37.4890000"
"00:03:03.6770000"
"00:03:29.1870000"
"00:03:58.1880000"
"00:04:26.1580000"
"00:04:26.6970000"
"00:04:52.1140000"
"00:04:52.7110000"
"00:05:17.1100000"
"00:05:41.1120000"
"00:06:05.1520000"
"00:06:33.4880000"
"00:06:56.0730000"
"00:06:56.6400000"
"00:07:51.6590000"
"00:08:39.6160000"
"00:09:07.8220000"
"00:09:33.7750000"
 ]);

delay_srt_concat = time_s_srt_concat - time_c_srt_concat;
y_srt_concat =  milliseconds(delay_srt_concat);
x_srt_concat = minutes(time_c_srt_concat);
avg_delay_srt_concat = mean(y_srt_concat)

p_srt_concat = polyfit(x_srt_concat, y_srt_concat, 1);
y_avg_srt_concat = polyval(p_srt_concat, x_srt_concat);
subplot(2,3,5)
plot (x_srt_concat, y_srt_concat, '-b');
hold on
plot(x_srt_concat, y_avg_srt_concat, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('SRT Protocol')


subplot(2,3,6)
plot(x_tcp_concat, y_avg_tcp_concat);
hold on
plot(x_udp_concat, y_avg_udp_concat);
hold on
plot(x_rtsp_concat, y_avg_rtsp_concat);
hold on
plot(x_srt_concat, y_avg_srt_concat);
hold on
plot(x_rtmp_concat, y_avg_rtmp_concat);
hold on

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP');
title('Delay of protocols')



