import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *


class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass

    def tearDownClass(cls):
        click(Apps.label_Account)
        if exists(Apps.box_Project):
            hover(Apps.box_Project)
            click(Apps.button_Delete)
            exists(Apps.label_DeleteMessage)
            click(Apps.checkbox_AcceptDeletion)
            click(Apps.button_Delete)
        else:
            print("Failed deleting app TestProject")

    def test_001_NavigateToTap(self):
        RunBrowserToUrl("chrome","http://platform.telerik.com")
        wait(TAP.button_CreateApp, 30)
    
    def test_002_CreateApp(self):
        click(TAP.button_CreateApp)
        wait(TAP.button_DoCreateApp, 10)
        type(TAP.label_AppName, "TestProject")
        click(TAP.button_DoCreateApp)
        wait(TAP.label_Code, 30).highlight(1)

    def test_003_CreateHtmlFile(self):
        click(TAP.label_Code)
        wait(TAP.label_Application, 30)
        click(TAP.label_Application)
        type("n", KeyModifier.CTRL + KeyModifier.ALT)
        click(TAP.button_Ok)

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)

    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()

