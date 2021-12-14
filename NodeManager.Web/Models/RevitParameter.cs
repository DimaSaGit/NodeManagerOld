namespace NodeManager.Web.Models
{
    using System;
    public class RevitParameter
    {
        public int Id { get; set; }
        public Nullable<int> SymbolId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Nullable<int> StorageType { get; set; }
    
        public virtual FamilySymbol FamilySymbol { get; set; }
    }
}