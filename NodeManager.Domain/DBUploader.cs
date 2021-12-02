using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConsoleApp111
{
    class DBUploader
    {
        public void UploadToDB()
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = ofd.FileName;

            XDocument doc = XDocument.Load(fileName);

            using (NodeManagerDBEntities context = new NodeManagerDBEntities())
            {
                var xmlParser = new XMLParser();
                var oldDb = xmlParser.XMLToObjects(doc);

                foreach (var i in oldDb.RevProjects)
                {
                    context.Nodes.Add(
                        new Node
                        {
                            Name = i.Name,
                            FilePath = i.FilePath
                        });
                }
                context.SaveChanges();
                foreach (var j in oldDb.RevViews)
                {
                    context.FamilySymbols.Add(
                        new FamilySymbol
                        {
                            FamilyId = context.Nodes.FirstOrDefault(r => r.Name == j.RevProj.Name).Id,
                            Name = j.Name,
                            ImagePath = j.ImagePath,
                            Scale = j.Scale
                        });
                }
                context.SaveChanges();
                foreach (var z in oldDb.RevParameters)
                {
                    context.RevitParameters.Add(
                        new RevitParameter
                        {
                            SymbolId = context.FamilySymbols.FirstOrDefault(r => r.Name == z.RevView.Name).Id,
                            Name = z.Name,
                            Value = z.Value,
                            StorageType = z.StorageType
                        });
                }
                context.SaveChanges();
            }
        }
    }
}
