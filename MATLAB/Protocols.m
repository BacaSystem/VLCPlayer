subplot(1,2,1)
plot(x_tcp_cascade, y_avg_tcp_cascade, 'b');
hold on
plot(x_udp_cascade, y_avg_udp_cascade, 'r');
hold on
plot(x_rtsp_cascade, y_avg_rtsp_cascade, 'm');
hold on
plot(x_srt_cascade, y_avg_srt_cascade, 'k');
hold on
plot(x_rtmp_cascade, y_avg_rtmp_cascade, 'g');

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('TCP','UDP', 'RTSP', 'SRT', 'RTMP');
title('Single stream')

subplot(1,2,2)
plot(x_tcp_concat, y_avg_tcp_concat, '--b');
hold on
plot(x_udp_concat, y_avg_udp_concat, '--r');
hold on
plot(x_rtsp_concat, y_avg_rtsp_concat, '--m');
hold on
plot(x_srt_concat, y_avg_srt_concat, '--k');
hold on
plot(x_rtmp_concat, y_avg_rtmp_concat, '--g');

xlabel('Stream time [min]');
ylabel('Delay [ms]');
grid;
legend('TCP Con','UDP Con', 'RTSP Con', 'SRT Con', 'RTMP Con');
title('Concatenated stream')