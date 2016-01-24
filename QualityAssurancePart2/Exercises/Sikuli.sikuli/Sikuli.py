type("d", KeyModifier.WIN)
click("1452611692118.png")
type("t", Key.CTRL)
type("https://platform.telerik.com/")
type(Key.ENTER)

#"qatrack2016@telerik.local"
#"qatrack2016"

#click("1452612377066.png")
#click("1452612839083.png")
wait("1452612893185.png",5)
click("1452612893185.png")


click("1452612788367.png")

type("SomeApp")
click("1452612449091.png")
wait(5)
click("1452612598834.png")

if exists("1452613074695.png"):

    hover("1452613074695.png")
    click("1452613093027.png")
    exists("1452613148387.png")
    click("1452613172617.png")
    click("1452613206518.png")
else:
    print("Failed creating app SomeApp")


