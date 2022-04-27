%% TCP
time_s_tcp_cascade = duration([ 
]);
time_c_tcp_cascade = duration([
]);

delay_tcp_cascade = time_s_tcp_cascade - time_c_tcp_cascade;
y_tcp_cascade =  milliseconds(delay_tcp_cascade);
x_tcp_cascade = minutes(time_c_tcp_cascade);
avg_delay_tcp_cascade = mean(y_tcp_cascade)

p_tcp_cascade = polyfit(x_tcp_cascade, y_tcp_cascade, 1);
y_avg_tcp_cascade = polyval(p_tcp_cascade, x_tcp_cascade);
figure(1)
subplot(2,3,1)
plot (x_tcp_cascade, y_tcp_cascade, '-b');
hold on
plot(x_tcp_cascade, y_avg_tcp_cascade, '-r', 'LineWidth',2.0);

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('Delay','Mean delay');

%% UDP
time_s_udp_cascade = duration([ ...

]);
time_c_udp_cascade = duration([ ...
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
%% RTMP
time_s_rtmp_cascade = duration([ ...

]);
time_c_rtmp_cascade = duration([ ...

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

%% RTSP
time_s_rtsp_cascade = duration ([ ...
]);

time_c_rtsp_cascade = duration([ ...
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
%% SRT

time_s_srt_cascade = duration([ ...
]);
time_c_srt_cascade = duration([ ...
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


