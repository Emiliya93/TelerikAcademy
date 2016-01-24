import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_NavigateToTasks(self):
        type("d", Key.WIN)
        type("r", Key.WIN)
        type("D:\Users\Emi\GitHub\!TelerikAcademy\QualityAssurancePart2\EXAM\Sikuli\Exam.html")
        type(Key.ENTER)

    def test_002_SelectAnOption(self):
        wait(TaskA.dropdown_Select, 30)
        click(TaskA.dropdown_Select)

        wait(TaskA.dropdown_MercedesBenzC, 20)
        click(TaskA.dropdown_MercedesBenzC)

        wait(TaskA.dropdown_SelectedMercedesBenzC, 20).highlight(2)
        assert exists(TaskA.dropdown_SelectedMercedesBenzC)

    def test_003_CheckItemsWithDots(self):
        #wait(SikuliTasks.label_TaskB, 20)
        #find(SikuliTasks.label_TaskB).highlight(2)
        #checkboxes = find(SikuliTasks.label_TaskB).grow(0, 1000, 0, 400).highlight(2)
        #find(SikuliTasks.label_TaskB).right().grow().highlight(2)

        wait(TaskB.checkbox_checked, 20)
        checked = findAll(TaskB.checkbox_checked)

        for box in checked:
            box.highlight(2)
            click(box)

        unchecked = findAll(TaskB.checkbox_unchecked)

        for box in unchecked:
            box.highlight(2)
            box.right().highlight(2)
            label = box.right()

            try:
                label.find(TaskB.label_Dots)
                box.right().find(TaskB.label_Dots).highlight(2)
                click(box)
                print("Dots found here")
            except FindFailed:
                print("Dots Not found here")


if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)

    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()

