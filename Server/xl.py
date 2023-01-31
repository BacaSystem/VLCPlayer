#https://d.docs.live.net/e3dce31bfe466966

import sys
from numpy import datetime_data
from openpyxl import load_workbook
import pandas as pd

path = 'C:\Work\Studia\inz\Server/Dane.xlsx'
out = 'C:\Work\Studia\inz\Server/wykres.xlsx'
book = load_workbook(path)
prot = ''

def write(arg):
    match arg:
        case "tcp":
            prot = 'TCP'
        case "udp":
            prot = 'UDP'
        case "rtsp":
            prot = 'RTSP'
        case "rtmp":
            prot = 'RTMP'
        case "srt":
            prot = 'SRT'
        case _:
            print ("Invalid Protocol: " + arg)
            return
    
    data = pd.read_excel(path, prot + '_Transcode')
    df = pd.DataFrame(data, columns= ['Godzina_s', 'Godzina_k', 'Czas_s', 'Czas_k'])[:1195]

    s_i = []
    k_i = []
    czas_s = []
    czas_k = []

    for index1, row1 in df.iterrows():
        for index2, row2 in df.iterrows():
            if(row1['Godzina_s'] == row2['Godzina_k']):
                s_i.append(index1+2)
                k_i.append(index2+2)
    for element in s_i:
        czas_s.append(df.at[element-2, 'Czas_s'])
    for element in k_i:
        czas_k.append(df.at[element-2, 'Czas_k'])

    data ['s']=pd.Series(czas_s)
    data ['k']=pd.Series(czas_k)

    writer = pd.ExcelWriter(out, engine='openpyxl')

    data.to_excel(writer,index=False)
    writer.save()
    writer.close()

if __name__ == "__main__":
    if(len(sys.argv) != 2):
        print("Must specify protocol")
    else:
        write(sys.argv[1])
