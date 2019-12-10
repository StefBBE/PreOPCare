

import wfdb
import sys
import os
ecgfile = 's0010_re'
channels = [1,3];

sampfrom_seconds = 1
sampto_seconds = 5


directory = 'M:\\PDMS\\PDMS\\Python'
os.chdir(directory)

signals,fields = wfdb.rdsamp(ecgfile, channels = channels)
sampling_frequency = fields ['fs']

sampfrom_samples = sampfrom_seconds * sampling_frequency
sampto_samples = sampto_seconds * sampling_frequency

record = wfdb.rdrecord(ecgfile, sampfrom = sampfrom_samples, sampto = sampto_samples,channels=channels)

wfdb.plot_wfdb(record = record, annotation = None, figsize=(15,7))

input()