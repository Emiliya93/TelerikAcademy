import unittest
import datetime
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

projName = "test" + datetime.datetime.now().strftime('%m%d_%H_%M_%S')

class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_NavigateToTap(self):
        RunBrowserToUrl("chrome","http://platform.telerik.com")
        wait(TAP.button_CreateApp, 30)

    def test_002_CreateApp(self):
        click(TAP.button_CreateApp)
        wait(TAP.button_DoCreateApp, 10)
        type(TAP.label_AppName, projName)
        click(TAP.button_DoCreateApp)
        wait(TAP.label_Code, 30)
        click(TAP.label_Code)
        wait(TAP.label_ProjectNavigator, 15)

    def test_003_ChangePluginConfiguration(self):
        OpenPlugins()
        click(TAP.expander_BatteryPlugin)
        click(TAP.label_Debug)
        find(TAP.label_BatteryPlugin).right().highlight(1).find(TAP.image_PluginConfigWarning)
        CloseCurrentTab(); sleep(1)
        OpenPlugins()
        find(TAP.label_BatteryPlugin).right().highlight(1).find(TAP.image_PluginConfigWarning)
        CloseCurrentTab()

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)

    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()

