import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class SmokeTests(unittest.TestCase):
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    

    def test_001_OpenPaint(self):
         Open("mspaint")
         wait(BS.paint_title,10)

    def test_002_DrowFigure(self):
         SelectFigure()
         SelectColor()
         DrawRect()
         SaveFile()
         
    def test_003_VerifyFigure(self):
        OpenImage("mspaint", 'C:\\Users\\ageorgieva\\Desktop\\t.png')
        wait(BS.image_title,10)
        assert exists(BS.image)
    
    def test_004_ClosePaint(self):
        ClosePaint()
  
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='PaintTests Report' )
    runner.run(suite)
    outfile.close()

