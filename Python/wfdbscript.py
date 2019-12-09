

import wfdb
import sys
import os

try:
    
   
    ecgfile = sys.argv[1]
    stringarray = sys.argv[2].split(',')
    channels = []
    for i in range(len(stringarray)):
        channels.append(int(stringarray[i]))
		
    sampfrom_seconds = int(sys.argv[3])
    sampto_seconds = int(sys.argv[4])

    directory = 'M:\\PDMS\\PDMS\\Python'
    os.chdir(directory)

    signals,fields = wfdb.rdsamp(ecgfile, channels = channels)
    sampling_frequency = fields ['fs']

    sampfrom_samples = sampfrom_seconds * sampling_frequency
    sampto_samples = sampto_seconds * sampling_frequency

    record = wfdb.rdrecord(ecgfile, sampfrom = sampfrom_samples, sampto = sampto_samples,channels=channels)

    wfdb.plot_wfdb(record = record, annotation = None, figsize=(15,7))
	
except:
   
    for i in sys.exc_info():
	    print(i)
    input()
	

	

