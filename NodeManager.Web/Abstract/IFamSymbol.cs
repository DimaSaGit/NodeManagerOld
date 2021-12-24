using System.Collections;
using System.Collections.Generic;
using ConsoleApp111;

namespace NodeManager.Web.Abstract
{
    public interface IFamSymbol
    {
        IEnumerable<FamilySymbol> AllFamilySymbols { get; }
        IEnumerable<FamilySymbol> getFamilySymbol(int nodeId);
    }
}