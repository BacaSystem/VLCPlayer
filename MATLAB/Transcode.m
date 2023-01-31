%% TCP
time_s_tcp_transcode = duration([ 
"00:00:15.36"
"00:01:11.90"
"00:01:12.90"
"00:01:43.93"
"00:02:11.43"
"00:02:11.93"
"00:02:12.43"
"00:02:39.93"
"00:03:02.43"
"00:03:03.43"
"00:03:03.93"
"00:03:29.93"
"00:03:55.93"
"00:04:23.43"
"00:04:23.93"
"00:04:51.46"
"00:04:51.96"
"00:05:19.46"
"00:05:51.00"
"00:05:51.53"
"00:06:19.53"
"00:06:20.03"
"00:07:18.03"
"00:07:18.56"
"00:07:45.56"
"00:07:46.06"
"00:07:46.60"
"00:08:10.56"
"00:08:42.56"
"00:08:43.10"
"00:08:43.56"
"00:09:13.06"
"00:09:13.60"
"00:09:37.06"
"00:09:37.60"
]);
time_c_tcp_transcode = duration([
"00:00:14.1240000"
"00:01:10.7290000"
"00:01:11.7900000"
"00:01:42.6590000"
"00:02:10.1550000"
"00:02:10.6900000"
"00:02:11.2260000"
"00:02:38.7570000"
"00:03:01.3560000"
"00:03:02.2000000"
"00:03:02.7250000"
"00:03:28.8270000"
"00:03:54.7420000"
"00:04:22.2320000"
"00:04:22.7860000"
"00:04:50.2360000"
"00:04:50.7530000"
"00:05:18.2120000"
"00:05:49.7340000"
"00:05:50.2550000"
"00:06:18.3280000"
"00:06:18.8530000"
"00:07:16.7300000"
"00:07:17.2540000"
"00:07:44.2550000"
"00:07:44.7930000"
"00:07:45.3310000"
"00:08:09.3210000"
"00:08:41.3080000"
"00:08:41.8600000"
"00:08:42.3940000"
"00:09:11.9640000"
"00:09:12.4880000"
"00:09:35.9270000"
"00:09:36.4560000"
]);

delay_tcp_transcode = time_s_tcp_transcode - time_c_tcp_transcode;
y_tcp_transcode =  milliseconds(delay_tcp_transcode);
x_tcp_transcode = minutes(time_c_tcp_transcode);
avg_delay_tcp_transcode = mean(y_tcp_transcode)

