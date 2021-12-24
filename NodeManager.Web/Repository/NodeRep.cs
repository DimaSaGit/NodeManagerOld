using System.Collections.Generic;
using ConsoleApp111;
using System.Linq;
using NodeManager.Web.Abstract;
using Microsoft.EntityFrameworkCore;
namespace NodeManager.Web.Repository
{
    public class NodeRep : INodes
    {
        private readonly NodeManagerDBEntities dbContext;

        public NodeRep(NodeManagerDBEntities dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Node> AllNodes => dbContext.Nodes.Include(c => c.Name);
    }
}