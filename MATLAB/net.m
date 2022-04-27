data_tcp_concat = readmatrix("Data/TCP_Full_9x9.csv", NumHeaderLines=1);
x_tcp_concat = data(:, 1);
y_tcp_concat = data(:, 2);
plot(x_tcp_concat,y_tcp_concat)
hold on
