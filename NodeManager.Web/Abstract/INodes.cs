using System.Collections;
using System.Collections.Generic;
using ConsoleApp111;
namespace NodeManager.Web.Abstract
{
    public interface INodes
    {
        IEnumerable<Node> AllNodes { get; }
            
    }
}