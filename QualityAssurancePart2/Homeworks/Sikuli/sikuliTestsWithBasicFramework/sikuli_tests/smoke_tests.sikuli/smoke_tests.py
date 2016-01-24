import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    #def test_001_NavigateToGoogle(self):
        #RunBrowserToUrl("chrome","http://www.google.com")
        #wait(Google.button_GoogleSearch, 30)
    
    #def test_002_Search(self):
        #click(Google.input_Search)
        #type(Google.input_Search, "Telerik Academy")
        #type(Key.ENTER)
        #wait(Google.label_AllResults, 30).highlight(1)

        #wait(Google.label_Telerik, 30)
        #assert exists(Google.label_Telerik)

        ##reg_SearchResults = find(Google.label_AllResults).grow(0, 500, 0, 500).highlight(2)
        ##reg_SearchResults.find(Google.label_Telerik).highlight(2)

    #def test_003_NavigateToDragNDrop(self):
        #RunBrowserToUrl("chrome", "http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html")
        #wait(DragNDrop.label_Capitals, 30)

    #def test_004_DragNDrop(self):
        #dragDrop(DragNDrop.box_City_Oslo, DragNDrop.box_Country_Norway)
        #dragDrop(DragNDrop.box_City_Stockholm, DragNDrop.box_Country_Sweden)
        #dragDrop(DragNDrop.box_City_Washington, DragNDrop.box_Country_UnitedStates)
        #dragDrop(DragNDrop.box_City_Copenhagen, DragNDrop.box_Country_Denmark)
        #dragDrop(DragNDrop.box_City_Seoul, DragNDrop.box_Country_SouthKorea)
        #dragDrop(DragNDrop.box_City_Rome, DragNDrop.box_Country_Italy)
        #dragDrop(DragNDrop.box_City_Madrid, DragNDrop.box_Country_Spain)

        #wait(DragNDrop.box_Combined_ItalyRome, 30)
        #assert exists(DragNDrop.box_Combined_ItalyRome)
        #assert exists(DragNDrop.box_Combined_SpainMadrid)
        #assert exists(DragNDrop.box_Combined_NorwayOslo)
        #assert exists(DragNDrop.box_Combined_DenmarkCopenhagen)
        #assert exists(DragNDrop.box_Combined_SouthKoreaSeoul)
        #assert exists(DragNDrop.box_Combined_SwedenStockholm)
        #assert exists(DragNDrop.box_Combined_USWashington)

    ##def test_005_MinimizeWindows(self):
        #type("d", Key.WIN)

        #type("r", Key.WIN)
        #type("chrome")
        #type(Key.ENTER)

        #type("r", Key.WIN)
        #type("firefox")
        #type(Key.ENTER)

        #type("r", Key.WIN)
        #type("iexplore")
        #type(Key.ENTER)

        #while exists(Browsers.button_Minimize):
        #    click(Browsers.button_Minimize)

    #def test_006_SendMessageInSkype(self):
        #type("d", Key.WIN)
        #type("r", Key.WIN)
        #type("skype")
        #type(Key.ENTER)

        #wait(Skype.input_Search, 20)
        #click(Skype.input_Search)
        #type("revention")

        #wait(Skype.label_NameOfFriend)
        #click(Skype.label_NameOfFriend)

        #wait(Skype.input_TypeMessage)
        #click(Skype.input_TypeMessage)
        #type("Test message :P")
        #type(Key.ENTER)

    def test_007_Calculator(self):
        type("d", Key.WIN)
        type(Key.WIN)
        type("calculator")
        type(Key.ENTER)

        wait(Calculator.label_Calculator, 30)
        type("1")
        sleep(1)
        type("+")
        sleep(1)
        type("1")
        sleep(1)
        type("=")
        type("c", Key.CTRL)

        self.assertEqual(Env.getClipboard(), "2")


if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)

    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()

