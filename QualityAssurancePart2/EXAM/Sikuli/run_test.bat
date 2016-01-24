set TestRunner="C:\Program Files (x86)\Sikuli\runsikulix.cmd"
set TestList="sikuli_tests\%1.sikuli"

call %TestRunner% -r %TestList%                 

