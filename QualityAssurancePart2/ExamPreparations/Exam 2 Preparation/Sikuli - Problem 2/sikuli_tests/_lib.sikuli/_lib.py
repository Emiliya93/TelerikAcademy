from sikuli import *
import HTMLTestRunner
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *

def Open(obj):
    #TestAction("Start Paint")
    sleep(0.5)
    type("d",KEY_WIN); sleep(1)
    type("r", KEY_WIN); sleep(1)
    type(obj); sleep(1)
    type(Key.ENTER)
    
    
def OpenImage(obj,image):
    #TestAction("Start Paint and open an image")
    sleep(0.5)
    type("d",KEY_WIN); sleep(1)
    type("r", KEY_WIN); sleep(1)
    type(obj +" ");
    type(image); sleep(1)
    type(Key.ENTER)
    
def SelectFigure():
    click(BS.figure)

def SelectColor():
    click(BS.color)
    
def ClosePaint():
    type(Key.F4, KEY_ALT)
    
def DrawRect():
    mouseMove(BS.start_point)
    mLoc=Env.getMouseLocation().offset(100,100)
    mouseMove(mLoc)
    mouseDown(Button.LEFT)
    mouseMove(mLoc.offset(200,100))
    mouseUp()
    
def SaveFile():
    type(Key.F4, KEY_ALT)
    sleep(1)
    type(Key.ENTER)
    sleep(1)
    type('C:\\Users\\ageorgieva\\Desktop\\t.png')
    sleep(3)
    type(Key.ENTER)
    
    
             