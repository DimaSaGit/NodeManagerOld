using System.Collections;
using System.Collections.Generic;
using ConsoleApp111;
namespace NodeManager.Web.Abstract
{
    public interface INodes
    {
        IEnumerable<Node> Nodes { get; }
        IEnumerable<FamilySymbol> FamilySymbols { get; }
        IEnumerable<RevitParameter> RevParameters { get; }

    }
}