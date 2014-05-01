import sys
sys.path.append(r'C:\Program Files (x86)\IronPython 2.7\Lib')

import os

def simple():
    print "Hello from Python."
    print "os.getcwd()=", os.getcwd()
    print "Call dir()"
    print dir()
    print "Print the path: "
    print sys.path
