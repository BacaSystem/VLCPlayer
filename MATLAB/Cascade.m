%% TCP
time_s_tcp_cascade = duration([ 
"00:00:29.12"
"00:00:29.62"
"00:01:01.62"
"00:01:02.12"
"00:01:35.62"
"00:01:36.12"
"00:01:36.66"
"00:02:10.62"
"00:02:11.12"
"00:02:42.62"
"00:02:43.12"
"00:02:43.62"
"00:03:15.66"
"00:03:45.66"
"00:04:23.16"
"00:04:23.66"
"00:04:24.16"
"00:05:01.66"
"00:05:02.16"
"00:05:32.66"
"00:05:33.16"
"00:06:04.16"
"00:06:04.66"
"00:06:05.16"
"00:06:44.16"
"00:06:44.66"
"00:07:18.16"
"00:07:18.70"
"00:07:54.16"
"00:07:54.70"
"00:08:33.20"
"00:08:33.70"
"00:08:34.20"
"00:09:12.20"
"00:09:12.70"
"00:09:41.70"
"00:09:42.20"
]);
time_c_tcp_cascade = duration([
"00:00:27.9920000"
"00:00:28.2840000"
"00:01:00.3540000"
"00:01:00.9030000"
"00:01:34.4900000"
"00:01:35.0750000"
"00:01:35.3650000"
"00:02:09.5210000"
"00:02:10.0750000"
"00:02:41.4500000"
"00:02:41.9900000"
"00:02:42.5300000"
"00:03:14.4430000"
"00:03:44.3200000"
"00:04:21.8660000"
"00:04:22.4030000"
"00:04:22.9870000"
"00:05:00.6140000"
"00:05:00.8760000"
"00:05:31.4900000"
"00:05:32.0750000"
"00:06:02.9890000"
"00:06:03.5730000"
"00:06:03.8640000"
"00:06:43.1160000"
"00:06:43.3760000"
"00:07:16.8650000"
"00:07:17.4380000"
"00:07:52.9850000"
"00:07:53.5280000"
"00:08:31.9460000"
"00:08:32.5290000"
"00:08:33.0680000"
"00:09:10.9490000"
"00:09:11.5330000"
"00:09:40.5210000"
"00:09:41.0740000"
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
"00:00:27.62"
"00:00:59.62"
"00:01:34.62"
"00:01:35.12"
"00:01:35.62"
"00:01:36.12"
"00:02:11.12"
"00:02:11.62"
"00:02:44.62"
"00:02:45.12"
"00:03:17.62"
"00:03:18.12"
"00:03:48.62"
"00:03:49.12"
"00:04:20.12"
"00:04:55.66"
"00:04:56.16"
"00:05:27.66"
"00:06:02.66"
"00:06:32.66"
"00:06:33.16"
"00:07:04.66"
"00:07:35.66"
"00:08:13.16"
"00:08:13.66"
"00:08:14.16"
"00:08:48.16"
"00:08:48.66"
"00:09:18.66"
"00:09:19.16"
"00:09:49.16"
"00:09:49.66"
]);
time_c_udp_cascade = duration([
"00:00:26.2860000"
"00:00:58.4520000"
"00:01:33.2810000"
"00:01:33.8610000"
"00:01:34.4120000"
"00:01:34.9950000"
"00:02:09.9910000"
"00:02:10.2840000"
"00:02:43.3140000"
"00:02:43.8690000"
"00:03:16.4490000"
"00:03:17.0330000"
"00:03:47.3140000"
"00:03:47.8650000"
"00:04:18.9390000"
"00:04:54.4070000"
"00:04:54.9900000"
"00:05:26.4480000"
"00:06:01.4390000"
"00:06:31.5760000"
"00:06:31.8660000"
"00:07:03.5790000"
"00:07:34.4810000"
"00:08:11.8270000"
"00:08:12.4110000"
"00:08:12.9620000"
"00:08:46.9540000"
"00:08:47.5360000"
"00:09:17.5780000"
"00:09:17.8700000"
"00:09:47.9090000"
"00:09:48.4910000"
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
"00:01:24.20"
"00:02:01.20"
"00:02:01.75"
"00:02:36.25"
"00:02:36.75"
"00:02:37.25"
"00:03:10.25"
"00:04:07.79"
"00:04:36.29"
"00:05:30.29"
"00:05:30.79"
"00:05:56.79"
"00:05:57.29"
"00:06:36.33"
"00:07:14.29"
"00:07:14.79"
"00:07:15.33"
"00:07:42.79"
"00:07:43.29"
"00:07:43.83"
"00:08:38.83"
"00:08:39.33"
"00:09:28.33"
]);
time_c_rtmp_cascade = duration([
"00:01:18.9840000"
"00:01:55.9000000"
"00:01:56.4440000"
"00:02:31.0680000"
"00:02:31.3180000"
"00:02:31.8590000"
"00:03:05.0250000"
"00:04:02.5260000"
"00:04:30.9010000"
"00:05:24.9850000"
"00:05:25.5260000"
"00:05:51.4020000"
"00:05:51.9420000"
"00:06:31.1080000"
"00:07:08.9830000"
"00:07:09.4840000"
"00:07:10.0690000"
"00:07:37.6080000"
"00:07:38.1080000"
"00:07:38.6080000"
"00:08:33.4430000"
"00:08:33.9840000"
"00:09:22.9010000"
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
"00:00:31.75"
"00:00:32.29"
"00:01:04.29"
"00:01:04.79"
"00:01:32.79"
"00:02:40.83"
"00:02:41.33"
"00:03:13.33"
"00:03:13.83"
"00:03:40.33"
"00:03:40.83"
"00:04:12.33"
"00:04:12.83"
"00:04:40.33"
"00:05:13.33"
"00:05:13.87"
"00:05:49.87"
"00:06:22.87"
"00:06:57.37"
"00:06:57.87"
"00:06:58.37"
"00:06:58.87"
"00:07:30.37"
"00:07:58.87"
"00:07:59.37"
"00:08:31.37"
"00:09:38.91"
]);

