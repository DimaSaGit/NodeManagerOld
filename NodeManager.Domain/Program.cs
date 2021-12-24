using System;
using System.Xml.Linq;
using System.Linq;
//using System.Windows.Forms;


namespace ConsoleApp111
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var upload = new DBUploader();
            upload.UploadToDB();
            //using (NodeManagerDBEntities context = new NodeManagerDBEntities())
            //{
            //    context.FamilySymbols.Where(r => r.Id != 0);
            //    context.FamilySymbols.RemoveRange(context.FamilySymbols.Where(r => r.Id != 0));
            //    context.Nodes.RemoveRange(context.Nodes.Where(r => r.Id != 0));
            //    context.SaveChanges();
            //}
        }
    }
}
