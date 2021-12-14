namespace NodeManager.Web.Models
{
    using System;
    public class FamilySymbol
    {
        public FamilySymbol()
        { }
    
        public int Id { get; set; }
        public Nullable<int> FamilyId { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> Scale { get; set; }
    
        public virtual Node Node { get; set; }
        
    }
}