import configparser
c=configparser.RawConfigParser()
c.read('ConfigIni.ini')

print(c.get('Pattern','FileName'))
