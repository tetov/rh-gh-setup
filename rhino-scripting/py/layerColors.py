import System.Drawing.Color
import rhinoscriptsyntax as rs
import random

def randomColor():
    r = random.randint(0,255)
    g = random.randint(0,255)
    b = random.randint(0,255)
    return (r,g,b)

layerList = rs.LayerNames()

for layer in layerList:
    if rs.LayerColor(layer, color=None) == System.Drawing.Color.Black:
        rs.LayerColor(layer, randomColor())