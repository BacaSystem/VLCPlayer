subplot(1,2,1)
plot(x_tcp, y_avg_tcp, 'b');
hold on
plot(x_udp, y_avg_udp, 'r');
hold on
plot(x_rtsp, y_avg_rtsp, 'm');
hold on
plot(x_srt, y_avg_srt, 'k');
hold on
plot(x_rtmp, y_avg_rtmp, 'g');

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