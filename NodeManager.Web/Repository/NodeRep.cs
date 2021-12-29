using System.Collections.Generic;
using ConsoleApp111;
using System.Linq;
using NodeManager.Web.Abstract;
using ConsoleApp111;
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

        public IEnumerable<Node> Nodes => dbContext.Nodes;

        public IEnumerable<FamilySymbol> FamilySymbols => dbContext.FamilySymbols.Include(p => p.Node);

        public IEnumerable<RevitParameter> RevParameters => dbContext.RevitParameters.Include(p => p.FamilySymbol);
    }
}