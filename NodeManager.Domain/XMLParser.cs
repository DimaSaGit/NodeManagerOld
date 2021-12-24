using System;
using System.Xml.Linq;
using System.Linq;

namespace ConsoleApp111
{
    class XMLParser
    {
        public OldDB XMLToObjects(XDocument doc)
        {
            RevitProject rpj = new RevitProject();
            RevitView rv = new RevitView();
            RevitParameterOld rpo = new RevitParameterOld();

            var db = new OldDB();
			foreach (XElement el in doc.Element("NodeManagerDB").Elements("Projects").Elements("RevitProject"))
			{
                rpj = new RevitProject(el.Element("Name").Value,
                    el.Element("Filepath").Value,
                    Convert.ToInt32(el.Element("NumberOfSaves").Value),
                    el.Element("Tags").Value);
                db.RevProjects.Add(rpj);

                foreach (XElement element in el.Elements("Views").Elements("RevitView"))
				{
                    rv = new RevitView(Convert.ToInt32(element.Element("ViewId").Value),
                        element.Element("ViewName").Value,
                        Convert.ToInt32(element.Element("Scale").Value),
                        rpj);
                    db.RevViews.Add(rv);
                }
            }
            return db;
        }

        /*public void XMLToDataBase(XDocument doc)
        {
            RevitProject rpj = new RevitProject();
            RevitView rv = new RevitView();
            RevitParameterOld rpo = new RevitParameterOld();

            using (NodeManagerDBEntities context = new NodeManagerDBEntities())
            {
                foreach (XElement el in doc.Element("NodeManagerDB").Elements("Projects").Elements("RevitProject"))
                {
                    context.Nodes.Add(
                             new Node
                             {
                                 Name = el.Element("Name").Value,
                                 FilePath = el.Element("Filepath").Value
                             });
                    context.SaveChanges();


                    foreach (XElement element in el.Elements("Views").Elements("RevitView"))
                    {
                        context.FamilySymbols.Add(
                            new FamilySymbol
                            {
                                FamilyId = context.Nodes.FirstOrDefault(r => r.Name == el.Element("Name").Value).Id,
                                Name = element.Element("ViewName").Value,
                                ImagePath = element.Element("ImagePath").Value,
                                Scale = Convert.ToInt32(element.Element("Scale").Value)
                            });



                    }
                }
            }
        }*/
    }
}