time_c_rtsp_cascade = duration([
"00:00:29.0960000"
"00:00:29.6500000"
"00:01:01.7210000"
"00:01:01.9830000"
"00:01:30.0240000"
"00:02:38.2760000"
"00:02:38.5560000"
"00:03:10.5650000"
"00:03:11.1050000"
"00:03:37.5960000"
"00:03:38.1370000"
"00:04:09.7360000"
"00:04:10.2740000"
"00:04:37.6800000"
"00:05:10.6470000"
"00:05:11.2310000"
"00:05:47.1940000"
"00:06:20.1870000"
"00:06:54.5660000"
"00:06:55.1440000"
"00:06:55.7270000"
"00:06:56.0180000"
"00:07:27.7280000"
"00:07:56.1780000"
"00:07:56.7320000"
"00:08:28.6900000"
"00:09:36.3040000"
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
"00:00:32.12"
"00:01:58.70"
"00:01:59.20"
"00:02:39.20"
"00:02:39.70"
"00:02:40.20"
"00:03:20.25"
"00:03:20.75"
"00:03:56.25"
"00:03:56.75"
"00:04:37.29"
"00:04:37.79"
"00:04:38.29"
"00:05:17.29"
"00:05:17.83"
"00:05:18.33"
"00:05:18.83"
"00:05:55.79"
"00:05:56.33"
"00:05:56.83"
"00:06:40.33"
"00:06:40.83"
"00:06:41.33"
"00:06:41.83"
"00:07:21.83"
"00:07:22.33"
"00:07:22.83"
"00:08:00.83"
"00:08:01.83"
"00:08:41.33"
"00:08:41.83"
"00:08:42.33"
"00:08:42.83"
"00:09:20.33"
]);
time_c_srt_cascade = duration([
"00:00:30.9160000"
"00:01:57.2420000"
"00:01:57.8270000"
"00:02:37.7480000"
"00:02:38.3320000"
"00:02:38.9060000"
"00:03:19"
"00:03:19.5400000"
"00:03:55.0790000"
"00:03:55.3680000"
"00:04:36.0250000"
"00:04:36.5690000"
"00:04:37.1210000"
"00:05:15.8670000"
"00:05:16.4490000"
"00:05:17.0010000"
"00:05:17.5800000"
"00:05:54.4540000"
"00:05:55.0370000"
"00:05:55.6210000"
"00:06:38.8680000"
"00:06:39.4510000"
"00:06:40"
"00:06:40.5790000"
"00:07:20.5360000"
"00:07:21.0650000"
"00:07:21.6190000"
"00:07:59.6590000"
"00:08:00.5320000"
"00:08:40.0800000"
"00:08:40.6590000"
"00:08:40.9480000"
"00:08:41.4990000"
"00:09:19.0820000"
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
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP');


