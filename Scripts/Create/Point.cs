
var e = Context.Editor;
var p = Context.Editor.Project;
var c = p.CurrentStyleLibrary;
var point = XPoint.Create(30, 30, p.Options.PointShape);

e.AddWithHistory(point);
c.CurrentLayer.Invalidate();
