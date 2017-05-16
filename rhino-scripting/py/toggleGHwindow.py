import rhinoscriptsyntax as rs
import Rhino.RhinoApp as rh

gh = rh.GetPlugInObject("Grasshopper")

if not gh.IsEditorLoaded():
    gh.LoadEditor()

if gh.IsEditorVisible():
    gh.HideEditor()
else:
    gh.ShowEditor()