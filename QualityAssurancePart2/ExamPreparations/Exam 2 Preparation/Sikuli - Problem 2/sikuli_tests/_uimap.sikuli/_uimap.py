########################################################
# UI map for XYZ
########################################################
from sikuli import *
########################################################

class BS:
    paint_title="paint_title.png"
    figure=Pattern("circle.png").similar(0.74).targetOffset(1,0)
    color=Pattern("color.png").similar(0.82)
    start_point=Pattern("editor.png").targetOffset(-180,-66)
    image_title="title.png"
    image="t.png"
    
