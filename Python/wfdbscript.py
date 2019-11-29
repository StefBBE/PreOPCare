#!/usr/bin/env python3

import wfdb
import sys
import os
print('hello world')
ecgfile = sys.argv[1]
channels = [0];
stringarray = sys.argv[2].split(',')
for i in range(len(stringarray)-1):
    channels[i] = int(stringarray[i])

sampfrom_seconds = int(sys.argv[3])
sampto_seconds = int(sys.argv[4])


directory = '/Users/michaelbarta/wfdb_test/'+ ecgfile
os.chdir(directory)

signals,fields = wfdb.rdsamp(ecgfile, channels = channels)
sampling_frequency = fields ['fs']

sampfrom_samples = sampfrom_seconds * sampling_frequency
sampto_samples = sampto_seconds * sampling_frequency

record = wfdb.rdrecord(ecgfile, sampfrom = sampfrom_samples, sampto = sampto_samples,channels=channels)

wfdb.plot_wfdb(record = record, annotation = None, figsize=(15,7))