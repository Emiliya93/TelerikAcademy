from sikuli import *
import HTMLTestRunner
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *

def RunBrowserToUrl(browser,url):
    type('r',Key.WIN)
    type(browser + " " + url)
    type(Key.ENTER)

def OpenPlugins():
    doubleClick(TAP.label_Properties)
    wait(TAP.label_Plugins,15)
    click(TAP.label_Plugins)

def CloseCurrentTab():
    type('q', Key.CTRL)