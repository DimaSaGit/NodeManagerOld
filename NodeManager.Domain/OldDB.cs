using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111
{
    class OldDB
    {
        public List<RevitProject> RevProjects = new List<RevitProject>();
        public List<RevitView> RevViews = new List<RevitView>();
        public List<RevitParameterOld> RevParameters = new List<RevitParameterOld>();

        public OldDB()
        {
            this.RevProjects = new List<RevitProject>();
            this.RevViews = new List<RevitView>();
            this.RevParameters = new List<RevitParameterOld>();
        }
    }
}
