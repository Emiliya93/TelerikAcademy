########################################################
# UI map for XYZ
########################################################
from sikuli import *
########################################################

class TAP:
    button_CreateApp = "button_CreateApp.png"
    button_DoCreateApp = "button_DoCreateApp.png"
    label_AppName = Pattern("label_AppName.png").targetOffset(0,30)
    label_Code = "label_Code.png"
    label_ProjectNavigator = "label_ProjectNavigator.png"
    label_Properties = "label_Properties.png"
    label_Plugins = Pattern("label_Plugins.png").exact()
    label_BatteryPlugin = "image_BatteryPlugin.png"
    expander_BatteryPlugin = Pattern("image_BatteryPlugin.png").targetOffset(-74,1)
    label_Debug = "label_Debug.png"
    image_PluginConfigWarning = "image_PluginConfigWarning.png"


