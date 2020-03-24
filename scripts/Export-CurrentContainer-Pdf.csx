#r "System.Linq"
#r "Core2D"

using System;
using System.IO;
using System.Linq;
using Core2D.FileWriter.PdfSharp;

var dir = "D:\\";
var page = Editor.Project.CurrentContainer;
var writer = Editor.FileWriters.FirstOrDefault(x => x.GetType() == typeof(PdfSharpWriter));
var path = Path.Combine(dir, page.Name + "." + writer.Extension);
writer.Save(path, page, Editor.Project);