p_tcp_transcode = polyfit(x_tcp_transcode, y_tcp_transcode, 1);
y_avg_tcp_transcode = polyval(p_tcp_transcode, x_tcp_transcode);
figure(Name="Cascade")
subplot(2,3,1)
plot (x_tcp_transcode, y_tcp_transcode, '-b');
hold on
plot(x_tcp_transcode, y_avg_tcp_transcode, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('TCP Protocol')

%% UDP
time_s_udp_transcode = duration([
"00:00:02.16"
"00:00:02.66"
"00:00:03.20"
"00:00:03.66"
"00:00:30.70"
"00:00:54.70"
"00:01:20.70"
"00:01:21.23"
"00:01:21.70"
"00:01:22.23"
"00:01:46.70"
"00:02:14.23"
"00:02:14.73"
"00:02:41.23"
"00:03:05.73"
"00:03:06.20"
"00:03:32.20"
"00:03:58.20"
"00:03:58.73"
"00:04:23.73"
"00:04:49.23"
"00:05:17.23"
"00:05:17.73"
"00:05:50.23"
"00:06:23.73"
"00:06:24.23"
"00:06:52.73"
"00:07:17.73"
"00:07:42.73"
"00:08:10.23"
"00:08:10.76"
"00:08:38.76"
"00:08:39.23"
"00:09:05.23"
"00:09:35.26"
"00:09:35.76"
"00:09:36.30"
"00:09:36.80"
"00:09:37.30"
]);
time_c_udp_transcode = duration([
"00:00:01.0530000"
"00:00:01.5910000"
"00:00:01.8520000"
"00:00:02.3900000"
"00:00:29.5570000"
"00:00:53.6170000"
"00:01:19.5490000"
"00:01:20.0910000"
"00:01:20.6270000"
"00:01:20.8900000"
"00:01:45.5230000"
"00:02:12.9930000"
"00:02:13.5270000"
"00:02:40.0560000"
"00:03:04.4160000"
"00:03:04.9590000"
"00:03:31.1300000"
"00:03:57.0840000"
"00:03:57.6530000"
"00:04:22.5220000"
"00:04:48.1570000"
"00:05:15.9290000"
"00:05:16.4520000"
"00:05:48.9880000"
"00:06:22.5580000"
"00:06:23.0940000"
"00:06:51.5530000"
"00:07:16.5870000"
"00:07:41.6590000"
"00:08:09.1300000"
"00:08:09.6510000"
"00:08:37.4510000"
"00:08:37.9900000"
"00:09:04.0560000"
"00:09:34.0210000"
"00:09:34.5340000"
"00:09:35.0520000"
"00:09:35.5950000"
"00:09:36.1180000"
]);

delay_udp_transcode = time_s_udp_transcode - time_c_udp_transcode;
y_udp_transcode =  milliseconds(delay_udp_transcode);
x_udp_transcode = minutes(time_c_udp_transcode);
avg_delay_udp_transcode = mean(y_udp_transcode)

p_udp_transcode = polyfit(x_udp_transcode, y_udp_transcode, 1);
y_avg_udp_transcode = polyval(p_udp_transcode, x_udp_transcode);
subplot(2,3,2)
plot (x_udp_transcode, y_udp_transcode, '-b');
hold on
plot(x_udp_transcode, y_avg_udp_transcode, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('UDP Protocol')

%% RTMP
time_s_rtmp_transcode = duration([ 
"00:00:13.83"
"00:00:49.83"
"00:01:21.83"
"00:01:50.83"
"00:02:37.36"
"00:06:02.40"
"00:06:30.90"
"00:06:31.40"
"00:06:31.90"
"00:06:46.90"
"00:06:47.40"
"00:07:16.40"
"00:07:16.93"
"00:07:48.43"
"00:07:48.93"
"00:08:21.96"
"00:09:02.96"
"00:09:03.46"
"00:09:32.96"
"00:09:33.46"
]);
time_c_rtmp_transcode = duration([
"00:00:08.6340000"
"00:00:44.6340000"
"00:01:16.6340000"
"00:01:45.4340000"
"00:02:32.1010000"
"00:05:57.1740000"
"00:06:25.7010000"
"00:06:25.9690000"
"00:06:26.5000000"
"00:06:41.7000000"
"00:06:41.9680000"
"00:07:11.0330000"
"00:07:11.5680000"
"00:07:43.0330000"
"00:07:43.5680000"
"00:08:16.6340000"
"00:08:57.7010000"
"00:08:58.2340000"
"00:09:27.5680000"
"00:09:28.1010000"
]);

delay_rtmp_transcode = time_s_rtmp_transcode - time_c_rtmp_transcode;
y_rtmp_transcode =  milliseconds(delay_rtmp_transcode);
x_rtmp_transcode = minutes(time_c_rtmp_transcode);
avg_delay_rtmp_transcode = mean(y_rtmp_transcode)

p_rtmp_transcode = polyfit(x_rtmp_transcode, y_rtmp_transcode, 1);
y_avg_rtmp_transcode = polyval(p_rtmp_transcode, x_rtmp_transcode);
subplot(2,3,3)
plot (x_rtmp_transcode, y_rtmp_transcode, '-b');
hold on
plot(x_rtmp_transcode, y_avg_rtmp_transcode, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('RTMP Protocol')


%% RTSP
time_s_rtsp_transcode = duration ([
"00:00:17.86"
"00:00:19.40"
"00:01:14.86"
"00:01:15.36"
"00:01:41.90"
"00:01:42.40"
"00:02:10.40"
"00:02:10.90"
"00:02:39.43"
"00:03:03.93"
"00:03:31.46"
"00:03:57.46"
"00:04:29.96"
"00:04:30.46"
"00:05:20.46"
"00:05:44.96"
"00:06:11.46"
"00:06:36.96"
"00:06:37.46"
"00:07:25.00"
"00:07:25.46"
"00:07:26.00"
"00:08:14.00"
"00:08:40.50"
"00:09:01.50"
"00:09:27.03"
"00:09:27.53"
"00:09:51.00"
"00:09:51.53"
]);

time_c_rtsp_transcode = duration([
"00:00:16.4800000"
"00:00:17.8240000"
"00:01:13.2850000"
"00:01:13.8250000"
"00:01:40.5160000"
"00:01:41.0550000"
"00:02:08.8810000"
"00:02:09.4170000"
"00:02:37.9460000"
"00:03:02.4980000"
"00:03:29.8800000"
"00:03:56.0190000"
"00:04:28.5180000"
"00:04:29.0550000"
"00:05:19.0590000"
"00:05:43.4140000"
"00:06:09.9130000"
"00:06:35.5180000"
"00:06:36.0520000"
"00:07:23.5520000"
"00:07:24.0940000"
"00:07:24.6180000"
"00:08:12.6490000"
"00:08:39.0220000"
"00:09:00.0490000"
"00:09:25.4960000"
"00:09:26.0260000"
"00:09:49.6820000"
"00:09:49.9630000"
]);

delay_rtsp_transcode = time_s_rtsp_transcode - time_c_rtsp_transcode;
y_rtsp_transcode =  milliseconds(delay_rtsp_transcode);
x_rtsp_transcode = minutes(time_c_rtsp_transcode);
avg_delay_rtsp_transcode = mean(y_rtsp_transcode)

p_rtsp_transcode = polyfit(x_rtsp_transcode, y_rtsp_transcode, 1);
y_avg_rtsp_transcode = polyval(p_rtsp_transcode, x_rtsp_transcode);
subplot(2,3,4)
plot (x_rtsp_transcode, y_rtsp_transcode, '-b');
hold on
plot(x_rtsp_transcode, y_avg_rtsp_transcode, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');

title('RTSP Protocol')

%% SRT

time_s_srt_transcode = duration([
"00:00:28.13"
"00:00:52.66"
"00:00:53.16"
"00:01:21.63"
"00:01:22.16"
"00:01:49.16"
"00:01:49.66"
"00:02:15.70"
"00:02:46.23"
"00:03:10.23"
"00:03:10.73"
"00:03:35.73"
"00:04:00.23"
"00:04:53.26"
"00:04:54.26"
"00:05:20.30"
"00:06:16.33"
"00:06:45.33"
"00:06:45.83"
"00:06:46.33"
"00:07:11.86"
"00:07:39.36"
"00:08:07.86"
"00:08:08.36"
"00:08:33.36"
"00:09:01.86"
"00:09:27.36"
"00:09:51.86"
]);
time_c_srt_transcode = duration([
"00:00:26.9460000"
"00:00:51.3160000"
"00:00:51.8510000"
"00:01:20.4240000"
"00:01:20.9400000"
"00:01:47.9620000"
"00:01:48.4810000"
"00:02:14.3470000"
"00:02:44.8280000"
"00:03:08.8580000"
"00:03:09.3770000"
"00:03:34.3500000"
"00:03:59.0110000"
"00:04:51.9940000"
"00:04:53.0430000"
"00:05:18.9800000"
"00:06:15.0460000"
"00:06:43.9170000"
"00:06:44.4460000"
"00:06:44.9920000"
"00:07:10.5570000"
"00:07:38.1540000"
"00:08:06.6480000"
"00:08:07.1740000"
"00:08:32.0250000"
"00:09:00.5110000"
"00:09:26.0610000"
"00:09:50.6450000"
]);

delay_srt_transcode = time_s_srt_transcode - time_c_srt_transcode;
y_srt_transcode =  milliseconds(delay_srt_transcode);
x_srt_transcode = minutes(time_c_srt_transcode);
avg_delay_srt_transcode = mean(y_srt_transcode)

p_srt_transcode = polyfit(x_srt_transcode, y_srt_transcode, 1);
y_avg_srt_transcode = polyval(p_srt_transcode, x_srt_transcode);
subplot(2,3,5)
plot (x_srt_transcode, y_srt_transcode, '-b');
hold on
plot(x_srt_transcode, y_avg_srt_transcode, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');
title('SRT Protocol')


subplot(2,3,6)
plot(x_tcp_transcode, y_avg_tcp_transcode);
hold on
plot(x_udp_transcode, y_avg_udp_transcode);
hold on
plot(x_rtsp_transcode, y_avg_rtsp_transcode);
hold on
plot(x_srt_transcode, y_avg_srt_transcode);
hold on
plot(x_rtmp_transcode, y_avg_rtmp_transcode);
hold on

xlabel('Stream time [min]');
ylabel('Delay [ms]');
title('Mean Delay');
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP');


figure(2)
plot(x_tcp_transcode, y_avg_tcp_transcode,'LineWidth',3);
hold on
plot(x_udp_transcode, y_avg_udp_transcode,'LineWidth',3);
hold on
plot(x_rtsp_transcode, y_avg_rtsp_transcode,'LineWidth',3);
hold on
plot(x_srt_transcode, y_avg_srt_transcode,'LineWidth',3);
hold on
plot(x_rtmp_transcode, y_avg_rtmp_transcode,'LineWidth',3);
hold on

xlabel('Stream time [min]', 'FontSize', 20);
ylabel('Delay [ms]', 'FontSize', 20);
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP', 'FontSize', 16);
title('Mean delay transcode stream', 'FontSize', 20)


